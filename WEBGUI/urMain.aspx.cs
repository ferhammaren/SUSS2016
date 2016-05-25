using SUSS2016.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBGUI
{
    public partial class urMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            //  System.Diagnostics.Debug.WriteLine(Session["UsuarioId"].ToString());
            if (Session["UsuarioId"] != null)
            {
                unidadReceptora.getInfoEncargado(Convert.ToInt32(Session["UsuarioId"]));
                lbsolPend.Text = unidadReceptora.getSolicitudesPendientes().ToString();
            }
            else
            {
                Literal ltr = new Literal();
                ltr.Text = @"<script type='text/javascript'> alert('No iniciaste sesión') </script>";
                this.Controls.Add(ltr);
                Response.Redirect("~/index.aspx");
            }
        }
    }
}