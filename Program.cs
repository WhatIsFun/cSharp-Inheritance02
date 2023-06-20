namespace cSharp_Override
{
    static class Program
    {
        static void Main(string[] args)
        {
            //Square sq = new Square(5);
            //Console.WriteLine("Area of the square = "+ sq.GetArea());

            
            //Dog dog = new Dog("A", 2, "Dog");
            //Cat cat = new Cat("B", 3, "Cat");
            //Camel camel = new Camel("C", 4, "Camel");
            //dog.makeSound();
            //camel.makeSound();
            //cat.makeSound();
            // Task 1: Animal Class
            Dog dog = new Dog();       //dog instance
            dog.makeNoise();
            dog.Eat();

            Cat cat = new Cat();       // cat instance
            cat.makeNoise();
            cat.Eat();

            // task 2: Shape Class
            Circle circle = new Circle(3);
            Console.WriteLine("The area of circle is {0}", circle.GetArea());
            Console.WriteLine("The perimeter of the circle is {0}", circle.GetPerimeser());

            Rectangle rectangle = new Rectangle(3,4);
            Console.WriteLine("The area of rectangle is {0}", rectangle.GetArea());
            Console.WriteLine("The perimeter of the rectangle is {0}", rectangle.GetPerimeser());


        }
    }
}