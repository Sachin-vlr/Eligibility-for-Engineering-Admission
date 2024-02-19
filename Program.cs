using System;
    class Eligibility
    {
        static void Main(string[] args)
        {
           int maths,physics,chemistry;

           Console.Write("Enter Math Marks");
           maths=Convert.ToInt32(Console.ReadLine());

           Console.Write("Enter Physics Marks");
           physics=Convert.ToInt32(Console.ReadLine());

           Console.Write("Enter Chemistry Marks");
           chemistry=Convert.ToInt32(Console.ReadLine());

           int totalmarks=maths+physics+chemistry;

           if(maths>=65 && physics>=55 && chemistry>=50)
           {
            if(totalmarks>=180 || maths+physics>=140)
            {
                Console.WriteLine("Congrats you are eligible for admission");
            }
            else
            {
                Console.WriteLine("Sorry you are not eligible for admission");
            }
           }



        }
    }

