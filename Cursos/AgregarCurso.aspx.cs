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
            if (!IsPostBack)
            {
                Conexion cn = new Conexion();
                cn.CargarDDLturnos(ddlTurnos);
            }
        }

        protected void AgregarCur_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.AgregarCurso(CodCarrera.Text, CodMateria.Text, Anio.Text, Cursada.Text, ddlTurnos.SelectedItem.Text, Convert.ToInt32(IdDocente.Text.ToString()), Convert.ToInt32(IdDepartamento.Text.ToString()), CodCurso.Text);}

        }
    }
