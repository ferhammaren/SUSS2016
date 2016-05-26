using SUSS2016.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SUSS2016
{
    public partial class urReportesPendientes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

       protected void aprobar_Reporte(object sender, EventArgs e)
        {
            //Get the button that raised the event
            Button btn = (Button)sender;

            //Get the row that contains this button
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            int id = Convert.ToInt32(gvr.Cells[0].Text);
            unidadReceptora.aceptarSolicitud(id);
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //do magic
        }
    }
}