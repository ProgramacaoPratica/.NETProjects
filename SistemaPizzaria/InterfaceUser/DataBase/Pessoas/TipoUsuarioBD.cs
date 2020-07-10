﻿using Entities.Pessoas;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Pessoas {
    public class TipoUsuarioBD {

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

    }
}