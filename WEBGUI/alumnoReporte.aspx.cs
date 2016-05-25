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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void subirReporte_Click(object sender, EventArgs e)
        {
            string[] extensiones = { ".doc", ".docx", ".pdf" };
            if (elegirReporte.HasFile && (extensiones.Contains(Path.GetExtension(elegirReporte.PostedFile.FileName))))
            {
                try
                {
                    //string 
                  //  elegirReporte.SaveAs(Server.MapPath("~/") + filename);
                }catch(Exception ex)
                {
                   
                }
            }
        }
    }
}