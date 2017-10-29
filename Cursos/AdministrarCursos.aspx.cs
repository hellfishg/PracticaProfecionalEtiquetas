using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Cursos
{
    public partial class AdministrarCursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion cn = new Conexion();
                cn.MostrarDatosCursos(grdAdministrarCursos);
            }
        }

        protected void grdAdministrarCursos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Conexion cn = new Conexion();

            grdAdministrarCursos.EditIndex = e.NewEditIndex;

            cn.MostrarDatosCursos(grdAdministrarCursos);

            TextBox CodCarrera = (TextBox)grdAdministrarCursos.Rows[e.NewEditIndex].Cells[1].Controls[0];
            CodCarrera.ReadOnly = true;
            TextBox CodMateria = (TextBox)grdAdministrarCursos.Rows[e.NewEditIndex].Cells[2].Controls[0];
            CodMateria.ReadOnly = true;
            TextBox Anio = (TextBox)grdAdministrarCursos.Rows[e.NewEditIndex].Cells[3].Controls[0];
            Anio.ReadOnly = true;
            TextBox Cursada = (TextBox)grdAdministrarCursos.Rows[e.NewEditIndex].Cells[4].Controls[0];
            Cursada.ReadOnly = true;
            TextBox Turno = (TextBox)grdAdministrarCursos.Rows[e.NewEditIndex].Cells[5].Controls[0];
            Turno.ReadOnly = true;
            TextBox IdDocente = (TextBox)grdAdministrarCursos.Rows[e.NewEditIndex].Cells[6].Controls[0];
            IdDocente.ReadOnly = true;
        }




        protected void grdAdministrarCursos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Conexion cn = new Conexion();
            GridViewRow fila = grdAdministrarCursos.Rows[e.RowIndex];
            string CodCarrera = ((TextBox)(fila.Cells[1].Controls[0])).Text;
            string CodMateria = ((TextBox)(fila.Cells[2].Controls[0])).Text;
            string Anio = ((TextBox)(fila.Cells[3].Controls[0])).Text;
            string Cursada = ((TextBox)(fila.Cells[4].Controls[0])).Text;
            string Turno = ((TextBox)(fila.Cells[5].Controls[0])).Text;
            int IdDocente = Convert.ToInt32(((TextBox)(fila.Cells[6].Controls[0])).Text);
            int IdDepartamento = Convert.ToInt32(((TextBox)(fila.Cells[7].Controls[0])).Text);
            string CodCurso = ((TextBox)(fila.Cells[8].Controls[0])).Text;


            cn.ModificarCurso(CodCarrera, CodMateria, Anio, Cursada, Turno, IdDocente, IdDepartamento, CodCurso);
            grdAdministrarCursos.EditIndex = -1;
            cn.MostrarDatosCursos(grdAdministrarCursos);


        }

        protected void grdAdministrarCursos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Conexion cn = new Conexion();
            grdAdministrarCursos.EditIndex = -1;
            cn.MostrarDatosCursos(grdAdministrarCursos);
        }

        protected void grdAdministrarCursos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Conexion cn = new Conexion();
            GridViewRow fila = grdAdministrarCursos.Rows[e.RowIndex];
            string CodCarrera = grdAdministrarCursos.Rows[e.RowIndex].Cells[1].Text;
            string CodMateria = grdAdministrarCursos.Rows[e.RowIndex].Cells[2].Text;
            string Anio = grdAdministrarCursos.Rows[e.RowIndex].Cells[3].Text;
            string Cursada = grdAdministrarCursos.Rows[e.RowIndex].Cells[4].Text;
            string Turno = grdAdministrarCursos.Rows[e.RowIndex].Cells[5].Text;
            int IdDocente = Convert.ToInt32(grdAdministrarCursos.Rows[e.RowIndex].Cells[6].Text);

            cn.EliminarCurso(CodCarrera, CodMateria, Anio, Cursada, Turno, IdDocente);
            grdAdministrarCursos.EditIndex = -1;
            cn.MostrarDatosCursos(grdAdministrarCursos);
        }
    }
}
