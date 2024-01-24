using System;
using System.Timers;
static void Main()
{
    Console.WriteLine("Bem vindo ao jogo de matematica. Meu primeiro projeto em C# btw.");
    Menu();
    string userInput = Console.ReadLine();
    string trUserInput = userInput.Replace(" ", "");
    
    if (trUserInput == "1")
    {
        Somar();
    } else if (trUserInput == "2")
    {
        Subtrair();
    } else if(trUserInput == "3")
    {
        Multiplicar();
    } else if (trUserInput == "4")
    {
        Dividir();
    } else { Console.WriteLine("Insira uma opcao correta."); }
}

static void Menu()
{
    Console.WriteLine("___________________________________________________________________");
    Console.WriteLine("Escolha um item:");
    Console.WriteLine("\t1 - Somar");
    Console.WriteLine("\t2 - Subtrair");
    Console.WriteLine("\t3 - Multiplicar");
    Console.WriteLine("\t4 - Dividir");
}


static void Somar()
{
    Random rndx = new Random();
    Random rndy = new Random();
    int score = 0;
    

    for (int i = 0; i < 10; i++)
    {
        int x = rndx.Next(1, 100);
        int y = rndy.Next(1, 100);
        int result = x + y;
        Console.WriteLine($"{x} + {y} = ?");
        string user = Console.ReadLine();
        int usr = Convert.ToInt32(user);

        if (usr == result)
        {
            score++;
        }
    }

    Console.WriteLine($"Your Score is {score}");
}

static void Subtrair()
{
    Random rndx = new Random();
    Random rndy = new Random();
    int score = 0;
    for (int i = 0; i < 10; i++)
    {
        int x = rndx.Next(1, 100);
        int y = rndy.Next(1, 100);
        int result = x - y;
        Console.WriteLine($"{x} - {y} = ?");
        string user = Console.ReadLine();
        int usr = Convert.ToInt32(user);

        if (usr == result)
        {
            score++;
        }
    }

    Console.WriteLine($"Your Score is {score}");
}

static void Multiplicar()
{

}

static void Dividir()
{

}

static void MenuDificuldade()
{
    Console.WriteLine("====================================================================");
    Console.WriteLine("Escolha uma dificuldade:");
    Console.WriteLine("\t1 - Facil");
    Console.WriteLine("\t2 - Medio");
    Console.WriteLine("\t3 - Dificil");
}

Main();