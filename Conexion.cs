using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace Sistema_de_etiquetas
{
    public class Conexion
    {
        /*RUTA PARA LA BASE DE DATOS*/
        //string ruta = "Data Source=localhost\\sqlexpress;Initial Catalog=ETIQUETAS;Integrated Security=True";
        string ruta = "Data Source=FEDE-PC;Initial Catalog=ETIQUETAS;Integrated Security=True";
///////////////////////////////////////////////////////////////////Funciones/////////////////////////////////////////////////////////////////////////
        public void MostrarDatosDocentes(GridView Docentes)
        {
            string consulta = "select IdDocente, NroDoc, TipoDoc, Legajo from Docentes";
            SqlConnection cn = new SqlConnection(ruta);
            cn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            Adaptador.Fill(ds, "DOCENTES");
            Docentes.DataSource = ds.Tables[0];
            Docentes.DataBind();
            cn.Close();
        }

        public void IdDocenteSiguiente(TextBox idDocente)
        {
            SqlConnection cn = new SqlConnection(ruta);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "Select MAX(IdDocente)+1 from DOCENTES";
            comando.Connection = cn;

            cn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read() == true)
            {
                idDocente.Text = dr[0].ToString();

            }
            cn.Close();
        }

        public void MostrarDatosCursos(GridView Cursos)
        {
            string consulta = "select CodigoCarrera, CodigoMateria, Anio, Cursada, Turno, IdDocente, IdDepartamento, Curso from CURSOS";
            SqlConnection cn = new SqlConnection(ruta);
            cn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            Adaptador.Fill(ds, "CURSOS");
            Cursos.DataSource = ds.Tables[0];
            Cursos.DataBind();
            cn.Close();
        }

        public void CargarDDLturnos(DropDownList Turnos)
        {
            string consulta = "select Turno, CodHorario from TURNOS";
            SqlConnection cn = new SqlConnection(ruta);
         
            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            
            adaptador.Fill(ds, "TURNOS");

            cn.Close();
     
            Turnos.DataSource = ds;
            Turnos.DataTextField = "Turno";
            Turnos.DataValueField = "CodHorario";
         
            Turnos.DataBind();
        }

        public void CargarDDLcursadas(DropDownList Turnos)
        {
            string consulta = "select cursada from CURSADAS";
            SqlConnection cn = new SqlConnection(ruta);

            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();

            adaptador.Fill(ds, "CURSADAS");

            cn.Close();

            Turnos.DataSource = ds;
            Turnos.DataTextField = "cursada";

            Turnos.DataBind();
        }

        public void MostrarDatosPersonas(GridView Personas)
        {
            string consulta = "select NroDoc, TipoDoc, Apellido, Nombre, Provincia, Localidad, Direccion, Telefono, Celular, Email, Sexo, EstadoCivil, Nacionalidad from PERSONAS";
            SqlConnection cn = new SqlConnection(ruta);
            cn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            Adaptador.Fill(ds, "PERSONAS");
            Personas.DataSource = ds.Tables[0];
            Personas.DataBind();
            cn.Close();
        }

        public void MostrarDatosDepartamentos(GridView Personas)
        {
            string consulta = "select idDepartamento, Descripcion from DEPARTAMENTOS";
            SqlConnection cn = new SqlConnection(ruta);
            cn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            Adaptador.Fill(ds, "DEPARTAMENTOS");
            Personas.DataSource = ds.Tables[0];
            Personas.DataBind();
            cn.Close();
        }

        ///////////////////////////////////////////////////////PROCEDURES////////////////////////////////////////////////////////////////////////////////////
        private void EjecutarProcedure(string ruta1, string nombreP, SqlCommand comando)
        {

            SqlConnection Conexion = new SqlConnection(ruta1);
            Conexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd = comando;
            cmd.Connection = Conexion;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = nombreP;
            cmd.ExecuteReader();
            Conexion.Close();
        }
//////////////////////////////////////////////////////PROCEDURES DOCENTES////////////////////////////////////////////////////////////////////////////
        private void ParametrosAgregarDocente(ref SqlCommand comando, int a, string b, int c)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@NroDoc", SqlDbType.Int);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@TipoDoc", SqlDbType.VarChar, 20);
            parametros.Value = b;
            parametros = comando.Parameters.Add("@Legajo", SqlDbType.Int);
            parametros.Value = c;
        }

        private void ParametrosModificarDocente(ref SqlCommand comando, int a, int b, string c, int d)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@IdDocente", SqlDbType.Int);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@NroDoc", SqlDbType.Int);
            parametros.Value = b;
            parametros = comando.Parameters.Add("@TipoDoc", SqlDbType.VarChar, 20);
            parametros.Value = c;
            parametros = comando.Parameters.Add("@Legajo", SqlDbType.Int);
            parametros.Value = d;
        }

        private void ParametrosSuspenderDocente(ref SqlCommand comando, int a)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@IdDocente", SqlDbType.Int);
            parametros.Value = a;
        }

        public void AgregarDocente(int a, string b, int c)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosAgregarDocente(ref comando, a, b, c);
            EjecutarProcedure(ruta, "SP_Ingresar_Docente", comando);
        }

        public void ModificarDocente(int a, int b, string c, int d)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosModificarDocente(ref comando, a, b, c, d);
            EjecutarProcedure(ruta, "SP_Actualizar_Docente", comando);
        }

        public void EliminarDocente(int a)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosSuspenderDocente(ref comando, a);
            EjecutarProcedure(ruta, "SP_Suspender_Docente", comando);
        }
