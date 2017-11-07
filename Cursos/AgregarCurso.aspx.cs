using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Cursos
{
    public partial class AgregarCurso : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            if (!IsPostBack)
            {
                cn.CargarDDLCodCarrera(CodCarrera);
                cn.CargarDDLturnos(ddlTurnos);
                cn.CargarDDLIdDocente(IdDocente);
                cn.CargarDDLCursada(Cursada);
                cn.CargarDDLIdDepartamento(IdDepartamento);
            }
            if (CodCarrera.SelectedItem != null) 
            cn.CargarDDLCodMateria(CodMateria, CodCarrera.SelectedItem.Text);
        }

        protected void AgregarCur_Click(object sender, EventArgs e)
        {
            ///pregunta si los controles de validacion no tiran error y tambien si se ingreso la misma clave o codigo de curso que hay en BD
            Conexion cn = new Conexion();
            if(Page.IsValid && cn.ValidarClaveCursos(CodCarrera.SelectedItem.Text, CodMateria.SelectedItem.Text, Anio.Text, Cursada.SelectedItem.Text, ddlTurnos.SelectedItem.Text, IdDocente.SelectedItem.Text, CodCurso.Text) == false)
            {
                cn.AgregarCurso(CodCarrera.SelectedItem.Text, CodMateria.SelectedItem.Text, Anio.Text, Cursada.SelectedItem.Text, ddlTurnos.SelectedItem.Text, Convert.ToInt32(IdDocente.SelectedItem.Text.ToString()), Convert.ToInt32(IdDepartamento.SelectedItem.Text.ToString()), CodCurso.Text);
                Response.Redirect("VerDatosCurso.aspx");
            }
            else
            {
                Response.Write("<script>window.alert('Curso ya existente');</script>");
            }


        }
            
        
   }
}
