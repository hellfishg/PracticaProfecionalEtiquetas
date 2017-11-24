using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sistema_de_etiquetas.Etiquetas
{    
    /// <summary>
    /// //ESTA CLASE SIRVE SOLO PARA GENERAR LAS CONSULTAS DE TRAER
    //  *CARRERAS
    //  *MATERIAS
    //  *TURNOS
    //  *DOCENTES
    //  *ANIO
    /// </summary>

    public class clsServiciosEtiqueta
    {
        public List<clsCarrera> traerCarreras()
        {
            clsCapaDeAcceso dato = new clsCapaDeAcceso();
            var lista = new List<clsCarrera>();

            try
            {
                //EN ESTAS CONSULTA TRAE LAS CARRERAS QUE NO ESTÉN SUSPENDIDAS ORDENADAS ALFABETICAMENTE

                //CARGO LA CONSULTA
                dato.cargarComandoText("SELECT CARRERAS.CodigoCarrera,CARRERAS.Descripcion AS CARRERA FROM CARRERAS  where CARRERAS.Suspendido=0 ORDER BY CARRERAS.Descripcion ASC");
                dato.conectarse();//ME CONECTO
                dato.ejecutarQuery();//EJECUTA LA CONSULTA

                while (dato.Lector.Read())//MIENTRAS EL DATAREAD LEA, CARGO LA COLECCION
                {
                    var carrera = new clsCarrera();
                    carrera.IdCarrera = dato.Lector.GetString(0);
                    carrera.Carrera = dato.Lector.GetString(1);

                    lista.Add(carrera);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<clsMateria> traerMaterias(string idCarrera)
        {
            var dato = new clsCapaDeAcceso();
            var lista = new List<clsMateria>();

            try
            {   
                //EN ESTA  CONSULTA SE TRAE TODAS LAS MATERIAS QUE CORRESPONDEN A LA CARRERA QUE SE ENVIA POR PARAMETRO Y QUE NO ESTAN SUSPENDIDAS

                dato.cargarComandoText("SELECT M.CodigoMateria,M.Descripcion AS MATERIA FROM MATERIAS M INNER JOIN CARRERAS C ON C.CodigoCarrera=M.CodigoCarrera WHERE C.CodigoCarrera=@idCarrera and c.Suspendido=0 ORDER BY M.Descripcion ASC");

                //CREAMOS UN DICCIONARIO DE PARAMETROS PARA EVITAR TENER QUE CONCATENAR VALORES EN EL QUERY
                var dic = new Dictionary<string, string>();
                //EL PRIMER VALOR ES EL NOMBRE DEL PARAMETRO (SIN EL @) Y EL SEGUNDO ES EL VALOR DE DICHO PARAMETRO
                dic.Add("idCarrera", idCarrera);

                dato.cargarComandoParametros(dic);
                dato.conectarse();
                dato.ejecutarQuery();

                while (dato.Lector.Read())
                {
                    var materia = new clsMateria();

                    materia.IdMateria = dato.Lector.GetString(0);
                    materia.Materia = dato.Lector.GetString(1);

                    lista.Add(materia);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<clsTurno> cargarTurnos(string idCarrera, string idMateria)
        {
            var dato = new clsCapaDeAcceso();
            var lista = new List<clsTurno>();

            try
            {
                //ESTA CONSULTA TRAE LOS TURNOS, DEPENDIENDO LA CARRERA Y LA MATERIA QUE SE ENVIAN POR PARAMETRO, Y SI EL TURNO NO ESTÁ SUSPENDIDO

                dato.cargarComandoText("SELECT DISTINCT T.Turno FROM CURSOS CU INNER JOIN CARRERAS C ON CU.CodigoCarrera=C.CodigoCarrera INNER JOIN MATERIAS M ON CU.CodigoMateria=M.CodigoMateria INNER JOIN TURNOS T ON CU.Turno=T.Turno WHERE C.CodigoCarrera=@idCarrera AND M.CodigoMateria=@idMateria and T.Suspendido=0");

                //CREAMOS UN DICCIONARIO DE PARAMETROS PARA EVITAR TENER QUE CONCATENAR VALORES EN EL QUERY
                var dic = new Dictionary<string, string>();
                //EL PRIMER VALOR ES EL NOMBRE DEL PARAMETRO (SIN EL @) Y EL SEGUNDO ES EL VALOR DE DICHO PARAMETRO
                dic.Add("idCarrera", idCarrera);
                dic.Add("idMateria", idMateria);

                dato.cargarComandoParametros(dic);
                dato.conectarse();
                dato.ejecutarQuery();

                while (dato.Lector.Read())
                {
                    clsTurno turno = new clsTurno();

                    turno.Turno = dato.Lector.GetString(0);

                    lista.Add(turno);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<clsDocente> cargarDocentes(string idCarrera,string idMateria, string turno)
        {
            var dato = new clsCapaDeAcceso();
            var lista = new List<clsDocente>();

            try
            {
                //ESTA CONSULTA TRAE TODOS LOS DOCENTES NO SUSPENDIDOS QUE CORRESPONDEN A LA CARRERA, MATERIA Y TURNO QUE SE ENVIAN POR PARAMETRO

                dato.cargarComandoText("SELECT D.IdDocente,P.Apellido,P.Nombre FROM CURSOS CU INNER JOIN CARRERAS C ON CU.CodigoCarrera=C.CodigoCarrera INNER JOIN MATERIAS M ON CU.CodigoMateria=M.CodigoMateria INNER JOIN TURNOS T ON CU.Turno=T.Turno INNER JOIN DOCENTES D ON CU.IdDocente=D.IdDocente INNER JOIN PERSONAS P ON P.NroDoc=D.NroDoc WHERE C.CodigoCarrera=@idCarrera AND M.CodigoMateria=@idMateria AND T.Turno=@turno and D.Suspendido=0 order by P.Apellido asc");
                //CREAMOS UN DICCIONARIO DE PARAMETROS PARA EVITAR TENER QUE CONCATENAR VALORES EN EL QUERY
                var dic = new Dictionary<string, string>();
                
                //EL PRIMER VALOR ES EL NOMBRE DEL PARAMETRO (SIN EL @) Y EL SEGUNDO ES EL VALOR DE DICHO PARAMETRO
                dic.Add("idCarrera", idCarrera);
                dic.Add("idMateria", idMateria);
                dic.Add("turno", turno);

                dato.cargarComandoParametros(dic);
                dato.conectarse();
                dato.ejecutarQuery();

                while (dato.Lector.Read())
	            {
                    var docente = new clsDocente();

                    docente.IdDocente = dato.Lector.GetInt32(0);
                    docente.Apellido= dato.Lector.GetString(1) + ", "+ dato.Lector.GetString(2);// EN ESTE CASO CONCATENO APELLIDO Y NOMBRE PARA MOSTRARLO EN EL DROPDOWNLIST, POR SI SE CARGAN MAS DE UN DOCENTE CON EL MISMO APELLIDO, ASI DISTINGUIRLOS POR EL NOMBRE
                    
                    lista.Add(docente);
	            }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<string> cargarAnios(string idCarrera, string idMateria, string turno, int idDocente)
        {
            var lista = new List<string>();
            var dato = new clsCapaDeAcceso();

            try
            {
                //ESTA CONSULTA TRAE TODOS LOS ANIOS QUE CORRESPONDEN A LA CARRERA, MATERIA, TURNO Y DOCENTE QUE SE ENVIAN POR PARAMETRO
                dato.cargarComandoText("SELECT CU.Anio FROM CURSOS CU INNER JOIN CARRERAS C ON CU.CodigoCarrera=C.CodigoCarrera INNER JOIN MATERIAS M ON CU.CodigoMateria=M.CodigoMateria INNER JOIN TURNOS T ON CU.Turno=T.Turno INNER JOIN DOCENTES D ON CU.IdDocente=D.IdDocente INNER JOIN PERSONAS P ON P.NroDoc=D.NroDoc WHERE C.CodigoCarrera='"+idCarrera+"' AND M.CodigoMateria='"+idMateria+"' AND T.Turno='"+turno+"' AND D.IdDocente="+idDocente.ToString());
                dato.conectarse();
                dato.ejecutarQuery();

                while (dato.Lector.Read())
                {
                    string anio = " ";

                    anio = dato.Lector.GetString(0);

                    lista.Add(anio);
                }

                return lista;
            }
            catch (Exception ex)
            {                
                throw ex;
            }
        }
        public clsServiciosEtiqueta() { }
        ~clsServiciosEtiqueta() { }
    }
}