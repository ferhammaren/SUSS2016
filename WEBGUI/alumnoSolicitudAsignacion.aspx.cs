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
        bool flag1 = false;
        bool flag2 = false;
        string filename;
        string filename1;
        protected void Page_Load(object sender, EventArgs e)
        {
            Label nameLabel = (Label)Master.FindControl("lbNombre");
            //  System.Diagnostics.Debug.WriteLine(Session["UsuarioId"].ToString());
            if (Session["UsuarioId"] != null)
            {
                Alumnos.getInfoAlumno(Convert.ToInt32(Session["UsuarioId"].ToString()));

                nameLabel.Text = Alumnos.getNombre();
                flag1 = false;
                flag2 = false;
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
            if (flag1 && flag2 == false)
            {

                Literal ltr = new Literal();
                ltr.Text = @"<script type='text/javascript'> alert('Debes subir tus archivos con horario') </script>";
                this.Controls.Add(ltr);
            }
            else
            {
                
                solicitudesAsignacion.enviarSolicitudUR(Convert.ToInt32(Session["programaSelected"]), Alumnos.getMatricula(), Calendar1.SelectedDate, Calendar2.SelectedDate);
                Response.Redirect("~/alumnoMain.aspx");
            }


        }

        protected void btnPrestacion_Click(object sender, EventArgs e)
        {
            flag1 = true;
            if (fuHoraPrestacion.HasFile)
            {
                if (fuHoraPrestacion.PostedFile.ContentType == "text/doc" || fuHoraPrestacion.PostedFile.ContentType == "text/docx" || fuHoraPrestacion.PostedFile.ContentType == "text/pdf") { }
                try
                {
                     filename = Path.GetFileName(fuHoraPrestacion.FileName);
                    fuHoraPrestacion.SaveAs("C:\\xampp\\htdocs\\SUSS\\horariosPrestacion\\" + filename);
                    solicitudesAsignacion.hprestacion = "C:\\xampp\\htdocs\\SUSS\\horariosPrestacion\\" + filename;
                    statusLabel.Text = "Archivo cargado";

                    //agregar solicitud
                  
                }
                catch (Exception ex)
                {
                    statusLabel.Text = "No se pudo cargar el archivo";
                }
            }
          
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            flag2 = true;
            if (fuHoraClases.HasFile)
            {
                if (fuHoraClases.PostedFile.ContentType == "text/doc" || fuHoraClases.PostedFile.ContentType == "text/docx" || fuHoraClases.PostedFile.ContentType == "text/pdf") { }
                try
                {
                   filename1 = Path.GetFileName(fuHoraClases.FileName);
                    fuHoraClases.SaveAs("C:\\xampp\\htdocs\\SUSS\\horariosAlumnos\\" + filename1);
                    solicitudesAsignacion.hAlumno = "C:\\xampp\\htdocs\\SUSS\\horariosAlumnos\\" + filename1;
                    statusLabel1.Text = "Archivo cargado";


                }
                catch (Exception ex)
                {
                    statusLabel1.Text = "No se pudo cargar el archivo";
                }



            }
        }
    }
}
