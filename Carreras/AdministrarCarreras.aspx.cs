using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Carreras
{
    public partial class AdministrarCarreras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion cn = new Conexion();
                cn.MostrarDatosCarrerA(GridView1);
            }
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            Conexion cn = new Conexion();
            cn.MostrarDatosCarrerA(GridView1);


        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Conexion cn = new Conexion();
            string cod = ((Label)GridView1.Rows[e.RowIndex].FindControl("label1")).Text;
            string desc = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2")).Text;

            if (desc.Trim() == "")
            {
                Response.Write("<script>window.alert('La carrera debe tener nombre');</script>");
                GridView1.EditIndex = -1;
            }
            else
            {
                cn.ModificarCarrera(cod, desc);
                GridView1.EditIndex = -1;
                cn.MostrarDatosCarrerA(GridView1);
            }
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            Conexion cn = new Conexion();
            GridView1.EditIndex = -1;
            cn.MostrarDatosCarrerA(GridView1);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Conexion cn = new Conexion();
            string cod = ((Label)GridView1.Rows[e.RowIndex].FindControl("label1")).Text;
            cn.EliminarCarrera(cod);
            GridView1.EditIndex = -1;
            cn.MostrarDatosCarrerA(GridView1);

        }













    }
}