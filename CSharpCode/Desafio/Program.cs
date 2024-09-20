                                                using System;
                                                using System.Collections.Generic;
                                                using System.Linq;
                                                using System.Text;
                                                using System.Threading.Tasks;

                                                namespace Ex3e4e5_04CAAL;

                                                internal class Controler
                                                {
                                                    public void PrincípioDeControle()
                                                    {
                                                        int x = 0;
                                                        while (x==0) { 
                                                            Console.WriteLine("\t\t\t\tSISTEMA DE CADASTRO E MANIPULAÇÃO DE DADOS DE PESSOAS\n\n");
                                                            Console.WriteLine(@"Escolha uma das Opcoes para Seguir:\n
                                                                    \t1 -> Novo Cadastro-Pessoa\n" +
                                                                " \t2 -> Exibir Pessoas Cadastradas em Ordem\n" +
                                                                " \t3 -> Buscar Pessoa(Por nome/idade)\n" +
                                                                " \t4 -> Exibir Dados de uma pessoa" +
                                                                " \t5 -> ManipularJson\n" +
                                                                " \t0 -> ENCERRAR PROGRAMA");
                                                            x = int.Parse(Console.ReadLine()!);
                                                        }
                                                        switch (x)
                                                        {
                                                            case 1:

                                                                break;
                                                            case 2:

                                                                break;
                                                            case 3:

                                                                break;
                                                            case 4:

                                                                break;
                                                            case 5:

                                                                break;
                                                            case 0:
                                                                Console.WriteLine("PROGRAMA ENCERRADO\n");
                                                                break;
                                                            default:
                                                                Console.WriteLine("COMANDO NÃO RECONHECIDO\n");
                                                                break;
                                                        }
                                                    }

                                                }
                                                
