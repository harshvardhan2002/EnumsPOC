using EnumPOC.Enums;

namespace EnumPOC
{
    internal class Program
    {
        const int MINRANGE = 0;
        const int MAXRANGE = 6;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day it was yesterday (in form of 0-6 according to ascending order): ");
            int day=Convert.ToInt32(Console.ReadLine());

            if (day >= MINRANGE && day <= MAXRANGE)
            {
                int todayIndex = (day +1) % (MAXRANGE+1);
                DayType today = (DayType)todayIndex;
                Console.WriteLine("Today is: " + today);
                return;
            }
            Console.WriteLine("Enter valid number");
        }
    }
}
