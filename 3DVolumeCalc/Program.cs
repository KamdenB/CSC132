using System;

namespace _3DVolumeCalc
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("1. Cube");
            Console.WriteLine("2. Cylinder");
            Console.WriteLine("3. Sphere");
            Console.WriteLine("4. Pyramid");
            Console.WriteLine("5. Exit");
            Console.Write("Choose a shape: ");

            if(!double.TryParse(Console.ReadLine(), out double choice)){
                Console.WriteLine("Invalid input");
                return;
            }

            switch(choice){
                case 1:
                    Console.Write("Enter the length of the cube: ");
                    if(!double.TryParse(Console.ReadLine(), out double length)){
                        Console.WriteLine("Invalid input");
                        break;
                    }
                    Cube cube = new Cube(length);
                    Console.WriteLine("The volume of the cube is: {0:0.###}", cube.getVolume());
                    break;

                case 2:
                    Console.Write("Enter the radius of the cylinder: ");
                    if(!double.TryParse(Console.ReadLine(), out double radius)){
                        Console.WriteLine("Invalid input");
                        break;
                    }
                    Console.Write("Enter the height of the cylinder: ");
                    if(!double.TryParse(Console.ReadLine(), out double height)){
                        Console.WriteLine("Invalid input");
                        break;
                    }
                    Cylinder cylinder = new Cylinder(radius, height);
                    Console.WriteLine("The volume of the cylinder is: {0:0.###}", cylinder.getVolume());
                    break;

                case 3:
                    Console.Write("Enter the radius of the sphere: ");
                    if(!double.TryParse(Console.ReadLine(), out double sRadius)){
                        Console.WriteLine("Invalid input");
                        break;
                    }
                    Sphere sphere = new Sphere(sRadius);
                    Console.WriteLine("The volume of the sphere is: {0:0.###}", sphere.getVolume());
                    break;
                
                case 4:
                    Console.Write("Enter the length of the base: ");
                    if(!double.TryParse(Console.ReadLine(), out double bLength)){
                        Console.WriteLine("Invalid input");
                        break;
                    }
                    Console.Write("Enter the height of the pyramid: ");
                    if(!double.TryParse(Console.ReadLine(), out double height2)){
                        Console.WriteLine("Invalid input");
                        break;
                    }
                    Pyramid pyramid = new Pyramid(bLength, height2);
                    Console.WriteLine("The volume of the pyramid is: {0:0.###}", pyramid.getVolume());
                    break;

                case 5:
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    abstract class Shape
    {
        public abstract double getVolume();
    }

    class Cube : Shape
    {
        private double _side;
        public Cube(double n) => _side = n;
        public override double getVolume() => _side * _side * _side;

    }

    class Sphere : Shape
    {
        private double _radius;
        public Sphere(double rad) => _radius = rad;
        public override double getVolume() => (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
    }

    class Cylinder : Shape
    {
        private double _radius;
        private double _height;
        public Cylinder (double rad, double height)
        {
            _radius = rad;
            _height = height;
        }
        public override double getVolume() => Math.PI * _radius * _radius * _height;
    }

    class Pyramid : Shape 
    {
        private double _base;
        private double _height;
        public Pyramid(double pBase, double height)
        {
            _base = pBase;
            _height = height;
        }
        public override double getVolume() => (_base * _base * _height) / 3;
    }
}