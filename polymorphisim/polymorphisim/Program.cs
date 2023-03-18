using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static polymorphisim.Program;

namespace polymorphisim
{
    internal class Program
    {
        public class A
        {
            public virtual void talk() {
                Console.Write("A\n" );
                walk();
                jump();
            }
            public virtual void walk() { Console.Write("A Walk"); }
            public virtual void jump() { Console.Write("A jump"); }
        }
        public class B :A
        {
            public override void jump()
            {
                Console.Write("B jump\n");
                walk();
            }
        }
        public class C : B {
            public override void walk()
            {
                Console.Write("C Walk\n");
            }
        }
        public class Animal
        {
            public virtual void move()
            {
                Console.WriteLine("Walking");
            }
        }
        public class Fish : Animal
        {
            public override void move ()
            {
                Console.WriteLine("Swims 2 feet");
            }
        }
        public class Frog : Animal 
        {
            public override void move()
            {
                Console.WriteLine("Jumps 5 feet.");
            }
        }
        public class Bird : Animal
        {
            public override void move() {
                Console.WriteLine("flies 10 feet.");
        }
        public class Cow : Animal { }
        public class Rabbit : Animal { }
    }
        static void Main(string[] args)
        {
            A a = new C();
            a.talk();

            Console.WriteLine("------------------------------------------------------");
        Animal A = new Animal();
        MoveAnimal(A);
        Animal Fish1 = new Fish();
        Console.WriteLine(Fish1 is Animal);
        MoveAnimal(Fish1);
        Animal Frog1 = new Frog();
        MoveAnimal(Frog1);
        Animal Bird1 = new Bird();
        MoveAnimal(Bird1);
        //Animal Cow1 = new Cow();
        //MoveAnimal(Cow1);
        Console.WriteLine("------------------");
        Animal[] Animals = new Animal[] { A, Fish1, Frog1, Bird1 };
        MoveAnimals(Animals);
    }
        public static void MoveAnimal(Animal A)
        {
            A.move();
        }
        public static void MoveAnimals(Animal[] As)
        {
            foreach (Animal A in As)
            {
                MoveAnimal(A);
            }
        }
    }
}

