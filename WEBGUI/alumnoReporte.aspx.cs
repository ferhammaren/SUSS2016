using SUSS2016.CLASES;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBGUI
{
    public partial class alumnoReporte : System.Web.UI.Page
    {
        string serverPath = "C:\\xampp\\htdocs\\SUSS\\";
        //string serverPath = "127.0.0.1:49321/";
        protected void Page_Load(object sender, EventArgs e)
        {

            Label nameLabel = (Label)Master.FindControl("lbNombre");
            //  System.Diagnostics.Debug.WriteLine(Session["UsuarioId"].ToString());
            if (Session["UsuarioId"] != null)
            {
                Alumnos.getInfoAlumno(Convert.ToInt32(Session["UsuarioId"].ToString()));
                nameLabel.Text = Alumnos.getNombre();
            }
            else
            {
                Literal ltr = new Literal();
                ltr.Text = @"<script type='text/javascript'> alert('No iniciaste sesión') </script>";
                this.Controls.Add(ltr);
                Response.Redirect("~/index.aspx");
            }
        }

        protected void subirReporte_Click(object sender, EventArgs e)
        {
            string[] extensiones = { ".doc", ".docx", ".pdf" };
            string extensionDoc = Path.GetExtension(elegirReporte.PostedFile.FileName);
            string etapaRep;
            if (elegirReporte.HasFile && (extensiones.Contains(extensionDoc)))
            {
                try
                {
                    if (etapaReporte.SelectedIndex == 0)
                    {
                        etapaRep = "\\Reportes_etapa1\\";
                        if (tipoReporte.SelectedIndex == 0)
                        {
                            elegirReporte.SaveAs(serverPath + etapaRep + "\\Reporte_trimestral\\" + Alumnos.getMatricula() + extensionDoc);
                        }
                        else if (tipoReporte.SelectedIndex == 1)
                        {
                            elegirReporte.SaveAs(serverPath + etapaRep + "\\Reporte_final\\" + Alumnos.getMatricula() + extensionDoc);

                        }

                    }
                    else if (etapaReporte.SelectedIndex == 1)
                    {
                        etapaRep = "\\Reportes_etapa2\\";
                        if (tipoReporte.SelectedIndex == 0)
                        {
                            elegirReporte.SaveAs(serverPath + etapaRep + "\\Reporte_trimestral\\" + Alumnos.getMatricula() + extensionDoc);
                        }
                        else if (tipoReporte.SelectedIndex == 1)
                        {
                            elegirReporte.SaveAs(serverPath + etapaRep + "\\Reporte_final\\" + Alumnos.getMatricula() + extensionDoc);

                        }
                    }
                    //string 
                    //elegirReporte.SaveAs(Server.MapPath(serverPath) + Path.GetFileName(elegirReporte.PostedFile.FileName));
                    //elegirReporte.SaveAs(serverPath + Path.GetFileName(elegirReporte.PostedFile.FileName));
                    //System.Diagnostics.Debug.WriteLine(Request.ApplicationPath);
                    //System.Diagnostics.Debug.WriteLine(Server.MapPath(serverPath));
                    //elegirReporte.SaveAs(Server.Web.HttpContext.Current.Server.MapPath("~") + Path.GetFileName(elegirReporte.PostedFile.FileName));

                }
                catch (Exception ex)
                {

                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo Dfile = new System.IO.FileInfo(serverPath);
        }
    }
}