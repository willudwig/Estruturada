using System;

namespace EstruturadaConsoleApp
{
    internal class Program
    {
        static int cont = 0;
        static void Main(string[] args)
        {

            int menorValor;
            int[] numeros = new int[10];
            int maiorValor = 0;

            //ler vetor
            CarregarVetor(ref numeros);
            
            //mostrar vetor
            MostrarArray(numeros);
            Console.ReadKey();

            //mostrar o maior
            MaiorValor(ref maiorValor, numeros);
            escreva("\n\nO maior valor é: " + maiorValor);

            //mostrar o menor
            MenorValor(out menorValor, numeros);
            escr_("\n\nO menor valor é " + menorValor);
            Console.ReadKey();

            //mostrar a média
            escreva("\nA média é: ");
            int resultado = MediaVetor(numeros);
            escr_(resultado.ToString());
            Console.ReadKey();

            //mostrar os 3 maiores valores
            int[] vetorQueRecebeoMetodo = TresMaiores(numeros);
            escreva("\nOs três maiores são: ");
            for (int i = 0; i < 3; i++)
            {
                escreva(vetorQueRecebeoMetodo[i] + " ");
            }
            Console.ReadKey();

            //mostrar os negativos
            int[] numerosNegativos = EncontrarNegativos(numeros);
            escreva("\n\nOs números negativos são: ");

            for (int i = 0; i < numerosNegativos.Length; i++)
            {
                if (numerosNegativos[i] != 0)
                {
                    escreva(numerosNegativos[i] + " ");
                }
            }
            Console.ReadKey();

            escr_("\n");

            //removendo ítem do vetor
            int[] ArrayItemExcluido = RemoverItem(numeros);

            for (int i = 0; i < ArrayItemExcluido.Length - cont; i++)
            {
                 escreva(ArrayItemExcluido[i] + " ");
            }
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
        static int MaiorValor(ref int maior, int[] vetor)
        {
            Array.Sort(vetor);

            maior = vetor[vetor.Length - 1];

            return maior;
        }
        static void MenorValor(out int menor, int[] vetor)
        {
            Array.Sort(vetor);
            menor = vetor[0];
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
        static int[] TresMaiores(int[] vetor)
        {
            Array.Sort(vetor);
            
            int[] novoVetor = new int[3];
            
            novoVetor[0] = vetor[vetor.Length - 1]; 
            novoVetor[1] = vetor[vetor.Length - 2];
            novoVetor[2] = vetor[vetor.Length - 3];

            return novoVetor;
        }
        static int[] EncontrarNegativos(int[] vetor) 
        {
            int[] negativos = new int[vetor.Length];

            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] < 0)
                {
                    negativos[i] = vetor[i];
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
        static int[] RemoverItem(int[] vetor)
        {
            escreva("Qual valor remover?: ");
            int item = int.Parse(leia_());
            escr_(" ");

            //verificar se tem repetido
            for (int i = 0; i < vetor.Length; i++)
            {
                if (vetor[i] == item)
                {
                    cont++;
                }
            }
            //====================== fim da verificação

            int[] novoArray = new int[vetor.Length];
            int c = 0;
            for (int i = 0; i < novoArray.Length; i++)
            {
                if (vetor[i] != item)
                {
                   novoArray[c] = vetor[i];
                    c++;
                }
            }
            return novoArray;
        }
    }

}
