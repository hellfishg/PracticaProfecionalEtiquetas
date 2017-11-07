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
        string ruta = "Data Source=FEDE-PC;Initial Catalog=ETIQUETAS;Integrated Security=True";
        //string ruta = "Data Source=localhost\\sqlexpress;Initial Catalog=ETIQUETAS;Integrated Security=True";
        //string ruta = "Data Source=localhost;Initial Catalog=ETIQUETAS;User id=sa;Password=123;Integrated Security=True";

///////////////////////////////////////////////////////////////////Funciones/////////////////////////////////////////////////////////////////////////
        public void MostrarDatosDocentes(GridView Docentes)
        {
            string consulta = "select IdDocente, NroDoc, TipoDoc, Legajo from Docentes WHERE Suspendido = 'False'";
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
            while (dr.Read())
            {
                idDocente.Text = dr[0].ToString();
                
            }
            if(idDocente.Text == "")
            {
                idDocente.Text = "1";
            }
            cn.Close();
        }

        public void CargarDDLNroDoc(DropDownList NroDoc, string Tipo)
        {
            string consulta = "SELECT NroDoc FROM PERSONAS WHERE (TipoDoc = '" + Tipo + "') AND (Suspendido = 'False')";
            SqlConnection cn = new SqlConnection(ruta);

            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            adaptador.Fill(ds, "PERSONAS");
            cn.Close();

            NroDoc.DataSource = ds;
            NroDoc.DataTextField = "NroDoc";
            NroDoc.DataBind();
        }

        public void CargarDDLCodCarrera(DropDownList CodCarrera)
        {
            string consulta = "SELECT CodigoCarrera FROM CARRERAS WHERE Suspendido = 'False'";
            SqlConnection cn = new SqlConnection(ruta);

            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            adaptador.Fill(ds, "CARRERAS");
            cn.Close();

            CodCarrera.DataSource = ds;
            CodCarrera.DataTextField = "CodigoCarrera";
            CodCarrera.DataBind();
        }

        public void CargarDDLCodMateria(DropDownList CodMateria, string CodCarrera)
        {
            string consulta = "SELECT CodigoMateria FROM MATERIAS WHERE (CodigoCarrera = '" + CodCarrera + "') AND (Suspendido = 'False')";
            SqlConnection cn = new SqlConnection(ruta);

            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            adaptador.Fill(ds, "MATERIAS");
            cn.Close();

            CodMateria.DataSource = ds;
            CodMateria.DataTextField = "CodigoMateria";
            CodMateria.DataBind();
        }
        public void CargarDDLCursada(DropDownList Cursada)
        {
            string consulta = "SELECT Cursada FROM CURSADAS WHERE Suspendido = 'False'";
            SqlConnection cn = new SqlConnection(ruta);

            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            adaptador.Fill(ds, "CURSADAS");
            cn.Close();

            Cursada.DataSource = ds;
            Cursada.DataTextField = "Cursada";
            Cursada.DataBind();
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
            string consulta = "select idDepartamento, Descripcion from DEPARTAMENTOS where Suspendido = 0";
            SqlConnection cn = new SqlConnection(ruta);
            cn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            Adaptador.Fill(ds, "DEPARTAMENTOS");
            Personas.DataSource = ds.Tables[0];
            Personas.DataBind();
            cn.Close();
        }

        public void MostrarDatosCarrerA(GridView cARRERA)
        {
            string consulta = "select CodigoCarrera, Descripcion from CARRERAS where Suspendido = 0";
            SqlConnection cn = new SqlConnection(ruta);
            cn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            Adaptador.Fill(ds, "CARRERAS");
            cARRERA.DataSource = ds.Tables[0];
            cARRERA.DataBind();
            cn.Close();
        }
        public void CargarDDLIdDocente(DropDownList IdDocente)
        {
            string consulta = "SELECT IdDocente FROM DOCENTES WHERE Suspendido = 'False'";
            SqlConnection cn = new SqlConnection(ruta);

            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            adaptador.Fill(ds, "DOCENTES");
            cn.Close();

            IdDocente.DataSource = ds;
            IdDocente.DataTextField = "IdDocente";
            IdDocente.DataBind();
        }
        public void CargarDDLCarrera(DropDownList IdDocente)
        {
            string consulta = "SELECT CodigoCarrera FROM CARRERAS WHERE Suspendido = 'False'";
            SqlConnection cn = new SqlConnection(ruta);

            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            adaptador.Fill(ds, "CARRERAS");
            cn.Close();

            IdDocente.DataSource = ds;
            IdDocente.DataTextField = "CodigoCarrera";
            IdDocente.DataBind();
        }

        public void CargarDDLIdDepartamento(DropDownList IdDepartamento)
        {
            string consulta = "SELECT IdDepartamento FROM DEPARTAMENTOS WHERE Suspendido = 'False'";
            SqlConnection cn = new SqlConnection(ruta);

            cn.Open();
            SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            adaptador.Fill(ds, "DEPARTAMENTOS");
            cn.Close();

            IdDepartamento.DataSource = ds;
            IdDepartamento.DataTextField = "IdDepartamento";
            IdDepartamento.DataBind();
        }
        public void MostrarDatosCursos(GridView Cursos)
        {
            string consulta = "select CodigoCarrera, CodigoMateria, Anio, Cursada, Turno, IdDocente, IdDepartamento, Curso from CURSOS WHERE Suspendido = 'False'";
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


        ////////////////////////////////////////////////////VALIDAR QUE NO HAYA REGISTROS IGUALES///////////////////////////////////////////////
        public bool ValidarClavePersonas(string a,string b)
        {
            SqlConnection cn = new SqlConnection(ruta);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT NroDoc, TipoDoc FROM PERSONAS";
            comando.Connection = cn;
            cn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                if (a == dr[0].ToString() && b == dr[1].ToString())
                {
                    cn.Close();
                    return true;
                }
            }
            cn.Close();
            return false;
        }
        
        public bool ValidarClaveDocentes(string a, string b, string c)
        {
            SqlConnection cn = new SqlConnection(ruta);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT NroDoc, TipoDoc, Legajo FROM DOCENTES";
            comando.Connection = cn;
            cn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                if ((a == dr[0].ToString() && b == dr[1].ToString()) || c == dr[2].ToString())
                {
                    cn.Close();
                    return true;
                }
            }
            cn.Close();
            return false;
        }

        public bool ValidarClaveCursos(string a, string b, string c, string d, string e, string f, string g)
        {
            SqlConnection cn = new SqlConnection(ruta);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT CodigoCarrera, CodigoMateria, Anio, Cursada, Turno, IdDocente, Curso  FROM CURSOS";
            comando.Connection = cn;
            cn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                if ((a == dr[0].ToString() && b == dr[1].ToString() && c == dr[2].ToString() && d == dr[3].ToString() && e == dr[4].ToString() && f == dr[5].ToString()) || g == dr[6].ToString())
                {
                    cn.Close();
                    return true;
                }
            }
            cn.Close();
            return false;
        }

        public bool ValidarClaveMateria(string a)
        {
            SqlConnection cn = new SqlConnection(ruta);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT CodigoMateria, CodigoCarrera FROM MATERIAS";
            comando.Connection = cn;
            cn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                if (a == dr[0].ToString())
                {
                    cn.Close();
                    return true;
                }
            }
            cn.Close();
            return false;
        }

        public bool ValidarClaveMatera(string a)
        {
            SqlConnection cn = new SqlConnection(ruta);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT CodigoCarrera FROM MATERIAS";
            comando.Connection = cn;
            cn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                if (a == dr[0].ToString())
                {
                    cn.Close();
                    return true;
                }
            }
            cn.Close();
            return false;
        }

        public bool ValidarClaveCarrera(string a)
        {
            SqlConnection cn = new SqlConnection(ruta);
            SqlCommand comando = new SqlCommand();
            comando.CommandText = "SELECT CodigoCarrera FROM CARRERAS";
            comando.Connection = cn;
            cn.Open();
            SqlDataReader dr = comando.ExecuteReader();
            while (dr.Read())
            {
                if (a == dr[0].ToString())
                {
                    cn.Close();
                    return true;
                }
            }
            cn.Close();
            return false;
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

       ///////////////////////////////////////CARRERAS ////////////////////////////////
        public void AgregarCarrera(string a, string b)
        {
            SqlCommand comando = new SqlCommand();
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@CodigoCarrera", SqlDbType.VarChar, 3);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50);
            parametros.Value = b;
            EjecutarProcedure(ruta, "SP_Ingresar_Carrera", comando);
        }
        public void ModificarCarrera(string a, string b)
        {
            SqlCommand comando = new SqlCommand();
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@CodigoCarrera", SqlDbType.VarChar, 3);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50);
            parametros.Value = b;

            EjecutarProcedure(ruta, "SP_Actualizar_Carrera", comando);
        }
        public void EliminarCarrera(string a)
        {
            SqlCommand comando = new SqlCommand();
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@CodigoCarrera", SqlDbType.VarChar, 3);
            parametros.Value = a;
            EjecutarProcedure(ruta, "SP_Suspender_Carrera", comando);
        }

        ///////////////////////////////////DEPARTAMENTOS/////////////////////////////////
        private void ParametrosModificarDepartamento(ref SqlCommand comando, int a, string b)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@IdDepartamento", SqlDbType.Int);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@Descripcion", SqlDbType.Char, 50);
            parametros.Value = b;

        }

        private void ParametrosSuspenderDepartamento(ref SqlCommand comando, int a)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@IdDepartamento", SqlDbType.Int);
            parametros.Value = a;

        }

        public void AgregarDepartamento(string a)
        {
            SqlCommand comando = new SqlCommand();
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@Descripcion", SqlDbType.VarChar, 50);
            parametros.Value = a;
            EjecutarProcedure(ruta, "SP_Ingresar_Departamento", comando);
        }

        public void ModificarDepartamento(int a, string b)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosModificarDepartamento(ref comando, a, b);
            EjecutarProcedure(ruta, "SP_Actualizar_Departamento", comando);
        }

        public void EliminarDepartamento(int a)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosSuspenderDepartamento(ref comando, a);
            EjecutarProcedure(ruta, "SP_Suspender_Departamento", comando);
        }
        public void MostrarDatosMaterias(GridView Materias)
        {
            string consulta = "select CodigoCarrera, CodigoMateria, Descripcion, TipoPlan, Cursada from Materias where Suspendido = 0";
            SqlConnection cn = new SqlConnection(ruta);
            cn.Open();
            SqlDataAdapter Adaptador = new SqlDataAdapter(consulta, cn);

            DataSet ds = new DataSet();
            Adaptador.Fill(ds, "MATERIAS");
            Materias.DataSource = ds.Tables[0];
            Materias.DataBind();
            cn.Close();
        }

        public void ModificarMateria(string a, string b, string c, string d, string e)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosModificarMateria(ref comando, a, b, c, d, e);
            EjecutarProcedure(ruta, "SP_Actualizar_Materia", comando);
        }

        public void EliminarMateria(string a, string b)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosSuspenderMateria(ref comando, a, b);
            EjecutarProcedure(ruta, "SP_Suspender_Materia", comando);
        }

        private void ParametrosModificarMateria(ref SqlCommand comando, string a, string b, string c, string d, string e)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@CodigoCarrera", SqlDbType.Char, 3);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@CodigoMateria", SqlDbType.Char, 3);
            parametros.Value = b;
            parametros = comando.Parameters.Add("@Descripcion", SqlDbType.Char, 50);
            parametros.Value = c;
            parametros = comando.Parameters.Add("@TipoPlan", SqlDbType.Char, 50);
            parametros.Value = d;
            parametros = comando.Parameters.Add("@Cursada", SqlDbType.Char, 20);
            parametros.Value = e;

        }

        private void ParametrosSuspenderMateria(ref SqlCommand comando, string a, string b)
        {
            SqlParameter parametros = new SqlParameter();
            parametros = comando.Parameters.Add("@CodigoCarrera", SqlDbType.Char, 3);
            parametros.Value = a;
            parametros = comando.Parameters.Add("@CodigoMateria", SqlDbType.Char, 3);
            parametros.Value = b;

        }

        public void AgregarMateria(string a, string b, string c, string d, string e)
        {
            SqlCommand comando = new SqlCommand();
            ParametrosModificarMateria(ref comando, a, b, c, d, e);
            EjecutarProcedure(ruta, "SP_Ingresar_Materia", comando);
        }


    }
}
