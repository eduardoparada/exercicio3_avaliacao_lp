using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio3_avaliacao_lp
{
    internal class Program
    {
        static void Main()
        {
            //3 – Criar um programa para calcular e mostrar a área de 3 figuras geométricas diferentes, não vale quadrado e nem retângulo.
            //Observação: as figuras são de escolha livre, dá um Google se não lembrar como faz o cálculo de alguma delas.
            //Requisitos: Deve ser apresentada uma lista para o usuário com o nome das 3 figuras que ele pode escolher para calcular.Deve - se utilizar Switch Case.

            // Eduardo Augusto Nilson Parada RA 6322529

            double area, d1, d2, h;
            char op;
            Console.WriteLine("Escolha uma figura gepmétrica para saber sua área:");
            Console.WriteLine("[1] Triângulo | [2] Círculo | [3] Trapézio");
            op = char.Parse(Console.ReadLine());

            switch (op)
            {
                case '1':
                    Console.WriteLine("Digite largura: ");
                    d1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite altura: ");
                    d2 = double.Parse(Console.ReadLine());
                    area = (d1 * d2) / 2;
                    Console.WriteLine("Área do triângulo igual a " + area.ToString("F"));
                    break;
                case '2':
                    Console.WriteLine("Digite o raio: ");
                    d1 = double.Parse(Console.ReadLine());
                    area = (d1*d1) * (3.141516);
                    Console.WriteLine("Área do círculo igual a " + area.ToString("F"));
                    break;
                case '3':
                    Console.WriteLine("Digite base maior: ");
                    d1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite base menor: ");
                    d2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite altura: ");
                    h = double.Parse(Console.ReadLine());
                    area = ((d1 + d2) * h)/2;
                    Console.WriteLine("Área do trapézio igual a " + area.ToString("F"));
                    break;
                default:
                    Console.WriteLine("Escolha inválida!");
                    break;
            }
            Console.ReadKey();
                

        }

    }
}