///////////////////////////////////////////////////////////////////////PROCEDURES CURSOS/////////////////////////////////////////////////////////////

        private void ParametrosAgregarCurso(ref SqlCommand comando, string a, string b, string c, string d, string e, int f, int g, string h)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@CodigoCarrera", SqlDbType.Char, 3);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@CodigoMateria", SqlDbType.Char, 3);
            parametros.Value = b;
            parametros = comando.Parameters.Add("@Anio", SqlDbType.Char, 4);
            parametros.Value = c;
            parametros = comando.Parameters.Add("@Cursada", SqlDbType.Char, 20);
            parametros.Value = d;
            parametros = comando.Parameters.Add("@Turno", SqlDbType.Char, 10);
            parametros.Value = e;
            parametros = comando.Parameters.Add("@IdDocente", SqlDbType.Int);
            parametros.Value = f;
            parametros = comando.Parameters.Add("@IdDepartamento", SqlDbType.Int);
            parametros.Value = g;
            parametros = comando.Parameters.Add("@Curso", SqlDbType.Char, 4);
            parametros.Value = h;
            
        }

        private void ParametrosModificarCurso(ref SqlCommand comando, string a, string b, string c, string d, string e, int f, int g, string h)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@CodigoCarrera", SqlDbType.Char, 3);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@CodigoMateria", SqlDbType.Char, 3);
            parametros.Value = b;
            parametros = comando.Parameters.Add("@Anio", SqlDbType.Char, 4);
            parametros.Value = c;
            parametros = comando.Parameters.Add("@Cursada", SqlDbType.Char, 20);
            parametros.Value = d;
            parametros = comando.Parameters.Add("@Turno", SqlDbType.Char, 10);
            parametros.Value = e;
            parametros = comando.Parameters.Add("@IdDocente", SqlDbType.Int);
            parametros.Value = f;
            parametros = comando.Parameters.Add("@IdDepartamento", SqlDbType.Int);
            parametros.Value = g;
            parametros = comando.Parameters.Add("@Curso", SqlDbType.Char, 4);
            parametros.Value = h;

        }

        private void ParametrosSuspenderCurso(ref SqlCommand comando, string a, string b, string c, string d, string e, int f)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@CodigoCarrera", SqlDbType.Char, 3);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@CodigoMateria", SqlDbType.Char, 3);
            parametros.Value = b;
            parametros = comando.Parameters.Add("@Anio", SqlDbType.Char, 4);
            parametros.Value = c;
            parametros = comando.Parameters.Add("@Cursada", SqlDbType.Char, 20);
            parametros.Value = d;
            parametros = comando.Parameters.Add("@Turno", SqlDbType.Char, 10);
            parametros.Value = e;
            parametros = comando.Parameters.Add("@IdDocente", SqlDbType.Int);
            parametros.Value = f;

        }

        public void AgregarCurso(string a, string b, string c, string d, string e, int f, int g, string h)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosAgregarCurso(ref comando, a, b, c, d, e, f, g, h);
            EjecutarProcedure(ruta, "SP_Ingresar_Curso", comando);
        }

        public void ModificarCurso(string a, string b, string c, string d, string e, int f, int g, string h)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosAgregarCurso(ref comando, a, b, c, d, e, f, g, h);
            EjecutarProcedure(ruta, "SP_Actualizar_Curso", comando);
        }

        public void EliminarCurso(string a, string b, string c, string d, string e, int f)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosSuspenderCurso(ref comando, a, b, c, d, e, f);
            EjecutarProcedure(ruta, "SP_Suspender_Curso", comando);
        }
