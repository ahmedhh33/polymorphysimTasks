namespace Polymorphysim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("================ Task1 =================");
            Shape[] shapes = new Shape[]
            {
                new Circle(10),
                new Rectangle(10, 20),
                new Triangle(20, 10)
            };

            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("The area of shape {0} is {1}", i, shapes[i].CalculateArea());
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
            new FullTimeEmployee("Tomas Shilbi", 1100),
            new PartTimeEmployee("Hosamm Awwar", 1050)
        };

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Employee {i} has a bonus of OMR {employees[i].CalculateBonus()}");
            }
        }
    }
}