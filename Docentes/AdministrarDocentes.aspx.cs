using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_de_etiquetas.Docentes
{
    public partial class AdministrarDocentes : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion cn = new Conexion();
                cn.MostrarDatosDocentes(grdAdministrarDocentes);
            }
        }


        protected void grdAdministrarDocentes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Conexion cn = new Conexion();

            grdAdministrarDocentes.EditIndex = e.NewEditIndex;

            cn.MostrarDatosDocentes(grdAdministrarDocentes);

            TextBox IdDocente = (TextBox)grdAdministrarDocentes.Rows[e.NewEditIndex].Cells[1].Controls[0];
            IdDocente.ReadOnly = true;
            TextBox NroDoc = (TextBox)grdAdministrarDocentes.Rows[e.NewEditIndex].Cells[2].Controls[0];
            NroDoc.ReadOnly = true;
            TextBox TipoDoc = (TextBox)grdAdministrarDocentes.Rows[e.NewEditIndex].Cells[3].Controls[0];
            TipoDoc.ReadOnly = true;

        }



        protected void grdAdministrarDocentes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Conexion cn = new Conexion();
            GridViewRow fila = grdAdministrarDocentes.Rows[e.RowIndex];
            int id = Convert.ToInt32(((TextBox)(fila.Cells[1].Controls[0])).Text);
            int NroDoc = Convert.ToInt32(((TextBox)(fila.Cells[2].Controls[0])).Text);
            string TipoDoc = ((TextBox)(fila.Cells[3].Controls[0])).Text;
            int Legajo = Convert.ToInt32(((TextBox)(fila.Cells[4].Controls[0])).Text);
    

            cn.ModificarDocente(id, NroDoc, TipoDoc, Legajo);
            grdAdministrarDocentes.EditIndex = -1;
            cn.MostrarDatosDocentes(grdAdministrarDocentes);

           
        }

        protected void grdAdministrarDocentes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Conexion cn = new Conexion();
            grdAdministrarDocentes.EditIndex = -1;
            cn.MostrarDatosDocentes(grdAdministrarDocentes);
        }

        protected void grdAdministrarDocentes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Conexion cn = new Conexion();
            GridViewRow fila = grdAdministrarDocentes.Rows[e.RowIndex];
            int id = Convert.ToInt32(grdAdministrarDocentes.Rows[e.RowIndex].Cells[1].Text);
            cn.EliminarDocente(id);
            grdAdministrarDocentes.EditIndex = -1;
            cn.MostrarDatosDocentes(grdAdministrarDocentes);
        }

        protected void grdAdministrarDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
  

    }

}
