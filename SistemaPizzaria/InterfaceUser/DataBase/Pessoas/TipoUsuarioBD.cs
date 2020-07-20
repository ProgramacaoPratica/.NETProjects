using Entities.Entidades;
using Entities.Enumeradores;
using Entities.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace DataBase.Pessoas
{
    public class TipoUsuarioBD
    {

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa()
        {
            var listaEntidades = new List<EntidadeViewPesquisa>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    string query = @"SELECT codigo, descricao, '1' AS situacao
                                           FROM tipo_usuario";
                    comando.CommandText = query;
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var oEntidade = new EntidadeViewPesquisa();
                        oEntidade.Codigo = Convert.ToInt32(reader["codigo"].ToString());
                        oEntidade.Descricao = reader["descricao"].ToString();
                        oEntidade.Status = (Status)Convert.ToInt16(reader["situacao"]);

                        listaEntidades.Add(oEntidade);
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

            return listaEntidades;
        }



        public TipoUsuario BuscarTipoUsuariodoUsuario(int codigo)
        {
            TipoUsuario tipousuario = new TipoUsuario();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();
                    comando.CommandText = @"SELECT
                                          U.codigo_tipo_usuario as CodigoTipoUsuario,
                                          TU.descricao as DescricaoTipoUsuario
                                          FROM usuario as U
                                          INNER JOIN tipo_usuario as TU
                                          ON U.codigo_tipo_usuario = TU.codigo
                                          where U.codigo = @codigo";

                    comando.Parameters.AddWithValue("codigo", codigo);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        tipousuario.Codigo = Convert.ToInt32(reader["CodigoTipoUsuario"].ToString());
                        tipousuario.Descricao = reader["DescricaoTipoUsuario"].ToString();
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

            return tipousuario;
        }

        public TipoUsuario Buscar(int codigo)
        {
            TipoUsuario tipousuario = new TipoUsuario();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();
                    comando.CommandText = @"SELECT * FROM tipo_usuario WHERE codigo = @codigo";
                    comando.Parameters.AddWithValue("codigo", codigo);

                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        tipousuario.Codigo = Convert.ToInt32(reader["Codigo"].ToString());
                        tipousuario.Descricao = reader["Descricao"].ToString();
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

            return tipousuario;
        }
    }
}
