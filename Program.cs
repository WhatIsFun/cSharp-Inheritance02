namespace cSharp_Override
{
    static class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square(5);
            Console.WriteLine("Area of the square = "+ sq.GetArea());

            
            //Dog dog = new Dog("A", 2, "Dog");
            //Cat cat = new Cat("B", 3, "Cat");
            //Camel camel = new Camel("C", 4, "Camel");
            //dog.makeSound();
            //camel.makeSound();
            //cat.makeSound();
            Dog dog = new Dog();       //dog instance
            dog.makeNoise();
            dog.Eat();

            Cat cat = new Cat();       // cat instance
            cat.makeNoise();
            cat.Eat();
        }
    }
}