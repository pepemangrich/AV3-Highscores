using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblesort
{
    public class Lincados {
        public string nome { get; set; }
        public int pontos { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            
             // Pedro Carvalho e Mateus Mariano - 3003   
            Console.WriteLine("Insira o seu score");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Insira o seu nome");
            string b = Console.ReadLine();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("HIGH SCORE");

            Lincados[] score = { new Lincados { nome = "dm", pontos = 100 },
                                 new Lincados { nome = "jamv", pontos = 200},
                                 new Lincados { nome = "flavio", pontos = 243},
                                 new Lincados { nome = "matheus", pontos = 786},
                                 new Lincados { nome = "sergio", pontos = 898},
                                 new Lincados { nome = "antoanne", pontos = 123},
                                 new Lincados { nome = "carlosTelles", pontos = 744},
                                 new Lincados { nome = "andre", pontos = 800},
                                 new Lincados { nome = "joaoPaulo", pontos = 764},
                                 new Lincados { nome = "Maraopodi", pontos = 666},
                                 new Lincados { nome = b, pontos = a}
                                                                            };
           
            
            bubbleSort(score, score.Length);
            for(int i = 0; i < score.Length - 1; i++){
                Console.WriteLine(score[i].nome + " "  + score[i].pontos);
            }
            

        }

         static void bubbleSort(Lincados[] arr, int length)
         {
            // int repos = 0;
             for (int i = 0; i < length - 1; i++)
             {
                 for (int j = 0; j < length - (i + 1); j++)
                 {
                    Lincados esq = arr[j];
                    Lincados dir = arr[j + 1];
                     if (esq.pontos < dir.pontos)
                     {
                         arr[j] = dir;
                         arr[j + 1] = esq;
                         
                     }
                 }
             }
         }
         
    }
}

