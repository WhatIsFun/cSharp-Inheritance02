namespace cSharp_Override
{
    static class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(5);
            Console.WriteLine("Area of the square = "+ sq.GetArea());

            
            Dog dog = new Dog();
            Cat cat = new Cat();
            Camel camel = new Camel();
            dog.makeSound();
            camel.makeSound();
            cat.makeSound();
        }
    }
}