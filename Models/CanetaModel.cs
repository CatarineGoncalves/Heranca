using System;

namespace Poo_exercicio2.Models {
    public class CanetaModel {
        public string marca { get; set; }

        public string cor { get; set; }

        public double preco { get; set; }

        public double tamanho { get; set; }
        public int ano { get; set; }

        public void CadastrarCaneta () //metodo de cadastrar aluno
        {     
            System.Console.WriteLine ("Marca da Caneta: ");
            marca = Console.ReadLine ();

            System.Console.WriteLine ("Cor: ");
            cor = Console.ReadLine ();

            System.Console.WriteLine ("Tamanhos: ");
            tamanho = double.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Ano de Fabricação: ");
            ano = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Preço: ");
            preco = double.Parse (Console.ReadLine ());
        }
        public void ListarCaneta () {
            System.Console.WriteLine ($@"
            Marca: {marca}
            Cor: {cor}
            Tamanho: {tamanho}
            Ano de Fabricação: {ano}
            Preço: {preco}
            ");
        }
    }
}