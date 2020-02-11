using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A01_SA
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuBool = false;
            bool radiusBool = false;
            bool setRadius = false;

            int radius;

            do
            {
                try
                {
                    Console.WriteLine("Please Enter A Radius");

                    radius = Convert.ToInt32(Console.ReadLine());

                    if (radius <= 0)
                    {

                        Console.WriteLine("Please Enter A Radius");
                        radius = Convert.ToInt32(Console.ReadLine());


                    }
                    else if (radius > 0)
                    {


                        do
                        {
                            Console.WriteLine("1. Get Circle Radius");
                            Console.WriteLine("2. Change Circle Radius");
                            Console.WriteLine("3. Get Circle Circumference ");
                            Console.WriteLine("4. Get Circle Area");
                            Console.WriteLine("5. Exit");

                            string UserInput = Console.ReadLine();
                            Circle circle = new Circle(radius);

                            if (UserInput == "1")
                            {
                                Console.Clear();
                                Console.WriteLine("The Radius of Circle is: " + circle.GetRadius());

                            }
                            else if (UserInput == "2")
                            {
                                Console.Clear();
                                do
                                {
                                    Console.WriteLine("Please Enter A Radius");
                                    int newRadius = Convert.ToInt32(Console.ReadLine());

                                    circle.SetRadius(newRadius);
                                    Console.WriteLine($"The Radius of Circle is:{ circle.GetRadius()}");

                                } while (setRadius == false);



                            }
                            else if (UserInput == "3")
                            {
                                Console.Clear();
                                Console.WriteLine("The Circumference of Circle is: " + circle.GetCircumference());

                            }
                            else if (UserInput == "4")
                            {
                                Console.Clear();
                                Console.WriteLine("The Area of Circle is: " + circle.GetArea());

                            }
                            else if (UserInput == "5")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Wrong Input.. Please Try Again");
                            }

                        } while (menuBool == false);
                    }
                }
                catch (Exception ex)
                {
                    Console.Clear();
                    Console.WriteLine("Wrong Input..  Enter A Numric Value");
                }


            } while (radiusBool == false);








            Console.ReadKey();
        }
    }
}
