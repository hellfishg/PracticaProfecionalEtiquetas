using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Materias
{
    public partial class AgregarMateria : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Conexion cn = new Conexion();
                cn.CargarDDLcursadas(ddlCursadas);
                cn.CargarDDLCarrera(ddlcarreras);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool aux=false;
            Conexion cn = new Conexion();

            if (txtCodigo.Text.ToString().Trim().Length > 3 || txtCodigo.Text.ToString().Trim().Length < 1)
            {
                Response.Write("<script>window.alert('El codigo debe ser de al menos 1 caracter y menos de 4');</script>");
                aux = true;}

            if (txtTipoPlan.Text.ToString().Trim() == "")
            {
                Response.Write("<script>window.alert('Ingrese tipo de plan');</script>");
            aux = true;}

            if (txtNombre.Text.ToString().Trim() == "")
            {   Response.Write("<script>window.alert('Ingrese Nombre de materia');</script>");
                aux = true;}

            if (cn.ValidarClaveMateria(txtCodigo.Text.ToString().Trim()) == true)
            {
                Response.Write("<script>window.alert('La clave está repetida');</script>");
                aux = true;}

            if (aux == false) cn.AgregarMateria(ddlcarreras.SelectedItem.Text, txtCodigo.Text, txtNombre.Text, txtTipoPlan.Text, ddlCursadas.SelectedItem.Text);
            Response.Write("<script>window.alert('Materia agregada con exito');</script>");
            
        }
    }
}