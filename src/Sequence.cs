using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CodingIsFun.Question;

namespace CodingIsFun
{
    internal class Sequence
    {
        public void Play()
        {
            Animal theAnimal = new Animal();

            Console.WriteLine("Hi!");
            Thread.Sleep(TimeSpan.FromMilliseconds(700));

            Console.WriteLine("I want you to describe an ANIMAL");
            Thread.Sleep(TimeSpan.FromMilliseconds(1050));

            Console.WriteLine("I will ask few QUESTIONS");
            Thread.Sleep(TimeSpan.FromMilliseconds(800));

            Console.WriteLine("Then I will TELL YOU about ur ANIMAL");
            Thread.Sleep(TimeSpan.FromMilliseconds(950));

            Console.WriteLine("To answer a question press ENTER after u typed ur QUESTION");
            Thread.Sleep(TimeSpan.FromMilliseconds(1250));

            Console.WriteLine("This is set to UK english");
            Thread.Sleep(TimeSpan.FromMilliseconds(850));

            Console.WriteLine("and you CANT change it");
            Thread.Sleep(TimeSpan.FromMilliseconds(950));

            Console.WriteLine("If anything CRASHES its probaly UR FAULT not who made ME");
            Thread.Sleep(TimeSpan.FromMilliseconds(1250));

            Console.WriteLine("But one rule is each answer is one WORD or NUMBER");
            Thread.Sleep(TimeSpan.FromMilliseconds(1200));

            Console.WriteLine("and if u DONT EVEN ANSWER, then I will get MAD");
            Thread.Sleep(TimeSpan.FromMilliseconds(1150));

            Console.WriteLine("(just pressing enter in a question)");
            Thread.Sleep(TimeSpan.FromMilliseconds(1300));

            Console.WriteLine("(BUT DONT DO IT)");
            Thread.Sleep(TimeSpan.FromMilliseconds(1800));

            Questioneer RUready = new Questioneer("Are you ready?");
            if (RUready.answer == "no")
            {
                Console.WriteLine("If u say so");
                Environment.Exit(0);
            }

            Questioneer AskName = new Questioneer("How do call ur animal?", theAnimal.Name);
            theAnimal.Name = AskName.answer;

            Questioneer AskLegCount = new Questioneer("How many legs does ur animal have?", theAnimal.LegCount);
            theAnimal.LegCount = AskLegCount.answerInt;

            Questioneer HowBig = new Questioneer("How big is ur animal, I count ur answer in cm", theAnimal.SizeCm);
            theAnimal.SizeCm = HowBig.answerInt;

            Questioneer WhatColour = new Questioneer("What colour is ur animal", theAnimal.Colour);
            theAnimal.Colour = WhatColour.answer;

            Questioneer WhatFood = new Questioneer("What is ur animal favourite thing to eat?", theAnimal.FavouriteFood);
            theAnimal.FavouriteFood = WhatFood.answer;

            Questioneer WhatSound = new Questioneer("What name the main sound that ur animal makes", theAnimal.Sound);
            theAnimal.Sound = WhatSound.answer;

            Questioneer AskIQ = new Questioneer("What is ur animals IQ?", theAnimal.IQ);
            theAnimal.IQ = AskIQ.answerInt;

            Console.Clear();

            Console.WriteLine("No more questions");
            Thread.Sleep(TimeSpan.FromMilliseconds(800));

            Console.WriteLine("Done!");
            Thread.Sleep(TimeSpan.FromMilliseconds(1200));

            Console.WriteLine("The animal is ready to be described");
            Thread.Sleep(TimeSpan.FromMilliseconds(900));

            Console.WriteLine("If YOU didnt mess anything up");
            Thread.Sleep(TimeSpan.FromMilliseconds(950));

            Console.WriteLine("Well lets hope not");
            Thread.Sleep(TimeSpan.FromMilliseconds(850));

            Console.WriteLine("Lets see: ");
            Thread.Sleep(TimeSpan.FromMilliseconds(620));

            Console.Clear();

            StoryMaker storymaker = new StoryMaker(theAnimal);
        }
    }
}
