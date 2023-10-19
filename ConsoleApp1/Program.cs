class Zad
{   
    static void Main(string[] args)
    {
        double F, C;
        Console.WriteLine("Podaj temp. w stopniach Celcjusza");
        C = double.Parse(Console.ReadLine());
        F = 32 + (9.0 / 5) * C;
        Console.WriteLine(F);
        Console.ReadKey();
    }
}