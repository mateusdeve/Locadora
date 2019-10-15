using Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller
{
    public class FilmesController
    {
        public List<Filmes> Listar()
        {
            string strConexao = "SERVER=localhost; DataBase=Locadora; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = "SELECT ID, TITULO, DURACAO, ANO, CLASSIFICACAO_ID, PRODUTORA_ID FROM FILMES";

                    cmd.Connection = conn;
                    cmd.CommandText = query;

                    using (MySqlDataAdapter da = new MySqlDataAdapter())
                    {
                        da.SelectCommand = cmd;
                        DataSet ds = new DataSet();

                        da.Fill(ds, "Filmes");

                        List<Filmes> lstRetorno = ds.Tables["Filmes"].AsEnumerable().Select(
                            x => new Filmes()
                            {
                                id                  =   x.Field<int>("id"),
                                titulo              =   x.Field<string>("titulo"),
                                duracao             =   x.Field<DateTime>("duracao"),
                                ano                 =   x.Field<int>("ano"),
                                classificacao_id    =   x.Field<int>("classificacao_id"),
                                produtora_id        =   x.Field<int>("produtora_id"),
                            }
                        ).ToList();

                        return lstRetorno;
                    }
                }

            }
        }
        public Filmes buscar(int id)
        {
            string strConexao = "SERVER=localhost; DataBase=Locadora; UID=root; pwd=";

            using (MySqlConnection conn = new MySqlConnection(strConexao))
            {
                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand())
                {
                    string query = $"SELECT ID, TITULO, DURACAO, ANO, CLASSIFICACAO_ID, PRODUTORA_ID FROM FILMES WHERE ID  =   {id}";

                    cmd.Connection  = conn;
                    cmd.CommandText = query;

                    MySqlDataReader reader = cmd.ExecuteReader();

                    Filmes retorno  =    new Filmes();

                    while (reader.Read())
                    {
                        retorno.id = (int)reader["id"];
                        retorno.titulo = (string)reader["titulo"];
                        retorno.ano = (int)reader["ano"];
                        retorno.classificacao_id = (int)reader["classificacao_id"];
                        retorno.produtora_id = (int)reader["produtora_id"];

                    }

                    return retorno;

                }
            }
        }
    }
}
