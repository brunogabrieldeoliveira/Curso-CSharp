using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2020, 09, 26);
            DateTime dataHora = new DateTime(2020, 09, 26, 14, 12, 45);

            //acessando dados
            Console.WriteLine("Ano: " + dataHora.Year);
            Console.WriteLine("Mês: " + dataHora.Month);
            Console.WriteLine("Dia: " + dataHora.Day);
            Console.WriteLine("Hora: " + dataHora.Hour);
            Console.WriteLine("Minutos: " + dataHora.Minute);
            Console.WriteLine("Segundos: " + dataHora.Second);
            Console.WriteLine("Dia da semana: " + dataHora.DayOfWeek);
            Console.WriteLine("--------------");

            Console.WriteLine(data.ToString());
            Console.WriteLine(dataHora.ToString());


            //pegando data e e hora atual
            DateTime dataHoraAtual = DateTime.Now;
            Console.WriteLine(dataHoraAtual.ToString());
            Console.WriteLine("--------------");


            //Convertendo uma string em DateTime
            DateTime dataConvertida = Convert.ToDateTime("22/11/2023");
            DateTime dataHoraConvertida = Convert.ToDateTime("22/11/2023 14:15:22");
            Console.WriteLine("Data: " + dataConvertida.ToString());
            Console.WriteLine("Data e hora: " + dataHoraConvertida.ToString());
            Console.WriteLine("--------------");


            //Formatando a date e hora impressa
            Console.WriteLine(dataHoraConvertida.ToString("yyyy/MM"));
            Console.WriteLine(dataHoraConvertida.ToString("yyyy/MM/dd"));
            Console.WriteLine(dataHoraConvertida.ToString("yyyy-MM-dd"));
            Console.WriteLine(dataHoraConvertida.ToString("HH:mm:ss"));
            Console.WriteLine(dataHoraConvertida.ToString("HH-mm-ss"));
            Console.WriteLine("--------------");

            //Operações com as variáveis datetime
            DateTime dataHora2 = new DateTime(2020, 09, 26, 17, 20, 37);
            dataHora2 = dataHora2.AddDays(4);
            //dataHora2 = dataHora2.AddYears(x);
            //dataHora2 = dataHora2.AddMonths(x);
            Console.WriteLine(dataHora2.ToString("dd/MM/yyyy"));



            //inserindo um intervalo de tempo
            dataHora2 = dataHora2.Add(new TimeSpan(4, 1, 55, 30));
            Console.WriteLine(dataHora2.ToString("dd HH:mm:ss"));
            dataHora2 = dataHora2.Add(new TimeSpan(1, 55, 30));
            Console.WriteLine(dataHora2.ToString("HH:mm:ss"));
            Console.WriteLine("--------------");


            //subtraindo datas
            DateTime dataHora3 = new DateTime(2023, 3, 1, 14, 5, 20);
            dataHora3 = dataHora3.Subtract(new TimeSpan(1, 5, 20));
            Console.WriteLine(dataHora3.ToString("HH:mm:ss"));


            dataHora3 = dataHora3.AddDays(-1);
            Console.WriteLine(dataHora3.ToString("dd/MM/yyyy"));
            
            
            Console.WriteLine("Digite qualquer tecla pra sair...");
            Console.ReadKey();
        }
    }
}
