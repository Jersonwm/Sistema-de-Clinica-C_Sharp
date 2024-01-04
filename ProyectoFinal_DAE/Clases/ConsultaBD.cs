using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoFinal_DAE.Clases
{
    class ConsultaBD
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        string servidor = "Data source=.\\SQLEXPRESS;";
        string base_de_datos = "Initial Catalog=ClinicaMyM;";
        string usuario = "integrated security=true;";

        public ConsultaBD()
        {
            con.ConnectionString = servidor + base_de_datos + usuario;
        }

        public DataTable consulta(string sql)
        {
            DataTable mitabla = new DataTable();
            adapter = new SqlDataAdapter(sql, con);
            adapter.Fill(mitabla);
            return mitabla;
        }

        public bool ejecutarComando(string sql)
        {
            cmd.CommandText = sql;
            cmd.Connection = this.con;
            cmd.Connection.Open();
            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return true;
        }
    }
}
