using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnimallClass
{
    internal class Animal
    {
        //objects of the animal class
        public string Animal_Type;
        public string colour;
        public float weight;
        public string gender;
        public Animal(string animal_type, string Colour, float Weight, string Gender )
        {
            Animal_Type = animal_type;
            colour = Colour;
            weight = Weight;
            gender = Gender;

        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            return $"Animal: {Animal_Type}\nColour: {colour}\nWeight: {weight} KG\nGender: {gender}\n--------------";
        }
    }
}







