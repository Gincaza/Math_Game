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

}

static void Subtrair()
{

}

static void Multiplicar()
{

}

static void Dividir()
{

}

Main();