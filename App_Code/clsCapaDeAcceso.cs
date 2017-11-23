using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

public class clsCapaDeAcceso
{
    //EN ESTA CADENA LO UNICO QUE HAY QUE HACER ES CAMBIA EL "DATA SOURCE" CON EL NOMBRE DE LA CONEXION LOCAL
    string rutaBD = "Data Source=localhost; Initial Catalog=ETIQUETAS;Integrated Security=True";
    public clsCapaDeAcceso()
    {
        this.Conexion = new SqlConnection();
        this.Comando = new SqlCommand();
        this.seteador = new DataSet();
    }

    public SqlConnection Conexion { set; get; }
    public SqlCommand Comando { set; get; }
    public SqlDataReader Lector { set; get; }
    public DataSet seteador { set; get; }
    public SqlDataAdapter adaptador { set; get; }

    public SqlDataAdapter obtenerAdaptador(string consultaSQL)
    {
        try
        {
            adaptador = new SqlDataAdapter(consultaSQL, rutaBD);
            return adaptador;
        }
        catch (Exception)
        {
            return null;
        }
    }


    public void cargarComandoText(string consulta)
    {
        this.Comando.CommandType = System.Data.CommandType.Text;
        this.Comando.CommandText = consulta;
        this.Comando.Connection = this.Conexion;
    }

    public void cargarComandoParametros(Dictionary<string, string> dic)
    {
        foreach(var itm in dic)
        {
            this.Comando.Parameters.AddWithValue("@" + itm.Key, itm.Value);
        }
    }

    public void cargarComandoSP(string comandoSP)
    {
        this.Comando.CommandType = System.Data.CommandType.StoredProcedure;
        this.Comando.CommandText = comandoSP;
        this.Comando.Connection = this.Conexion;
    }

    public void ejecutarQuery()
    {
        this.Lector = this.Comando.ExecuteReader();
    }

    public void ejecutarNonQuery()
    {
        this.Comando.ExecuteNonQuery();
    }

    public void conectarse()
    {
        this.Conexion.ConnectionString = rutaBD;
        this.Conexion.Open();
    }

    public void desconectarse()
    {
        this.Conexion.Close();
        this.Comando.Dispose();
        this.Conexion.Dispose();
    }

    ~clsCapaDeAcceso() { }

}