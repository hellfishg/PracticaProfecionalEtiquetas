using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sistema_de_etiquetas.Etiquetas
{
    public partial class BusquedaEtiqueta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if ((string)this.Session["TipoUsuario"] == "No" || this.Session["TipoUsuario"] == null)
            {
                this.Session["ErrorTipoUsuario"] = "Si";
                Response.Redirect("~/Default.aspx");
            }
            else
            {
                if (!IsPostBack)
                {
                    cargarCarreras();
                }
            }
        }

        void cargarCarreras()
        {
            var servicio = new clsServiciosEtiqueta();
            try
            {
                ddlCarrera.DataSource = servicio.traerCarreras();
                ddlCarrera.DataTextField = "Carrera";
                ddlCarrera.DataValueField = "IdCarrera";
                ddlCarrera.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void cargarMaterias(string idCarrera)
        {
            clsServiciosEtiqueta servicio = new clsServiciosEtiqueta();
            try
            {
                ddlMaterias.DataSource = servicio.traerMaterias(idCarrera);
                ddlMaterias.DataTextField = "Materia";
                ddlMaterias.DataValueField = "IdMateria";
                ddlMaterias.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void cargarTurnos(string idCarrera, string idMateria)
        {
            var servicio = new clsServiciosEtiqueta();

            try
            {
                ddlTurnos.DataSource = servicio.cargarTurnos(idCarrera, idMateria);
                ddlTurnos.DataTextField = "Turno";
                ddlTurnos.DataValueField = "Turno";
                ddlTurnos.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void cargarDocentes(string idCarrera, string idMateria, string turno)
        {
            var servicio = new clsServiciosEtiqueta();

            try
            {
                ddlDocentes.DataSource = servicio.cargarDocentes(idCarrera, idMateria, turno);
                ddlDocentes.DataTextField = "Apellido";
                ddlDocentes.DataValueField = "IdDocente";
                ddlDocentes.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void cargarAnios(string idCarrera, string idMateria, string turno, int idDocente)
        {
            var servicio = new clsServiciosEtiqueta();

            try
            {
                ddlAnio.DataSource = servicio.cargarAnios(idCarrera, idMateria, turno, idDocente);
                ddlAnio.DataBind();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected void ddlTurnos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarDocentes(ddlCarrera.SelectedItem.Value.ToString(), ddlMaterias.SelectedItem.Value.ToString(), ddlTurnos.SelectedItem.Value.ToString());
        }

        protected void ddlMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarTurnos(ddlCarrera.SelectedItem.Value.ToString(), ddlMaterias.SelectedItem.Value.ToString());
        }

        protected void ddlCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarMaterias(ddlCarrera.SelectedItem.Value.ToString());
        }

        protected void ddlDocentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarAnios(ddlCarrera.SelectedItem.Value.ToString(), ddlCarrera.SelectedItem.Value.ToString(), ddlTurnos.SelectedItem.Value.ToString(), Convert.ToInt32(ddlDocentes.SelectedItem.Value));
        }

    }
}