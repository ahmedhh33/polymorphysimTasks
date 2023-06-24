
namespace Polymorphysim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ Task1 =================");
            Shape[] shapes = new Shape[]
            {
                new Circle("Circle",10),
                new Rectangle("Rectangle",10, 20),
                new Triangle("Triangle",20, 10)
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine($"The area of shape {shapes[i].Name} {shapes[i].CalculateArea()}");
            }

            Console.WriteLine("================ Task2 =================");

            Animal[] animals = new Animal[]
            {
                new Dog(),new Cat(), new Cow()
            };
            for (int i = 0;i < animals.Length;i++)
            {
                Console.Write($"The sound of Animal {i} is ");
                animals[i].MakeSound();
            }
            Console.WriteLine();

            Console.WriteLine("================ Task3 =================");

            Employee[] employees = new Employee[]
            {
            new FullTimeEmployee("Tomas Shilbi", 1100),new PartTimeEmployee("Hosamm Awwar", 1050)
            };

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Employee {i} has a bonus of OMR {employees[i].CalculateBonus()}");
            }

            Console.WriteLine("================ Task4 =================");

            //I did A shape clas and its derevitive before so i just will colling it
            List<Shape> shapes1 = new List<Shape>()
            {
                new Circle("Circle",10),new Rectangle("Rectangle",10,20), new Triangle("Triangle",20,10)
            };

            var sortedshapes = shapes1.OrderBy(shape => shape.CalculateArea());
            //for (int i = 0;i<shapes.Length;i++)
            //{
            //    Console.WriteLine(vs);
            //}
            foreach (var shape in sortedshapes)
            {
                Console.WriteLine(shape.Name +" " + shape.CalculateArea());
            }

            Console.WriteLine("================ Task5 =================");

            BankAccount bankAccount = new SavingsAccount(24354653,2350.346,1060);
            bankAccount.Withdraw(500);
            BankAccount bankAccount1 = new CheckingAccount(24354653, 2350.346);
            bankAccount1.Withdraw(670);

            Console.WriteLine("================ TasSpecial Task6 =================");

            List<Students> students = new List<Students>() {
                new Students("Ahmed Al-Aamri",24),
                new Students("Salim Al-Fazari",23),
                new Students("Muthir Al-Burtamani",23),
                new Students("Hamood Al-Jahhafi",25),
                new Students("Khalid Al-Aamri",24)
            };

            students.Sort();//sort basing on alphabit

            foreach(Students sortedstudents in students)
            {
                Console.WriteLine($"student Name {sortedstudents.Name} his Age {sortedstudents.Age}");
            }
        }
    }
}