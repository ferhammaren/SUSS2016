using DataAccess;
using Proyecto_ISW.Clases;
using SUSS2016.DA;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUSS2016.CLASES
{
    public class unidadReceptora
    {
        public static Receptor rec;
        private static int ur;
        public unidadReceptora()
        {

        }
        public static void getInfoEncargado(int userID)
        {
            DataSet da;
            da = ENCARGADOSUR.SelectSingle(userID);
            rec = new Receptor(da.Tables[0].Rows[0]["nombre"].ToString(), da.Tables[0].Rows[0]["ap_paterno"].ToString(), da.Tables[0].Rows[0]["ap_materno"].ToString(), Convert.ToInt32(da.Tables[0].Rows[0]["idUR"]));
            ur = rec.idReceptor;

        }
        public static int getSolicitudesPendientes()
        {
            DataSet da;
            int pendientes = 0;
            da = SOLICITUDESPENDIENTESUR.SelectAll(ur);
            pendientes = da.Tables[0].Rows.Count;
            return pendientes;
        }

        public static DataSet getPendientes()
        {
            DataSet da;
            int pendientes = 0;
            da = SOLICITUDESPENDIENTESUR.SelectAll(ur);
            pendientes = da.Tables[0].Rows.Count;
            return da;
        }

        public static int getReportesPendientes()
        {
            DataSet da;
            int pendientes = 0;
            da = REPORTESPENDIENTESUR.SelectAll(ur);
            pendientes = da.Tables[0].Rows.Count;
            return pendientes;
        }

        public static int getAllPendientes()
        {
            DataSet da;
            int pendientes = 0;
            da = REPORTESPENDIENTESUR.SelectAll(ur);
            pendientes = da.Tables[0].Rows.Count;
            return pendientes;
        }

        public static void aceptarSolicitud(int idSol)
        {
            DataSet db;
            db = SOLICITUDESPENDIENTESUR.SelectBy(idSol);
            SOLICITUDESPENDIENTESUA.Insert(Convert.ToInt32(db.Tables[0].Rows[0]["matricula"]), Convert.ToInt32(db.Tables[0].Rows[0]["idPrograma"]), db.Tables[0].Rows[0]["horarioAlumno"].ToString(), db.Tables[0].Rows[0]["horarioPrestacion"].ToString(), Convert.ToDateTime(db.Tables[0].Rows[0]["fechaAsignacion"]), Convert.ToDateTime(db.Tables[0].Rows[0]["fechaConclusion"]));
            SOLICITUDESPENDIENTESUR.Delete(Convert.ToInt32(db.Tables[0].Rows[0]["matricula"]));
        }

        public static void aceptarReporte(int reporteId)
        {
            //change these parameters
            DataSet db;
            db = REPORTESPENDIENTESUR.SelectBy(reporteId);
    //        REPORTESPENDIENTESUA.Insert(Convert.ToInt32(db.Tables[0].Rows[0]["matricula"]), Convert.ToInt32(db.Tables[0].Rows[0]["idPrograma"]), db.Tables[0].Rows[0]["horarioAlumno"].ToString(), db.Tables[0].Rows[0]["horarioPrestacion"].ToString(), Convert.ToDateTime(db.Tables[0].Rows[0]["fechaAsignacion"]), Convert.ToDateTime(db.Tables[0].Rows[0]["fechaConclusion"]));
            REPORTESPENDIENTESUR.Delete(Convert.ToInt32(db.Tables[0].Rows[0]["matricula"]));
        }

    }
}
