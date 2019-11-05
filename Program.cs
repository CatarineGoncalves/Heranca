using System;
using Poo_exercicio2.Models;

namespace Poo_exercicio2 {
    class Program {
        static void Main (string[] args) {

            for (int i = 0; i < 2; i++) {

                System.Console.WriteLine (@" PRODUTOS:
            

            (1) Canetas

            (2) Estojo 

            (3) Mouse

            (4) Garrafa

            (5) Fone de Ouvido

            (6) Casa do Tsukamoto
            
            Digite a opção desejada");

                int ib = int.Parse (Console.ReadLine ());

                switch (ib) {

                    case 1:
                        CanetaModel caneta = new CanetaModel ();
                        caneta.CadastrarCaneta();
                        caneta.ListarCaneta();
                        break;

                    case 2:
                        EstojoModel estojo = new EstojoModel ();
                        estojo.CadastrarEstojo();
                        estojo.ListarEstojo();
                        break;

                    case 3:
                        MouseModel mouse = new MouseModel ();
                        mouse.CadastrarMouse();
                        mouse.ListarMouse();

                        break;

                    case 4:
                        GarrafaModel garrafa = new GarrafaModel ();
                        garrafa.CadastrarGarrafa();
                        garrafa.ListarGarrafa();
                        break;

                    case 5:
                        FoneModel fone = new FoneModel ();
                        fone.CadastrarFone();
                        fone.ListarFone();
                        break;

                    case 6:
                        CasaModel casadotsuka = new CasaModel();
                        casadotsuka.Endereco = "Atucupe 222";
                        casadotsuka.Sala = 1;
                        casadotsuka.Quarto = 4;
                        casadotsuka.Cozinha = 1;
                        
                        System.Console.WriteLine($@"
                        A casa do Tsukamoto");

                        break;


                    default:
                        System.Console.WriteLine ("digite uma das opções");
                        break;
                }
            }
        } //cfim do main 
    }
}