using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Materias
{
    public partial class AdministrarMaterias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion cn = new Conexion();
                cn.MostrarDatosMaterias(GridView1);
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Conexion cn = new Conexion();

            GridView1.EditIndex = e.NewEditIndex;

            cn.MostrarDatosMaterias(GridView1);

            TextBox CodigoCarrera = (TextBox)GridView1.Rows[e.NewEditIndex].Cells[1].Controls[0];
            CodigoCarrera.ReadOnly = true;
            TextBox CodigoMateria = (TextBox)GridView1.Rows[e.NewEditIndex].Cells[2].Controls[0];
            CodigoMateria.ReadOnly = true;
            TextBox Descripcion = (TextBox)GridView1.Rows[e.NewEditIndex].Cells[3].Controls[0];
            Descripcion.ReadOnly = false;
            TextBox TipoPlan = (TextBox)GridView1.Rows[e.NewEditIndex].Cells[4].Controls[0];
            TipoPlan.ReadOnly = false;
            TextBox Cursada = (TextBox)GridView1.Rows[e.NewEditIndex].Cells[5].Controls[0];
            Cursada.ReadOnly = false;
        }

       
       

        

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
            Conexion cn = new Conexion();
            GridViewRow fila = GridView1.Rows[e.RowIndex];
            string Carrera = GridView1.Rows[e.RowIndex].Cells[1].Text;
            string Materia = GridView1.Rows[e.RowIndex].Cells[2].Text;

            cn.EliminarMateria(Carrera, Materia);
            GridView1.EditIndex = -1;
            cn.MostrarDatosDepartamentos(GridView1);
            GridView1.DataBind();
        }

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            Conexion cn = new Conexion();
            GridView1.EditIndex = -1;
            cn.MostrarDatosDepartamentos(GridView1);
        }

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {
            Conexion cn = new Conexion();
            GridViewRow fila = GridView1.Rows[e.RowIndex];

            string CodigoCarrera = ((TextBox)(fila.Cells[1].Controls[0])).Text;
            string CodigoMateria = ((TextBox)(fila.Cells[2].Controls[0])).Text;
            string Descripcion = ((TextBox)(fila.Cells[3].Controls[0])).Text;
            string TipoPlan = ((TextBox)(fila.Cells[4].Controls[0])).Text;
            string Cursada = ((TextBox)(fila.Cells[5].Controls[0])).Text;


            cn.ModificarMateria(CodigoCarrera, CodigoMateria, Descripcion, TipoPlan, Cursada);
            GridView1.EditIndex = -1;
            cn.MostrarDatosDepartamentos(GridView1);
            GridView1.DataBind();
        }
    }
}