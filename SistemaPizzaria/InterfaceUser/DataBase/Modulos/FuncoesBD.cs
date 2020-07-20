using MySql.Data.MySqlClient;
using System;

namespace DataBase.Modulos
{
    class FuncoesBD
    {
        public int BuscaCodigo(string sql)
        {
            int Codigo =0;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();
                    comando.CommandText = sql;
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        Codigo = Convert.ToInt32(reader["Auto_increment"].ToString());
                    }

                }
                catch (MySqlException mysqle)
                {

                    throw new Exception(mysqle.ToString());
                }
                finally
                {
                    conexao.Close();
                }

            }
            return Codigo;

        }
    }
}
