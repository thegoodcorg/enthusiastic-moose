using System;

namespace EnthusiasticMoose
{

    class Program
    {

        public static void Main()
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator! ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            MooseSays("H I, I'M  E N T H U S I A S T I C !");
            MooseSays("I really am enthusiastic!");

            // Ask a question

            CanadaQuestion();
            CorgiQuestion();
            ParadoxQuestion();
        }
    }
}




void MooseSays(string message)
{
    Console.WriteLine($@"
                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
}

bool MooseAsks(string question)
{
    Console.Write($"{question} (Y/N): ");
    string answer = Console.ReadLine().ToLower();

    while (answer != "y" && answer != "n")
    {
        Console.Write($"{question} (Y/N): ");
        answer = Console.ReadLine().ToLower();
    }

    if (answer == "y")
    {
        return true;
    }
    else
    {
        return false;
    }
}

void CanadaQuestion()
{

    bool isTrue = MooseAsks("Is Canada real?");
    if (isTrue)
    {
        MooseSays("Really? It seems very unlikely.");
    }
    else
    {
        MooseSays("I  K N E W  I T !!!");
    }

}

void CorgiQuestion()
{
    bool isTrue = MooseAsks("Do corgi butts drive you nuts?");
    if (isTrue)
    {
        MooseSays("I knew I liked you.");
    }
    else
    {
        MooseSays("Get out of my face you communist scum!");
    }
}

void ParadoxQuestion()
{
    bool isTrue = MooseAsks("Is the answer to this question 'No'?");
    if (isTrue)
    {
        MooseSays("Wrong answer");
    }
    else
    {
        MooseSays("Also the wrong answer");
    }
}






// Main();

// void Main()
// {
//     MooseSays("Go ahead and ask me a question");
//     string answer = Console.ReadLine();
//     if (answer != "")
//     {
//         Random r = new Random();
//         int getRandom = r.Next(0, 19);

//         Dictionary<int, string> Answers = new Dictionary<int, string>()
//        {
//         {0, "As I see it, yes."},
//         {1, "Ask again later."},
//         {2, "Better not tell you now."},
//         {3, "Cannot predict now."},
//         {4, "Concentrate and ask again."},
//         {5, "Don’t count on it."},
//         {6, "It is certain."},
//         {7, "It is decidedly so."},
//         {8, "Most likely."},
//         {9, "My reply is no."},
//         {10, "My sources say no."},
//         {11, "Outlook not so good."},
//         {12, "Outlook good."},
//         {13, "Reply hazy, try again."},
//         {14, "Signs point to yes."},
//         {15, "Very doubtful."},
//         {16, "Without a doubt."},
//         {17, "Yes."},
//         {18, "Yes – definitely."},
//         {19, "You may rely on it."}
//        };
//     }

// }