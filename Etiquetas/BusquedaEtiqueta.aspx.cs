using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

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
                if (ddlCarrera.SelectedIndex != 0)
                {
                    ddlMaterias.Items.Clear();
                    ddlMaterias.Items.Add(" ");
                    ddlMaterias.DataSource = servicio.traerMaterias(idCarrera);
                    ddlMaterias.DataTextField = "Materia";
                    ddlMaterias.DataValueField = "IdMateria";
                    ddlMaterias.DataBind();

                    ddlTurnos.Items.Clear();
                    ddlDocentes.Items.Clear();
                    ddlAnio.Items.Clear();
                }
                else
                {
                    ddlMaterias.Items.Clear();
                    ddlTurnos.Items.Clear();
                    ddlDocentes.Items.Clear();
                    ddlAnio.Items.Clear();
                }
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
                if (ddlMaterias.SelectedIndex != 0)
                {
                    ddlTurnos.Items.Clear();
                    ddlTurnos.Items.Add(" ");
                    ddlTurnos.DataSource = servicio.cargarTurnos(idCarrera, idMateria);
                    ddlTurnos.DataTextField = "Turno";
                    ddlTurnos.DataValueField = "Turno";
                    ddlTurnos.DataBind();

                    ddlDocentes.Items.Clear();
                    ddlAnio.Items.Clear();
                }
                else
                {
                    ddlTurnos.Items.Clear();
                    ddlDocentes.Items.Clear();
                    ddlAnio.Items.Clear();
                }
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
                if (ddlTurnos.SelectedIndex != 0)
                {
                    ddlDocentes.Items.Clear();
                    ddlDocentes.Items.Add(" ");
                    ddlDocentes.DataSource = servicio.cargarDocentes(idCarrera, idMateria, turno);
                    ddlDocentes.DataTextField = "Apellido";
                    ddlDocentes.DataValueField = "IdDocente";
                    ddlDocentes.DataBind();

                    ddlAnio.Items.Clear();
                }
                else
                {
                    ddlDocentes.Items.Clear();
                    ddlAnio.Items.Clear();
                }
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
                if (ddlDocentes.SelectedIndex != 0)
                {
                    ddlAnio.Items.Clear();
                    ddlAnio.Items.Add(" ");
                    ddlAnio.DataSource = servicio.cargarAnios(idCarrera, idMateria, turno, idDocente);
                    ddlAnio.DataBind();
                }
                else
                {
                    ddlAnio.Items.Clear();
                }
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
            cargarAnios(ddlCarrera.SelectedItem.Value.ToString(), ddlMaterias.SelectedItem.Value.ToString(), ddlTurnos.SelectedItem.Value.ToString(), Convert.ToInt32(ddlDocentes.SelectedItem.Value));
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ddlAnio.SelectedIndex != 0)
            {
                generarEtiqueta("Carrera: " + ddlCarrera.SelectedItem.Text);
                generarEtiqueta("Materia: " + ddlMaterias.SelectedItem.Text);
                generarEtiqueta("Turno: " + ddlTurnos.SelectedItem.Text);
                generarEtiqueta("Docente: " + ddlDocentes.SelectedItem.Text);
                generarEtiqueta("Año: " + ddlAnio.SelectedItem.Text);
            }
            else
                Response.Write("<script>window.alert('Debe ingresar todos los datos');</script>");
        }

        public static void generarEtiqueta(string stMensaje)
        {
            StreamWriter swFile = default(StreamWriter);
            string stFile = null;
            string stPathEtiqueta = "\\etiqueta.txt";

            try
            {
                if (stPathEtiqueta.Length > 0)
                {
                    stFile = System.Web.HttpContext.Current.Server.MapPath(".") + stPathEtiqueta;
                    swFile = new StreamWriter(stFile, true);
                    swFile.Write(stMensaje + Environment.NewLine);
                    swFile.Close();
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}