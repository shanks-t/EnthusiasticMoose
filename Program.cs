﻿using System;

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();

MooseSays("H I, I'M  E N T H U S I A S T I C !");



// void MooseQuestion(string question, string responseTrue, string responseFalse)
// {
//     bool answer = MooseAsks(question);
//     if (answer)
//     {
//         MooseSays(responseTrue);
//     }
//     else
//     {
//         MooseSays(responseFalse);
//     }
// }

// MooseQuestion("Are you shitty programmer?", "Well, keep trying, buddy", "That's cool, can you build a public api for me?");

void MooseQuestion()
{
    string[] replies = new string[6] { "As I see it, yes.", "Ask again later.", "Better not tell you now.", "Concentrate and ask again.", "It is decidedly so.", "Very doubtful." };
    Random r = new Random();
    int genRand = r.Next(0, replies.Length);
    Console.WriteLine(replies[genRand]);
}

MooseQuestion();
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