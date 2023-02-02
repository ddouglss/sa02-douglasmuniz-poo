using System;
using Sa02Poo.RegraDeNegocio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sa02Poo.Aplicativo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Aplicativo2RN app2= new Aplicativo2RN();

            Console.WriteLine("Digite o ano atual:");
            var voo1 = Console.ReadLine();
            Console.WriteLine("Digite o ano do primeiro voo do avião da Embraer:");
            var voo2 = Console.ReadLine();

          int ano1, ano2;
            ano1= int.Parse(voo1);
            ano2= int.Parse(voo2);

           int v = app2.SubtracaoAno(ano1, ano2);
           int resultado = v;
            Console.WriteLine("resultado:" + resultado);
            Console.ReadKey();
        }
      
       
    }
}
