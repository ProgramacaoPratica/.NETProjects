using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Entities.Pessoas;
using System;
using Entities.Enumeradores;
using Entities.Entidades;
using DataBase.Modulos;

namespace DataBase.Pessoas
{
    public class UsuarioBD
    {
        private readonly FuncoesBD BdFuncoes = new FuncoesBD();

        public bool Inserir(Usuario oUsuario)
        {
            bool Isretorno = false;
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {

                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();



                    comando.CommandText = (@"INSERT INTO usuario  VALUES (@codigo_tipo_usuario, @nome, @login, @senha,@situacao, NOW(),@codigo_usr_alteracao)");


                    comando.Parameters.AddWithValue("codigo_tipo_usuario", oUsuario.TipoUsuario.Codigo);
                    comando.Parameters.AddWithValue("nome", oUsuario.Nome);
                    comando.Parameters.AddWithValue("login", oUsuario.Login);
                    comando.Parameters.AddWithValue("senha", oUsuario.Senha);
                    comando.Parameters.AddWithValue("situacao", (int)oUsuario.Status);
                    comando.Parameters.AddWithValue("codigo_usr_alteracao", oUsuario.CodigoUsrAlteracao);

                    int valorRetorno = comando.ExecuteNonQuery();

                    if (valorRetorno < 1)
                        Isretorno = false;
                    else
                        Isretorno = true;


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

            return Isretorno;
        }

        public List<EntidadeViewPesquisa> ListarEntidadesViewPesquisa(Status status)
        {

            var listaEntidades = new List<EntidadeViewPesquisa>();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {

                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();

                    string query = @"SELECT codigo, nome AS descricao, situacao
                                           FROM usuario";

                    if (status != Status.Todos)
                        query += " WHERE situacao = @situacao";

                    comando.CommandText = query;
                    if (status != Status.Todos)
                        comando.Parameters.AddWithValue("situacao", (int)status);

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

        public List<Usuario> ListarUsuariosAtivos()
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

        public Usuario Buscar(int cod)
        {
            Usuario oUsuario = new Usuario();
            using (MySqlConnection conexao = ConexaoBaseDados.getInstancia().getConexao())
            {
                try
                {
                    conexao.Open();
                    MySqlCommand comando = new MySqlCommand();
                    comando = conexao.CreateCommand();
                    comando.CommandText = "SELECT * FROM usuario where situacao = @codigo;";
                    comando.Parameters.AddWithValue("codigo", cod);
                    MySqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        oUsuario.Codigo = Convert.ToInt32(reader["codigo"]);
                        oUsuario.TipoUsuario = new TipoUsuario(Convert.ToInt32(reader["codigo_tipo_usuario"]), string.Empty);
                        oUsuario.Nome = reader["nome"].ToString();
                        oUsuario.Login = reader["login"].ToString();
                        oUsuario.Senha = reader["senha"].ToString();
                        oUsuario.Status = (Status)Convert.ToInt16(reader["situacao"]);
                        oUsuario.dtAlteracao = Convert.ToDateTime(reader["dt_alteracao"].ToString());
                        oUsuario.CodigoUsrAlteracao = Convert.ToInt32(reader["codigo_usr_alteracao"].ToString());
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
            return oUsuario;


        }

        public int BuscarProximoCodigo()
        {
            return BdFuncoes.BuscaCodigo("SHOW TABLE STATUS LIKE 'usuario'");
        }
    }
}






