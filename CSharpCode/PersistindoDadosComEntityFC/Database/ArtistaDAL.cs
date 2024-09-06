using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PersistindoDadosComEntityFC.Database
{

    class ArtistaDAL
    {
        private readonly Connection con;

        public ArtistaDAL()
        {
            con = new Connection();
        }
        public IEnumerable<Artista> ListarArtista()
        {
            return con.Artists.ToList();
        } 
        /*
            if (artista!= null)
            {
                using var connection = new Connection().ObterConexao();
                connection.Open();

                string sql = "UPDATE Artistas SET Nome = @nome, Bio = @bio Where id = @id";
                using SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@nome", artista.Nome);
                command.Parameters.AddWithValue("@bio", artista.Bio);
                command.Parameters.AddWithValue("@id", artista.Id);

                if (command.ExecuteNonQuery() != 0)
                {
                    Console.WriteLine("Linhas afetadas pelo UPDATE : ", command.ExecuteNonQuery());
                }
                else
                {
                    Console.WriteLine("O Id ", artista.Id, "Nao foi encontrado no registro de artistas");
                }
                
            }
            else
            {
                Console.WriteLine("Objeto Nulo - > Artista nao cadastrado");
                throw new ArgumentNullException();

            }

        }
        //Já o método Deletar será um pouco mais simples,
        //pois você só precisa identificar o artista com
        //Id e utilizar o script $"DELETE FROM Artistas
        //WHERE Id = @id" para apagar do banco.
        public void DeletarArtista(Artista artista)
        {
            if (artista != null)
            {
                using var connection = new Connection().ObterConexao();  
                connection.Open();

                string sql = "DELETE FROM Artistas WHERE Id = @id";
                using var command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@id", artista.Id);

                if (command.ExecuteNonQuery() !=0)
                {
                    Console.WriteLine("Dados do artista com ID ", artista.Id, " Deletados com sucesso!");
                }

            }
            else
            {
                Console.WriteLine("Objeto Nulo - > Artista nao cadastrado");
                throw new ArgumentNullException();
            }
        }

        public IEnumerable<Artista> ListarArtista()
        {
            List<Artista> lista = new List<Artista>();
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = "SELECT * FROM Artistas";
            using var command = new SqlCommand(sql, connection);
            using SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string nome = Convert.ToString(dataReader["Nome"]);
                string bio = Convert.ToString(dataReader["Bio"]);
                int id = Convert.ToInt32(dataReader["Id"]);
                lista.Add(new Artista(nome, bio) { Id = id});
            }
            return lista;
        }
        public void AdicionarArtista(Artista artist)
        {
            using var connection = new Connection().ObterConexao();
            connection.Open();

            string sql = "INSERT INTO Artistas (Nome, FotoPerfil, bio) VALUES (@nome, @perfilpadrao, @bio)";

            using SqlCommand command = new SqlCommand(sql, connection);

            command.Parameters.AddWithValue("@nome", artist.Nome);
            command.Parameters.AddWithValue("@perfilPadrao", artist.FotoPerfil);
            command.Parameters.AddWithValue("@bio", artist.Bio);


            Console.WriteLine("Linhas afetadas : ", command.ExecuteNonQuery());
            Console.ReadKey();
            Console.Clear();
        }
       */
    }
}
