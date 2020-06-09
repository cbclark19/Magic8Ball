using System;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrRespsonses = {"Yes.",
                                      "No.",
                                      "Emphatic Yes.",
                                      "Not no, but no.",
                                      "Did you really just say that out loud?",
                                      "Your mother would be disappointed in such a question.",
                                      "Do you kiss your momma with that mouth?",
                                      "This looks like a question you should ask the tea leaves.",
                                      "LMGTFY ... psych! Google it yo damn self",//find a way to insert code to pull up let me google that for you//
                                      "I'm sick of typing to you.",
                                      "You know there are better uses of my processes",
                                      "Your Dumb.",
                                      "42",
                                      "Try Tarot",
                                      "It's easily 9k1",
                                      "And I thought Gohan was a jobber.",
                                      "Yamcha",
                                      "Buy.",
                                      "Sell.",
                                      "Ask someone who cares.",
                                      "You hit the end of the list.",
                                      "You really hit the end of the list."};

            Console.WriteLine($"Welcome to \"The World's Worst Magic Dime Bag\"\nDo you have a question for the Magic Bag?");
            /* The next area will utilize a read key. 
             * TODO: 1.) make sure the program doesn't break when something other than a "y" or "n"
             *       2.) make sure the program resprects "yes" and "no" 
                     3.) make sure the program igrnores inputs other than "y" or "n"
                     4.) respond to Tyler's petty grievances
             */
            ConsoleKeyInfo UserIn1 = Console.ReadKey();
            Console.WriteLine("\nYou pressed {0}", UserIn1.Key);
            while (UserIn1.Key == ConsoleKey.Y)
            {
                Console.WriteLine($"Is your question a simple \"yes or no\" question?");
                ConsoleKeyInfo UserIn2 = Console.ReadKey();
                Console.WriteLine("\nYou pressed {0}", UserIn2.Key);

                Console.WriteLine("What is your question, pleb?");
                string UserIn3 = Console.ReadLine();
                Console.WriteLine("you typed: \"{0}\"", UserIn3);

                Random rnd = new Random();
                int response = rnd.Next(0, 20);

                Console.WriteLine("{0}", UserIn3);
                Console.WriteLine("{0}", arrRespsonses[response]);

                Console.WriteLine("do you have another question for the Magic Bag?");
                UserIn1 = Console.ReadKey();
                Console.WriteLine("\nYou pressed {0}", UserIn1.Key);
            }
        }
    }
    //Optional TODO: create a table at the end of the session that displays asked queries and their responses
}
