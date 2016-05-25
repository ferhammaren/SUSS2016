using SUSS2016.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WEBGUI
{
    public partial class alumnoCatalogoProgramas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label nameLabel = (Label)Master.FindControl("lbNombre");
            //  System.Diagnostics.Debug.WriteLine(Session["UsuarioId"].ToString());
            if (Session["UsuarioId"] != null)
            {
                Alumnos.getInfoAlumno(Convert.ToInt32(Session["UsuarioId"].ToString()));

                nameLabel.Text = Alumnos.getNombre();
                if (Session["Etapa"] == null)
                {
                    Session["Etapa"] = 1;
                }

            }
            else
            {
                Literal ltr = new Literal();
                ltr.Text = @"<script type='text/javascript'> alert('No iniciaste sesión') </script>";
                this.Controls.Add(ltr);
                Response.Redirect("~/index.aspx");
            }
        }
        protected void MyButtonClick(object sender, System.EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            Session["programaSelected"] = Convert.ToInt32(gvr.Cells[0].Text);
            Response.Redirect("~/alumnoSolicitudAsignacion.aspx");
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["Etapa"] = DropDownList1.SelectedValue;
            Response.Redirect("~/alumnoCatalogoProgramas.aspx");
        }


    }
}