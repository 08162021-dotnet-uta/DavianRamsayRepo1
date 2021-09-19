using System;

namespace SweetnSaltyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring variables for the specific counters of the evaluated conditions of either Sweet and salty/ sweet/ salty
            int counterSnS =0;
            int sweet = 0;
            int salty = 0;


            //for loop created to loop from 1 to 1000
            for (int i = 1; i <= 1000; i++)
            {

               //if statement to evaluate if the numbers are divisible by 3 annd 5 print the word Sweet and salty
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.Write("sweet’nSalty ");
                    //saving the amount of times this condition was true and add it to the counter below to keep track
                    counterSnS++;
                }

                //if the numbers are a divisible by 3 then print sweet
                else if(i%3==0)
                    {
                    Console.Write("sweet ");
                    //saving the amount of times this condition was true and add it to the counter below to keep track
                    sweet++;
                    }

                //the the numbers are divisible by 5 print salty
                else if(i%5==0)
                {
                    Console.Write("salty ");
                    //saving the amount of times this condition was true and add it to the counter below to keep track
                    salty++;
                }

                //printing all the other numbers that do not fit the condtions above 
                else { Console.Write(i + " "); }


                //creatinf a line break at the end of the 10th value in the looped data
                if (i % 10 == 0)
                { Console.WriteLine(); }
          



            }
            //after all the conditions were totalled the sum is printed here 
            Console.WriteLine("\n\nTotal sweet’nSalty: " + counterSnS);
            Console.WriteLine("Total Sweet: "+sweet);
            Console.WriteLine("Total Salty: "+salty);
        }
    }//EOC
}//EON
