using SUSS2016.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SUSS2016
{
    public partial class urSolicitudesPendientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }


        protected void MyButtonClick(object sender, System.EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            int id = Convert.ToInt32(gvr.Cells[0].Text);
            unidadReceptora.aceptarSolicitud(id);
        }

    }
}