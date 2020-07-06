using MySql.Data.MySqlClient;
using System.Configuration;


namespace DataBase {
    class ConexaoBaseDados    
    {
        private static readonly ConexaoBaseDados instanciaMySql = new ConexaoBaseDados();

        public static ConexaoBaseDados getInstancia()
        {
            return instanciaMySql;
        }

       public MySqlConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["connStr"].ToString();
            return new MySqlConnection(conn);
        }
    }
}
