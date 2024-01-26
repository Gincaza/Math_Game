/* BEM VINDO AO MEU JOGUINHO SILLY DE MATEMATICA!!!!! BY: MOTHNUE
    
    Se voce quiser entender a logica por tras dos metodos Somar(), Subtrair, etc.. 
    Apenas Leia os comentarios que deixei no metodo Somar(), nao deixei nos outros porque todos eles seguem o mesmo modelo, oque muda seria o operador.
    
    
*/


using System;
using System.Timers;

static void Main()
{
    while (true)
    {
        Console.WriteLine("Bem vindo ao jogo de matemática. Meu primeiro projeto em C# btw.");
        Menu();
        string userInput = Console.ReadLine().Trim();

        if (userInput == "1")
        {
            Somar();
        }
        else if (userInput == "2")
        {
            Subtrair();
        }
        else if (userInput == "3")
        {
            Multiplicar();
        }
        else if (userInput == "4")
        {
            Dividir();
        }
        else if (userInput == "0")
        {
            Console.WriteLine("Obrigado por jogar. Até logo!");
            break;
        }
        else
        {
            Console.WriteLine("Opção inválida. Tente novamente.");
        }
    }
}


static void Somar()
    {
        Random rndx = new Random();
        Random rndy = new Random();
        int score = 0;

        // Exibe o menu de dificuldade
        MenuDificuldade();
        string input = Console.ReadLine();

        // Configura a dificuldade com base na entrada do usuário
        int diff = 0;
        if (input == "1")
        {
            diff = 10;
        }
        else if (input == "2")
        {
            diff = 20;
        }
        else if (input == "3")
        {
            diff = 30;
        }

        // Gera 10 perguntas e verifica as respostas do usuário
        for (int i = 0; i < 10; i++)
        {
            int x = rndx.Next(1, diff);
            int y = rndy.Next(1, diff);
            int result = x + y;

            // Exibe a pergunta
            Console.WriteLine($"{x} + {y} = ?");

            // Obtém a resposta do usuário
            string user = Console.ReadLine();
            int usr = Convert.ToInt32(user);

            // Verifica se a resposta do usuário está correta e atualiza a pontuação
            if (usr == result)
            {
                score++;
            }
        }

        // Exibe a pontuação final
        Console.WriteLine($"Your Score is {score}");
    }


    static void Subtrair()
    {
        Random rndx = new Random();
        Random rndy = new Random();
        int score = 0;


        MenuDificuldade();
        string input = Console.ReadLine();


        int diff = 0;
        if (input == "1")
        {
            diff = 10;
        }
        else if (input == "2")
        {
            diff = 20;
        }
        else if (input == "3")
        {
            diff = 30;
        }


        for (int i = 0; i < 10; i++)
        {
            int x = rndx.Next(1, diff);
            int y = rndy.Next(1, diff);
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
        Random rndx = new Random();
        Random rndy = new Random();
        int score = 0;


        MenuDificuldade();
        string input = Console.ReadLine();


        int diff = 0;
        if (input == "1")
        {
            diff = 10;
        }
        else if (input == "2")
        {
            diff = 20;
        }
        else if (input == "3")
        {
            diff = 30;
        }


        for (int i = 0; i < 10; i++)
        {
            int x = rndx.Next(1, diff);
            int y = rndy.Next(1, diff);
            int result = x * y;


            Console.WriteLine($"{x} x {y} = ?");


            string user = Console.ReadLine();
            int usr = Convert.ToInt32(user);


            if (usr == result)
            {
                score++;
            }
        }


        Console.WriteLine($"Your Score is {score}");
    }

    static void Dividir()
    {
        Random rndx = new Random();
        Random rndy = new Random();
        int score = 0;


        MenuDificuldade();
        string input = Console.ReadLine();


        int diff = 0;
        if (input == "1")
        {
            diff = 10;
        }
        else if (input == "2")
        {
            diff = 20;
        }
        else if (input == "3")
        {
            diff = 30;
        }


        for (int i = 0; i < 10; i++)
        {
            int x = rndx.Next(1, diff);
            int y = rndy.Next(1, diff);
            int result = x / y;


            Console.WriteLine($"{x} / {y} = ?");


            string user = Console.ReadLine();
            int usr = Convert.ToInt32(user);


            if (usr == result)
            {
                score++;
            }
        }


        Console.WriteLine($"Your Score is {score}");
    }

    static void Menu()
    {
        Console.WriteLine("╔═════════════════════════════════════════════════════════════╗");
        Console.WriteLine("║                       Escolha uma opção:                    ║");
        Console.WriteLine("║                                                             ║");
        Console.WriteLine("║   1 - Somar                                                  ║");
        Console.WriteLine("║   2 - Subtrair                                               ║");
        Console.WriteLine("║   3 - Multiplicar                                            ║");
        Console.WriteLine("║   4 - Dividir                                                ║");
        Console.WriteLine("║   0 - Sair                                                   ║");
        Console.WriteLine("╚═════════════════════════════════════════════════════════════╝");
    }


    static void MenuDificuldade()
    {
        Console.WriteLine("---------------------------------------------------------------");
        Console.WriteLine("Escolha uma dificuldade para as operações matemáticas:");
        Console.WriteLine("1 - Fácil");
        Console.WriteLine("2 - Médio");
        Console.WriteLine("3 - Difícil");
        Console.WriteLine("---------------------------------------------------------------");
    }

Main();