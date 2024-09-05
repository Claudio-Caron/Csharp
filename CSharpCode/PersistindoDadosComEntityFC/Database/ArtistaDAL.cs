using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistindoDadosComEntityFC.Database
{
    class ArtistaDAL
    {
        //métodos para listar e adicionar artistas;
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

            Console.WriteLine(artist.ToString());
            Console.ReadKey();

            command.Parameters.AddWithValue("@nome", artist.Nome);
            command.Parameters.AddWithValue("@perfilPadrao", artist.FotoPerfil);
            command.Parameters.AddWithValue("@bio", artist.Bio);


            Console.WriteLine("Linhas afetadas : ", command.ExecuteNonQuery());
            Console.ReadKey();
            Console.Clear();
        }
    }
}
