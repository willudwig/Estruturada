using System;

namespace EstruturadaConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string menorValor = "";
            int[] numeros = new int[10];

            //ler vetor
            CarregarVetor(ref numeros);
            
            //mostrar vetor
            MostrarArray(numeros);
            Console.ReadKey();

            //mostrar o maior e o menor valor
            MaiorMenorValor(ref numeros, out menorValor);
            escr_(menorValor);
            Console.ReadKey();

            //mostrar a média
            escreva("A média é: ");
            int resultado = MediaVetor(numeros);
            escr_(resultado.ToString());
            Console.ReadKey();

            //mostrar os 3 maiores valores
            TresMaiores(numeros);
            Console.ReadKey();

            //mostrar os negativos
            string numerosNegativos = EncontrarNegativos(numeros);
            escr_("\nOs números negativos são: " + numerosNegativos);
            Console.ReadKey();

            //removendo um ítem do vetor
            RemoverItem(numeros);
            Console.ReadKey();
        }

        static void escr_(string texto)
        {
            System.Console.WriteLine(texto);
        }
        static void escreva(string texto)
        {
            System.Console.Write(texto);
        }
        static string leia_()
        {
            string texto = System.Console.ReadLine();
            return texto;
        }
        static void MaiorMenorValor(ref int[] vetor, out string menor)
        {
            Array.Sort(vetor);
            escr_("\n\nO maior valor é: " + vetor[vetor.Length - 1]);
            menor = "\nO menor valor é: " + vetor[0] + "\n";
        }
        static void CarregarVetor(ref int[] numeros)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                escreva("Digite o " + (i + 1) + "º valor: ");
                numeros[i] = int.Parse(leia_());
            }
        }
        static int MediaVetor(int[] vetor)
        {
            int soma = 0;
            for (int i = 0; i < vetor.Length; i++)
            {
                soma += vetor[i];
            }
            int media = soma / vetor.Length;
            return media;
        }
        static void TresMaiores(int[] vetor)
        {
            escr_("\nOs três maiores valores são " + vetor[vetor.Length - 1] + ", " + vetor[vetor.Length - 2] + ", " + vetor[vetor.Length - 3]);
        }
        static string  EncontrarNegativos(int[] vetor) 
        {
            string negativos = "";
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < 0)
                {
                    negativos += vetor[i] + ", ";
                }
            }
            return negativos;
        }
        static void MostrarArray(int[] vetor) 
        {
            escr_("\nMostrando Array: \n");
            foreach (int v in vetor)
            {
                escreva(v.ToString() + " ");
            }
        }
        static void RemoverItem(int[] vetor)
        {
            escreva("\nQual valor remover?: ");
            int item = int.Parse(leia_());
            escr_(" ");
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == item)
                {
                    for (int j = 0; j < vetor.Length; j++)
                    {
                        if (vetor[j] != item)
                        {
                            escreva(vetor[j] + " ");  
                        }
                    }
                }
            }
        }
    }
}
