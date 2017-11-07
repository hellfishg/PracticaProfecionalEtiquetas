using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Personas
{
    public partial class AdministrarPersonas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion cn = new Conexion();
                cn.MostrarDatosPersonas(grdAdministrarPersonas);
            }
        }

        protected void grdAdministrarPersonas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Conexion cn = new Conexion();

            grdAdministrarPersonas.EditIndex = e.NewEditIndex;

            cn.MostrarDatosPersonas(grdAdministrarPersonas);

            TextBox NroDoc = (TextBox)grdAdministrarPersonas.Rows[e.NewEditIndex].Cells[1].Controls[0];
            NroDoc.ReadOnly = true;
            TextBox TipoDoc = (TextBox)grdAdministrarPersonas.Rows[e.NewEditIndex].Cells[2].Controls[0];
            TipoDoc.ReadOnly = true;
        }

        protected void grdAdministrarPersonas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Conexion cn = new Conexion();
            GridViewRow fila = grdAdministrarPersonas.Rows[e.RowIndex];
            int NroDoc = Convert.ToInt32(((TextBox)(fila.Cells[1].Controls[0])).Text);
            string TipoDoc = ((TextBox)(fila.Cells[2].Controls[0])).Text;
            string Apellido = ((TextBox)(fila.Cells[3].Controls[0])).Text;
            string Nombre = ((TextBox)(fila.Cells[4].Controls[0])).Text;
            string Provincia = ((TextBox)(fila.Cells[5].Controls[0])).Text;
            string Localidad = ((TextBox)(fila.Cells[6].Controls[0])).Text;
            string Direccion = ((TextBox)(fila.Cells[7].Controls[0])).Text;
            int Telefono = Convert.ToInt32(((TextBox)(fila.Cells[8].Controls[0])).Text);
            int Celular = Convert.ToInt32(((TextBox)(fila.Cells[9].Controls[0])).Text);
            string Email = ((TextBox)(fila.Cells[10].Controls[0])).Text;
            string Sexo = ((TextBox)(fila.Cells[11].Controls[0])).Text;
            string EstadoCivil = ((TextBox)(fila.Cells[12].Controls[0])).Text;
            string Nacionalidad = ((TextBox)(fila.Cells[13].Controls[0])).Text;

            cn.ModificarPersona(NroDoc, TipoDoc, Apellido, Nombre, Provincia, Localidad, Direccion, Telefono, Celular, Email, Sexo, EstadoCivil, Nacionalidad);
            grdAdministrarPersonas.EditIndex = -1;
            cn.MostrarDatosPersonas(grdAdministrarPersonas);


        }

        protected void grdAdministrarPersonas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Conexion cn = new Conexion();
            grdAdministrarPersonas.EditIndex = -1;
            cn.MostrarDatosPersonas(grdAdministrarPersonas);
        }

        protected void grdAdministrarPersonas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Conexion cn = new Conexion();
            GridViewRow fila = grdAdministrarPersonas.Rows[e.RowIndex];
            int NroDoc = Convert.ToInt32(grdAdministrarPersonas.Rows[e.RowIndex].Cells[1].Text);
            string TipoDoc = grdAdministrarPersonas.Rows[e.RowIndex].Cells[2].Text;

            cn.EliminarPersona(NroDoc, TipoDoc);
            grdAdministrarPersonas.EditIndex = -1;
            cn.MostrarDatosPersonas(grdAdministrarPersonas);
        }

        protected void grdAdministrarPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
