using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingIsFun.Question
{
    public class Questioneer
    { 
        public string question { get; set; }
        public string answer { get; set; } // ONLY ENGLISH // AND ONE WORD ONLY // BOT HAS BASIC ENLISH so when you say a word that he doesnt know he will get mad
        public int answerInt { get; set; }
        public int AngryLevel { get; set; } //chooses a random response depending on the angry level
        public bool isAnswered { get; set; }

        public Questioneer(string question)
        {
            Console.Clear();
            this.question = question;

            Console.WriteLine(question);

            GetAnswer();
            //Environment.TickCount64
        }
        public Questioneer(string question, string Whatfor)
        {
            Console.Clear();
            this.question = question;
            Console.WriteLine(question);

            GetAnswer();

            //Whatfor = answer;

            isAnswered = false;

            //int answerInnit = 0;
            while (!isAnswered)
            {
                bool isInt = int.TryParse(answer, out _);
                if (isInt)
                {
                    isAnswered = false;
                }
                if (isInt)
                {
                    AngryLevel++;
                    switch (AngryLevel)
                    {
                        case 1:
                            Console.WriteLine("This question is for text asnwer");
                            answer = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("I need text here");
                            answer = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("This is obviously place to put a text not a NUMBER");
                            answer = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("THIS IS A NUMBER NOT TEXT");
                            answer = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("GIVE ME TEXT");
                            answer = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Im done");
                            Environment.Exit(0);
                            break;
                    }
                }
                if (!isInt)
                {
                    isAnswered = true;
                }
            }
        }
        public Questioneer(string question, int Whatfor)
        {
            Console.Clear();
            this.question = question;
            Console.WriteLine(question);

            GetAnswer();

            isAnswered = false;

            while (!isAnswered)
            {
                int answerInnit = 0;
                bool isInt = int.TryParse(answer, out answerInnit);
                if (!isInt)
                {
                    isAnswered = false;
                }
                if (!isInt)
                {
                    AngryLevel++;
                    switch (AngryLevel)
                    {
                        case 1:
                            Console.WriteLine("This question is for number asnwer");
                            answer = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("I need a number here");
                            answer = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("This is obviously place to put a number not TEXT");
                            answer = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("THIS IS TEXT NOT NUMBER");
                            answer = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("GIVE ME A NUMBER");
                            answer = Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("Im done");
                            Environment.Exit(0);
                            break;
                    }
                }
                if (isInt)
                {
                    answerInt = answerInnit;
                    isAnswered = true;
                }
            }
        }

        public void GetAnswer()
        {
            answer = Console.ReadLine();
            isAnswered = false;
            while (!isAnswered)
            {
                if (answer.Trim().Length == 0 || answer == "") //checks if answer is only white space (I learned white space from google)
                {
                    AngryLevel++;
                    switch (AngryLevel)
                    {
                        case 1:
                            Console.WriteLine("Can you answer?");
                            //Console.Beep(160, 200);
                            answer = Console.ReadLine().ToLower().Trim();
                            break;
                        case 2:
                            Console.WriteLine("Pls");
                            //Console.Beep(140, 200);
                            answer = Console.ReadLine().ToLower().Trim();
                            break;
                        case 3:
                            Console.WriteLine("Aswer the question");
                            //Console.Beep(120, 200);
                            answer = Console.ReadLine().ToLower().Trim();
                            break;
                        case 4:
                            Console.WriteLine("ANSWER ALL READY");
                            //Console.Beep(100, 200);
                            answer = Console.ReadLine().ToLower().Trim();
                            break;
                        default:
                            Console.WriteLine("Im done");
                            //Console.Beep(60, 200);
                            //Console.WriteLine(Environment.UserName);
                            Environment.Exit(0);
                            break;

                    }
                }
                //String[] answerWords = answer.Split(' ');
                String[] answerWords = answer.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (answerWords.Length >= 2)
                {
                    AngryLevel++;
                    switch (AngryLevel)
                    {
                        case 1:
                            Console.WriteLine("I said one word each answer");
                            answer = Console.ReadLine().ToLower();
                            break;
                        case 2:
                            Console.WriteLine("One word each answer");
                            answer = Console.ReadLine().ToLower();
                            break;
                        case 3:
                            Console.WriteLine("If u not going to answer im leaking ur real name (not acutally)");
                            answer = Console.ReadLine().ToLower();
                            break;
                        case 4:
                            Console.WriteLine("JUST ONE WORD EACH ANSWER");
                            answer = Console.ReadLine().ToLower();
                            break;
                        case 5:
                            Console.WriteLine("WELL IM SORRY I CANT HANDLE MANY WORDS");
                            answer = Console.ReadLine().ToLower();
                            break;
                        default:
                            Console.WriteLine("Im done");
                            Environment.Exit(0);
                            break;
                    }
                }
                if (answer.Trim().Length != 0 && answerWords.Length <= 1)
                {
                    isAnswered = true;
                }
            }
            answer = String.Concat(answer.Where(c => !Char.IsWhiteSpace(c))); // I found this on google im not so smart
        }
    }
}
