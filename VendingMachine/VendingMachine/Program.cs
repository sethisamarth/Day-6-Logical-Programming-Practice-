using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter th eamount for which you want change");
            int amount = Convert.ToInt32(Console.ReadLine());
            int NoOfNotesOfThousand=0, NoOfNotesOfFiveHunred=0, NoOfNotesOfhundred=0, NoOfNotesOfFifty=0;
            int NoOfNotesOfTen = 0, NoOfNotesOfFive = 0, NoOfNotesOfTwo = 0, NoOfNotesOfOne = 0, minNoOfNotes = 0;

            while (amount > 1000)
            {
                amount = amount - 1000;
                NoOfNotesOfThousand++;
                minNoOfNotes++;
            }while (amount > 500)
            {
                amount = amount - 500;
                NoOfNotesOfFiveHunred++;
                minNoOfNotes++;
            }while (amount > 100)
            {
                amount = amount - 100;
                NoOfNotesOfhundred++;
                minNoOfNotes++;
            }while (amount > 50)
            {
                amount = amount - 50;
                NoOfNotesOfFifty++;
                minNoOfNotes++;
            }while (amount > 10)
            {
                amount = amount - 10;
                NoOfNotesOfTen++;
                minNoOfNotes++;
            }while (amount > 5)
            {
                amount = amount - 5;
                NoOfNotesOfFive++;
                minNoOfNotes++;
            }while (amount > 2)
            {
                amount = amount - 2;
                NoOfNotesOfTwo++;
                minNoOfNotes++;
            }while (amount > 1)
            {
                amount = amount - 1;
                NoOfNotesOfOne++;
                minNoOfNotes++;
            }

            Console.WriteLine("the list of notes");
            Console.WriteLine("1000 => {0}", NoOfNotesOfThousand);
            Console.WriteLine("500 => {0}", NoOfNotesOfFiveHunred);
            Console.WriteLine("100 => {0}", NoOfNotesOfhundred);
            Console.WriteLine("50 => {0}", NoOfNotesOfFifty);
            Console.WriteLine("10 => {0}", NoOfNotesOfTen);
            Console.WriteLine("2 => {0}", NoOfNotesOfTwo);
            Console.WriteLine("1 => {0}", NoOfNotesOfOne);
            Console.WriteLine("No. of minmum notes required is {0}", minNoOfNotes);
        }
    }
}
