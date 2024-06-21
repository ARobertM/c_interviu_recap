using recapC;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int[] num1 = { 1, 2, 3, 0, 0, 0 };
        int[] num2 = { 2, 4, 5, 6, 0, 0 };
        int m = 3;
        int n = 4;
      
        Merge(num1,m,num2,n);
        string nume = "robert";

        List<int> lista_numere = new List<int>();
        lista_numere.Add(1);
        lista_numere.Add(3);
        lista_numere.Add(6);
        ReverseString(nume);
        int max = MaxNumber(lista_numere);
        Console.WriteLine(max);
        // oop 
        Car c1 = new Car(1, "Renault", 2008, "Robert");
        c1.calculCombustibil(60, 100);
        

    }
    public static void Merge(int[] num1, int m, int[] num2, int n)
    {
        int j = 0;
        for(int i = 0; i < num1.Length; i++)
        {
            if (num1[i] == 0 && n > j)
            {
                num1[i] = num2[j];
                j++;
            }
        }
        Array.Sort(num1);
        foreach(int i in num1)
        {
            Console.Write(i + " ");
        }

    }
    
    public static void ReverseString(string s)
    {
        Console.WriteLine("Text: " + s);
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        Console.WriteLine(charArray);
    }

    public static int MaxNumber(List<int> list)
    {
        int max = 0;
        foreach(int i in list)
        {
            max = Math.Max(max, i);
        }
        return max;
    }

    
}