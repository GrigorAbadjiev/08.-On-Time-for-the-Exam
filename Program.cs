using System;

namespace _08._On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHours = int.Parse(Console.ReadLine());
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int examTotalMinutes = examHours * 60 + examMinutes;
            int arrivalTotalMinutes = arrivalHours * 60 + arrivalMinutes;

            if (arrivalTotalMinutes > examTotalMinutes)
            {
                Console.WriteLine("Late");
                int minutesDefference = arrivalTotalMinutes - examTotalMinutes;
                if (minutesDefference < 60)
                {
                    Console.WriteLine($"{minutesDefference} minutes after the start");
                }
                else
                {
                    int hours = minutesDefference / 60;
                    int minutes = minutesDefference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours after the start");
                }
            }
            else if (arrivalTotalMinutes < examTotalMinutes - 30) 
            {
                Console.WriteLine("Early");
                int minutesDefference = examTotalMinutes - arrivalTotalMinutes;
                if (minutesDefference < 60)
                {
                    Console.WriteLine($"{minutesDefference} minutes before the start");
                }
                else
                {
                    int hours = minutesDefference / 60;
                    int minutes = minutesDefference % 60;
                    Console.WriteLine($"{hours}:{minutes:d2} hours before the start");
                }
                
            }
            else
            {
                Console.WriteLine("On time");
                int minutesDefference = examTotalMinutes - arrivalTotalMinutes;
                Console.WriteLine($"{minutesDefference} minutes before the start");
            }


            
           
            
        }
    }
}
