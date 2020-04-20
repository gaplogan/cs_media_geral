using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeral
{
    class Program
    {
        struct Notas
        {
            public int prova_1;
            public int prova_2;
            public int prova_3;
            public int prova_4;
        }

        struct Aluno
        {
            public string nome;
            public Notas notas;
            public double media;
        }

        static void Main(string[] args)
        {
            Aluno a1 = new Aluno()
            {
                nome = "João",
                notas = new Notas()
            };

            Aluno a2 = new Aluno()
            {
                nome = "Lucas",
                notas = new Notas()
            };

            Aluno a3 = new Aluno()
            {
                nome = "Pedro",
                notas = new Notas()
            };

            a1.notas.prova_1 = 6;
            a1.notas.prova_2 = 7;
            a1.notas.prova_3 = 4;
            a1.notas.prova_4 = 7;
            a1.media = (a1.notas.prova_1 + a1.notas.prova_2 + a1.notas.prova_3 + a1.notas.prova_4) / 4;

            a2.notas.prova_1 = 9;
            a2.notas.prova_2 = 10;
            a2.notas.prova_3 = 10;
            a2.notas.prova_4 = 9;
            a2.media = (a2.notas.prova_1 + a2.notas.prova_2 + a2.notas.prova_3 + a2.notas.prova_4) / 4;

            a3.notas.prova_1 = 8;
            a3.notas.prova_2 = 10;
            a3.notas.prova_3 = 4;
            a3.notas.prova_4 = 10;
            a3.media = (a3.notas.prova_1 + a3.notas.prova_2 + a3.notas.prova_3 + a3.notas.prova_4) / 4;

            double mediaGeral = (a1.media + a2.media + a3.media) / 3;

            Console.WriteLine("### Media de cada aluno ###");
            Console.WriteLine("---------------------------");
            Console.WriteLine(a1.nome);
            Console.WriteLine(a1.media);
            Console.WriteLine("---------------------------");

            Console.WriteLine(a2.nome);
            Console.WriteLine(a2.media);
            Console.WriteLine("---------------------------");

            Console.WriteLine(a3.nome);
            Console.WriteLine(a3.media);
            Console.WriteLine("---------------------------");

            Console.WriteLine(">>> Média Geral <<<");
            Console.WriteLine(mediaGeral);

            Console.ReadKey();
        }
    }
}
