using System;

Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
Console.WriteLine("--------------------------------------------");
Console.WriteLine();


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

void MooseReply()
{
    string[] replies = new string[6] { "As I see it, yes.", "Ask again later.", "Better not tell you now.", "Concentrate and ask again.", "It is decidedly so.", "Very doubtful." };
    Random r = new Random();
    int genRand = r.Next(0, replies.Length);
    Console.WriteLine(replies[genRand]);
}

MooseSays("I'm the clairvoyant moose");
MoosePrediction();

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

bool MoosePrediction()
{
    Console.WriteLine("ask me anything and I'll give you a wise response");
    ConsoleKeyInfo keyInfo = Console.ReadKey();
    string question = Console.ReadLine().ToLower();
    while (question != "")
    {
        MooseReply();
        Console.WriteLine("ask me another one");
        question = Console.ReadLine().ToLower();
    }
    return false;
}