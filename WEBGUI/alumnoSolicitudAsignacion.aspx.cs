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
    public partial class alumnoSolicitudAsignacion : System.Web.UI.Page
    {
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

        protected void FormView2_PageIndexChanging(object sender, FormViewPageEventArgs e)
        {

        }

        protected void Button1_Command(object sender, CommandEventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (fuHoraPrestacion.HasFile)
            {
                if (fuHoraPrestacion.PostedFile.ContentType == "text/doc" || fuHoraPrestacion.PostedFile.ContentType == "text/docx" || fuHoraPrestacion.PostedFile.ContentType == "text/pdf") { }
                try
                {
                    string filename = Path.GetFileName(fuHoraPrestacion.FileName);
                    fuHoraPrestacion.SaveAs("C:\\xampp\\htdocs\\SUSS\\horariosPrestacion\\" + filename);
                    statusLabel.Text = "Archivo cargado";

                    #region subir horario de clases
                    if (fuHoraClases.HasFile)
                    {
                        if (fuHoraClases.PostedFile.ContentType == "text/doc" || fuHoraPrestacion.PostedFile.ContentType == "text/docx" || fuHoraPrestacion.PostedFile.ContentType == "text/pdf") { }
                        try
                        {
                            string filename1 = Path.GetFileName(fuHoraClases.FileName);
                            fuHoraClases.SaveAs("C:\\xampp\\htdocs\\SUSS\\horariosAlumnos\\" + filename1);
                            statusLabel1.Text = "Archivo cargado";

                            //agregar solicitud
                            
                        }
                        catch (Exception ex)
                        {
                            statusLabel1.Text = "No se pudo cargar el archivo";
                        }
                    }
                    #endregion
                }
                catch (Exception ex)
                {
                    statusLabel.Text = "No se pudo cargar el archivo";
                }



            }

        }
    }
}
