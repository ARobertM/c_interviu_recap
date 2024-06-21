using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recapC
{
    public class Car : IMasina
    {
        private int id;
        private string marca;
        private int year;
        private string detinator_m;

        public Car(int id, string marca, int year, string detinator_m)
        {
            this.Id = id;
            this.Marca = marca;
            this.Year = year;
            this.Detinator_m = detinator_m;
        }

        public int Id { get => id; set => id = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Year { get => year; set => year = value; }
        public string Detinator_m { get => detinator_m; set => detinator_m = value; }

        public override string? ToString()
        {
            return base.ToString();
        }

        public static void CitireMasina(Car c)
        {
            Console.WriteLine(c.detinator_m + " are o masina super tare!");
        }

        public void calculCombustibil(int c, int km)
        {
            Console.WriteLine(c * km);
        }
    }
}
