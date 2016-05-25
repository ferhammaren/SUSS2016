using SUSS2016.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace WEBGUI
{
    public partial class alumnoMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label nameLabel = (Label)Master.FindControl("lbNombre");
          //  System.Diagnostics.Debug.WriteLine(Session["UsuarioId"].ToString());
            if (!Session["UsuarioId"].Equals(""))
            {
                Alumnos.getInfoAlumno(Convert.ToInt32(Session["UsuarioId"].ToString()));
             
                nameLabel.Text = Alumnos.getNombre();
            }
            else
            {

            }
        }
    }
}