using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SUSS2016.CLASES;

namespace WEBGUI
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            MainView.ActiveViewIndex = 0;
        }


        protected void Tab1_Click(object sender, EventArgs e)
        {
            tabAlumnos.CssClass = "Clicked";
            tabUA.CssClass = "Initial";
            tabUR.CssClass = "Initial";
            MainView.ActiveViewIndex = 0;
        }

        protected void Tab2_Click(object sender, EventArgs e)
        {
            tabAlumnos.CssClass = "Initial";
            tabUA.CssClass = "Clicked";
            tabUR.CssClass = "Initial";
            MainView.ActiveViewIndex = 1;
        }

        protected void Tab3_Click(object sender, EventArgs e)
        {
            tabAlumnos.CssClass = "Initial";
            tabUA.CssClass = "Initial";
            tabUR.CssClass = "Clicked";
            MainView.ActiveViewIndex = 2;
        }

        protected void tbAlLogin_Click(object sender, EventArgs e)
        {
            Literal ltr = new Literal();
            if (!Usuarios.autenticarUsuario(tbAlCorreo.Text, tbAlPass.Text, 3))
            { 
                //send not logged in message
                ltr.Text = @"<script type='text/javascript'> alert('Usuario o contraseña incorrectos') </script>";
            this.Controls.Add(ltr);
            }
            else
            {


                Session["UsuarioId"] = Usuarios.getUserNumber();
                Response.Redirect("~/alumnoMain.aspx" /*+ Usuarios.getUserNumber()*/);
            }
                
        }

        protected void btnUALogin_Click(object sender, EventArgs e)
        {
            Literal ltr = new Literal();
            if (!Usuarios.autenticarUsuario(tbAlCorreo.Text, tbAlPass.Text, 1))
            {
                //send not logged in message
                ltr.Text = @"<script type='text/javascript'> alert('Usuario o contraseña incorrectos') </script>";
                this.Controls.Add(ltr);
            }
            else
            {
                Session["UsuarioId"] = Usuarios.getUserNumber();
                Response.Redirect("~/uaMain.aspx");
            }
        }

        protected void tbURLogin_Click(object sender, EventArgs e)
        {
            Literal ltr = new Literal();
            if (!Usuarios.autenticarUsuario(tbAlCorreo.Text, tbAlPass.Text, 2))
            {
                //send not logged in message
                ltr.Text = @"<script type='text/javascript'> alert('Usuario o contraseña incorrectos') </script>";
                this.Controls.Add(ltr);
            }
            else
            {
                Session["UsuarioId"] = Usuarios.getUserNumber();
                Response.Redirect("~/urMain.aspx");
            }
        }
    }
}