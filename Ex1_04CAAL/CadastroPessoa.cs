using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


namespace Ex1_04CAAL
{
    internal class CadastroPessoa
    {
        private string Name { get; }
        private int _idade;
        protected int Idade
        {
            get
            {
                return _idade;
            }
            set
            {
                if (value < 0)
                    _idade = 0;
                else
                    _idade=value;
            }
        }
        private string? Email {  get; set; }
        public CadastroPessoa(string name, int idade, string email)
        {
            Name = name;
            Idade = idade;
            Email = email;
        }
        public override string ToString ()=> $"Nome : {Name}\n Idade : {Idade}\n" +
            $" Email : {Email}\n";
        public void TransformarDadosEmJson()
        {
            string nomeDoArquivo = $"Dados do Usuário {Name}";
            string Json = JsonSerializer.Serialize(new
            {
                nome = Name,
                idade = Idade
            });
            File.WriteAllText(nomeDoArquivo, Json);
            Console.Clear();
            Console.WriteLine($"Dados cadastrados com sucesso!\n\n {ToString()}\n");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Cadastro Json do usuário {Name} criado  !\n Local armazenado: {Path.GetFullPath(nomeDoArquivo)}\n\n");
        }
    }
}
