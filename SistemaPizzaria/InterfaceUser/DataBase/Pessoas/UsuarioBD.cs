using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Entities.Pessoas;
using System;
using Entities.Enumeradores;

namespace DataBase.Pessoas {
    public class UsuarioBD {

        public List<Usuario> ListarUsuarios()
        {
            var listarUsuarios = new List<Usuario>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();
                    comando.CommandText = "SELECT * FROM usuario where situacao = 1;";
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oUsuario = new Usuario();
                        oUsuario.Codigo = Convert.ToInt32(reader["codigo"]);
                        oUsuario.TipoUsuario = new TipoUsuario(Convert.ToInt32(reader["codigo_tipo_usuario"]), string.Empty);
                        oUsuario.Nome = reader["nome"].ToString();
                        oUsuario.Login = reader["login"].ToString();
                        oUsuario.Senha = reader["senha"].ToString();
                        oUsuario.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oUsuario.dtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oUsuario.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());

                        listarUsuarios.Add(oUsuario);
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

            return listarUsuarios;
        }

    }
}