///////////////////////////////////////////////////////////////////////PROCEDURES PERSONAS///////////////////////////////////////////////////////
        private void ParametrosAgregarPersona(ref SqlCommand comando, int a, string b, string c, string d, string e, string f, string g, int h, int i, string j, string k, string m, string n)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@NroDoc", SqlDbType.Int);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@TipoDoc", SqlDbType.VarChar, 20);
            parametros.Value = b;
            parametros = comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50);
            parametros.Value = c;
            parametros = comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
            parametros.Value = d;
            parametros = comando.Parameters.Add("@Provincia", SqlDbType.VarChar, 30);
            parametros.Value = e;
            parametros = comando.Parameters.Add("@Localidad", SqlDbType.VarChar, 30);
            parametros.Value = f;
            parametros = comando.Parameters.Add("@Direccion", SqlDbType.VarChar, 30);
            parametros.Value = g;
            parametros = comando.Parameters.Add("@Telefono", SqlDbType.Int);
            parametros.Value = h;
            parametros = comando.Parameters.Add("@Celular", SqlDbType.Int);
            parametros.Value = i;
            parametros = comando.Parameters.Add("@Email", SqlDbType.VarChar, 50);
            parametros.Value = j;
            parametros = comando.Parameters.Add("@Sexo", SqlDbType.Char, 1);
            parametros.Value = k;
            parametros = comando.Parameters.Add("@EstadoCivil", SqlDbType.VarChar, 20);
            parametros.Value = m;
            parametros = comando.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 50);
            parametros.Value = n;

        }

        private void ParametrosModificarPersona(ref SqlCommand comando, int a, string b, string c, string d, string e, string f, string g, int h, int i, string j, string k, string m, string n)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@NroDoc", SqlDbType.Int);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@TipoDoc", SqlDbType.VarChar, 20);
            parametros.Value = b;
            parametros = comando.Parameters.Add("@Apellido", SqlDbType.VarChar, 50);
            parametros.Value = c;
            parametros = comando.Parameters.Add("@Nombre", SqlDbType.VarChar, 50);
            parametros.Value = d;
            parametros = comando.Parameters.Add("@Provincia", SqlDbType.VarChar, 30);
            parametros.Value = e;
            parametros = comando.Parameters.Add("@Localidad", SqlDbType.VarChar, 30);
            parametros.Value = f;
            parametros = comando.Parameters.Add("@Direccion", SqlDbType.VarChar, 30);
            parametros.Value = g;
            parametros = comando.Parameters.Add("@Telefono", SqlDbType.Int);
            parametros.Value = h;
            parametros = comando.Parameters.Add("@Celular", SqlDbType.Int);
            parametros.Value = i;
            parametros = comando.Parameters.Add("@Email", SqlDbType.VarChar, 50);
            parametros.Value = j;
            parametros = comando.Parameters.Add("@Sexo", SqlDbType.Char, 1);
            parametros.Value = k;
            parametros = comando.Parameters.Add("@EstadoCivil", SqlDbType.VarChar, 20);
            parametros.Value = m;
            parametros = comando.Parameters.Add("@Nacionalidad", SqlDbType.VarChar, 50);
            parametros.Value = n;

        }

        private void ParametrosSuspenderPersona(ref SqlCommand comando, int a, string b)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@NroDoc", SqlDbType.Int);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@TipoDoc", SqlDbType.VarChar, 20);
            parametros.Value = b;
        }

        public void AgregarPersona(int a, string b, string c, string d, string e, string f, string g, int h, int i, string j, string k, string m, string n)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosAgregarPersona(ref comando, a, b, c, d, e, f, g, h, i, j, k, m, n);
            EjecutarProcedure(ruta, "SP_Ingresar_Persona", comando);
        }

        public void ModificarPersona(int a, string b, string c, string d, string e, string f, string g, int h, int i, string j, string k, string m, string n)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosModificarPersona(ref comando, a, b, c, d, e, f, g, h, i, j, k, m, n);
            EjecutarProcedure(ruta, "SP_Actualizar_Persona", comando);
        }

        public void EliminarPersona(int a, string b)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosSuspenderPersona(ref comando, a, b);
            EjecutarProcedure(ruta, "SP_Suspender_Persona", comando);
        }

        ///////////////////////////////////////////////////////////////////////PROCEDURES DEPARTAMENTOS///////////////////////////////////////////////////////
        public void AgregarDepartamento(string a)
        {
            SqlCommand comando = new SqlCommand();
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 20);
            parametros.Value = a;
            EjecutarProcedure(ruta, "SP_Ingresar_Departamento", comando);
        }







    }
}
