using System;

namespace ChatBot_Devilverrable_2
{
    class MainClass
    {

        public static void Main(string[] args)
        {

            string uInput = string.Empty;
            string Chatmem = string.Empty;
          

            while (true)
            {

                Console.WriteLine("Chatbot wants to talk, how would you like to respond?"); // chatbot starts convo

                uInput = (Console.ReadLine().ToLower()); //converting to lowercase

                if (uInput == Chatmem.ToLower())
                { //responding to repeated inputs
                    Console.WriteLine("I'm sorry you've already said that.");
                    continue;
                }

                if (uInput == "hello")
                {
                    Console.WriteLine("Hi good to see you.");//responding to hello

                }
                else if (uInput == "sup")
                {
                    Console.WriteLine("I am good");//responding to sup
                }

                else if (uInput == "hello there")
                {
                    Console.WriteLine("General Kenobi"); //responding to hello there

                }
                else if (uInput == "bye")
                {
                    Console.WriteLine("Good Bye!"); //responding to good bye by ending program
                    break;
                }

                Chatmem = uInput; //checking for repeated inputs



            }
        }
    }
}
