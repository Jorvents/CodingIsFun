using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CodingIsFun
{
    class StoryMaker
    {
        public StoryMaker(Animal creature)
        {
            int waitTime = 2000;

            //Name
            if (creature.Name == Environment.UserName)
            {
                Console.WriteLine("Ur animal is called " + Environment.UserName + ", like ur name IRL");
            } else
            {
                Console.WriteLine("Ur animal is called " + creature.Name);
            }

            Thread.Sleep(TimeSpan.FromMilliseconds(waitTime));
            //Leg count
            switch (creature.LegCount)
            {
                case < -1:
                    Console.WriteLine("Ur animals leg count go do minuses, does it go to 4th dimension :eyes:");
                    break;
                case 0:
                    Console.WriteLine("Since ur animal has no legs that means it is a worm type animal or has fins");
                    break;
                case 1:
                    Console.WriteLine("Um ur animal has one leg? How is it moving? Intresting.");
                    break;
                case 2:
                    Console.WriteLine("Ur animal has two legs, pretty normal in birds, also humans have 2 legs");
                    break;
                case 3:
                    Console.WriteLine("Ive never heard an animal that 3 three legs, ur creative.");
                    break;
                case 4:
                    Console.WriteLine("Ur animal has 4 legs, like most animals do");
                    break;
                case 5:
                    Console.WriteLine("Ur animal has... 5 legs? um ok");
                    break;
                case 6:
                    Console.WriteLine("Ur animal has... 6 legs? An animal with 6 legs would look cool");
                    break;
                default:
                    Console.WriteLine("Ur animal has... " + creature.LegCount + " legs? That is a alot for a animal, it could go very fast I assume");
                    break;
            }

            Thread.Sleep(TimeSpan.FromMilliseconds(waitTime));
            //Size
            switch (creature.SizeCm)
            {
                case < -1:
                    Console.WriteLine("Ur animals size goes into minuses, is it in 4th dimension? :eyes:");
                    break;
                case < 1:
                    Console.WriteLine("Ur animal is very smal, its " + creature.SizeCm + " cm.");
                    break;
                case < 5:
                    Console.WriteLine("Ur animal is quite smal, its " + creature.SizeCm + " cm.");
                    break;
                case < 10:
                    Console.WriteLine("Ur animal is about a size of a mouse, its " + creature.SizeCm + " cm.");
                    break;
                case < 30:
                    Console.WriteLine("Ur animal is about a size of a cat, its " + creature.SizeCm + " cm.");
                    break;
                case < 80:
                    Console.WriteLine("Ur animal is about a size of a dog, its " + creature.SizeCm + " cm.");
                    break;
                case < 200:
                    Console.WriteLine("Ur animal is about a size of a tiger, its " + creature.SizeCm + " cm.");
                    break;
                case < 400:
                    Console.WriteLine("Ur animal is about a size of a lion, its " + creature.SizeCm + " cm.");
                    break;
                case < 600:
                    Console.WriteLine("Ur animal is about a size of a crocodile, its " + creature.SizeCm + " cm.");
                    break;
                case < 900:
                    Console.WriteLine("Ur animal is about a size of a bear, its " + creature.SizeCm + " cm.");
                    break;
                case < 3000:
                    Console.WriteLine("Ur animal is about a size of a t-rex, its " + creature.SizeCm + " cm.");
                    break;
                default:
                    Console.WriteLine("Ur animal is very big, its " + creature.SizeCm + " cm.");
                    break;
            }

            Thread.Sleep(TimeSpan.FromMilliseconds(waitTime));
            //Colour
            switch (creature.Colour)
            {
                case "white":
                    Console.WriteLine("Ur animal is white, it must hurt to look at");
                    break;
                case "grey":
                    Console.WriteLine("Ur animal is a nice camouflage");
                    break;
                case "black":
                    Console.WriteLine("Ur animal is a very op camouflage, black coloured animals are hard to spot in nature");
                    break;
                case "brown":
                    Console.WriteLine("Ur animal is a nice camouflage");
                    break;
                case "red":
                    Console.WriteLine("Ur animal looks very cool, it is red");
                    break;
                case "orange":
                    Console.WriteLine("If ur animal only comes out in sunset that would be unique because its orange");
                    break;
                case "yellow":
                    Console.WriteLine("If ur animal lived in a yellow field it would be very camouflaged");
                    break;
                case "lime":
                    Console.WriteLine("Ur animal is lime, its green but neon it would be spotted easily");
                    break;
                case "green":
                    Console.WriteLine("Ur animal is a nice camouflage");
                    break;
                case "cyan":
                    Console.WriteLine("Very few animals are blue ish, glad we have a new one");
                    break;
                case "blue":
                    Console.WriteLine("Very few animals are blue, glad we have a new one");
                    break;
                case "purple":
                    Console.WriteLine("If ur animal existed in the 19th century it'd maybe valueble for making purple flags");
                    break;
                case "magenta":
                    Console.WriteLine("ur animal colour is very easy to spot in nature");
                    break;
                case "pink":
                    Console.WriteLine("Ur animal is pink, most girls favourite colour");
                    break;
                default:
                    Console.WriteLine("Ur animal is "  + creature.Colour + " colour");
                    break;
            }

            Thread.Sleep(TimeSpan.FromMilliseconds(waitTime));
            //Food
            switch (creature.FavouriteFood)
            {
                case "duck":
                    Console.WriteLine("WHY, make ur animal eat something else, ducks are the best.");
                    break;
                case "ducks":
                    Console.WriteLine("WHY, make ur animal eat something else, ducks are the best.");
                    break;
                case "berry":
                    Console.WriteLine("Berries are good");
                    break;
                case "meat":
                    Console.WriteLine("Ur animal eats meat, basic");
                    break;
                case "bug":
                    Console.WriteLine("ur animal eats bugs, like most animals");
                    break;
                case "bugs":
                    Console.WriteLine("ur animal eats bugs, like most animals");
                    break;
                case "pizza":
                    Console.WriteLine("ur animal eats mainly pizza, he has good taste");
                    break;
                case "burger":
                    Console.WriteLine("ur animal is problaly american, it eats mainly burgers");
                    break;
                case "cheese":
                    Console.WriteLine("ur animal is problaly swiss, it eats mainly cheese");
                    break;
                case "bread":
                    Console.WriteLine("ur animal is problaly french, it eats mainly bread, oui oui");
                    break;
                case "vegetables":
                    Console.WriteLine("ur animal is vegan, good for us");
                    break;
                case "vegetable":
                    Console.WriteLine("ur animal is vegan, good for us");
                    break;
                default:
                    Console.WriteLine("Ur animal likes to eat " + creature.FavouriteFood);
                    break;
            }

            Thread.Sleep(TimeSpan.FromMilliseconds(waitTime));
            //Sound
            switch (creature.Sound)
            {
                case "quack":
                    Console.WriteLine("Ur animal makes the same sound as a duck");
                    break;
                case "meow":
                    Console.WriteLine("Ur animal makes the cat meow");
                    break;
                case "bark":
                    Console.WriteLine("Ur animal makes sound of a dog");
                    break;
                case "rawr":
                    Console.WriteLine("Ur animal makes a raaaawwwwrwrwwr");
                    break;
                case "buzz":
                    Console.WriteLine("buzzzszz, ur animal makes bee sounds");
                    break;
                case "moo":
                    Console.WriteLine("moo, ur animal makes cow sounds \nTylko jedno w głowie mam \nkoksu pięć gram \nodlecieć sam W krainę za");
                    break;
                case "squeak":
                    Console.WriteLine("Ur animal makes squeak squeak noises");
                    break;
                case "baa":
                    Console.WriteLine("BAAAAAAAAAAAAAAAAAAAAAH sound it makes");
                    break;
                default:
                    Console.WriteLine("Ur animal makes a " + creature.Sound + " sound");
                    break;
            }

            Thread.Sleep(TimeSpan.FromMilliseconds(waitTime));
            //IQ
            switch (creature.IQ)
            {
                case < -1:
                    Console.WriteLine("Ur animals IQ goes into minuses, is it in 4th dimension? :eyes:");
                    break;
                case < 1:
                    Console.WriteLine("Ur animal has very very low IQ of" + creature.IQ);
                    break;
                case < 5:
                    Console.WriteLine("Ur animal has very low IQ of " + creature.IQ);
                    break;
                case < 85:
                    Console.WriteLine("Ur animal has quite hight IQ of " + creature.IQ);
                    break;
                case < 115:
                    Console.WriteLine("Ur animal has the average IQ of a human, " + creature.IQ + " IQ");
                    break;
                case < 200:
                    Console.WriteLine("Ur animal is smarter then a human, " + creature.IQ + " IQ");
                    break;
                default:
                    Console.WriteLine("Ur animal is very intelligence, " + creature.IQ + " IQ");
                    break;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Ur welcome! :)");
            Thread.Sleep(TimeSpan.FromMilliseconds(waitTime + 500));
            Console.WriteLine("XD its probably bad");
            Environment.Exit(0);
        }
    }
}
