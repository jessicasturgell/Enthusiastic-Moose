﻿using System;

Main();

void Main()
{
    Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();

    // Let the moose speak!
    MooseSays("H I, I'M  E N T H U S I A S T I C !");
    MooseSays("I really am enthusiastic");

    // As a question
    MooseQuestion("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
    MooseQuestion("Are you enthusiastic?", "Yay!", "You should try it!");
    MooseQuestion("Do you love C# yet?", "Good job sucking up to your instructor!", "You will...oh, yes, you will...");
    MooseQuestion("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");

    // Magic Moose Intro
    MooseSays("Thank you for answering my questions! Feel free to ask me something in return.");
    MagicMoose();
}


void MagicMoose()
{
    List<string> answers = new List<string>()
    { 
        "As I see it, yes.",
        "Ask again later.",
        "Better not tell you now.",
        "Cannot predict now.",
        "Concentrate and ask again.",
        "Do not count on it.",
        "It is certain.",
        "It is decidedly so.",
        "Most likely.",
        "My reply is no.",
        "My sources say no.",
        "Outlook not so good.",
        "Outlook good.",
        "Reply hazy, try again.",
        "Signs point to yes.",
        "Very doubtful.",
        "Without a doubt.",
        "Yes.",
        "Yes, definitely.",
        "You may rely on it."
    };

    string question = "";
    do
    {
        Console.WriteLine("Ask me a question (or press Enter to quit): ");
        question = Console.ReadLine();

        if (question != "")
        {
            Random r = new Random();
            int genRand = r.Next(answers.Count);
            string answer = answers[genRand];
            MooseSays(answer);
        }
    } while (question != "");
}

void MooseQuestion(string question, string yesResponse, string noResponse)
{
    bool isTrue = MooseAsks(question);
    if (isTrue)
    {
        MooseSays(yesResponse);
    }
    else
    {
        MooseSays(noResponse);
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