using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caQuestão1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n1 = new NomeProprio("Edgard Afonso Lamounier");
            n1.imprime_nome_paper();  

            var n2 = new NomeProprio("Edgard A. Lamounier");
            n2.imprime_nome_paper();

            var n3 = new NomeProprio("Edgard Lamounier");
            n3.imprime_nome_paper();

            Console.ReadLine();
        }
    }
}
