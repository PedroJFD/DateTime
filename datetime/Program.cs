using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Informe data nasci: ");
        DateTime datanas = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine(datanas.DayOfWeek);


        DateTime data1 = new DateTime(2022, 07, 03);
        DateTime data2 = new DateTime(2023, 07, 24, 15, 30, 50);

        Console.WriteLine(data1);
        Console.WriteLine(data2);

        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.UtcNow);
        Console.WriteLine(DateTime.Today);
        Console.WriteLine(data1.DayOfWeek);
        Console.WriteLine(data1.DayOfYear);

        int diaano = data1.DayOfYear;

        DateTime data3 = data1.AddDays(5);
        Console.WriteLine(data3);

        TimeSpan a = data3.Subtract(data1);
        Console.WriteLine(a.Days);

        DateTime datap = new DateTime(2006, 06, 25);

        TimeSpan p = DateTime.Now.Subtract(datap);

        Console.WriteLine(p.Days);

        //comparacao de data

        DateTime d1 = new DateTime(2023, 05, 06);
        DateTime d2 = new DateTime(2022, 05, 06);

        Console.WriteLine(DateTime.Compare(d1,d2));

        //0 igual
        //1 primeira é maior
        //-1 primeira é menor

        DateTime d3= DateTime.Parse("04-12-2004");
        Console.WriteLine(d3);

        DateOnly dto = DateOnly.Parse("04-12-2004");
        Console.WriteLine(dto);
    }
}
