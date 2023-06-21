using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphysim
{
    internal abstract class Animal
    {
        public abstract void MakeSound();
    }
    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("AwAWAWAWWAW!");
        }
    }

    class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Meiaaaaow!");
        }
    }

    class Cow : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Ingoooh!");
        }
    }
}
