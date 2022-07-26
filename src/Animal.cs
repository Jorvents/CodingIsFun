using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingIsFun
{
    public class Animal
    {
        public string Name { get; set; }
        public int LegCount { get; set; }
        public int SizeCm { get; set; }
        public string Colour { get; set; } //Uses a api to get the colour name like  https://www.thecolorapi.com or somehow https://coolors.co/ffffff
        public string FavouriteFood { get; set; }
        public string Sound { get; set; } // Uses Console.Beep to replycate the sound AND A SEPERATE sound class that has 
        public int IQ { get; set; }
    }
}
