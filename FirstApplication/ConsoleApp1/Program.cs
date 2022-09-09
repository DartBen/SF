using static System.Console;

internal class Program
{
    
    private static void Main(string[] args)
    {
        Console.WriteLine("Как вас зовут?");
        //string? Name = null;
        string? Name=Console.ReadLine();
        Console.WriteLine("Здраствуйте,{0}", Name);
        Console.WriteLine("Я инженер-программист АСУТП. Хочу сменить несколько сменить профиль");
        
    }

}