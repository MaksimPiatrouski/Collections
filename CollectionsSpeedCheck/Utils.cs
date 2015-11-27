using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CollectionsSpeedCheck
{
    class Utils
    {
        public static void printMenu()
        {
            Console.WriteLine("----------------------Menu----------------------\n"
                + "1. Add objects to the empty lists\n"
                   + "2. Add objects to the middle of lists\n"
                   + "3. Add objects to beginning of lists\n"
                   + "4. Find object in the lists\n"
                   + "5. Delete element from the end of lists\n"
                   + "6. Delete element from the middle of lists\n"
                   + "7. Delete element from the beginning of lists\n"
                   + "0. Exit\n"
                   + "-------------------------------------------------");
        }
        public static int setQuantity()
        {
            int quantity = 0;
            Console.Write("Enter the number of elements to create in the lists (int): ");
            try
            {
                quantity = int.Parse(Console.ReadLine());
                Console.Write("\n");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Illegal input. Number expcted (" + e.Message + ")\n");
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Illegal input. Too big number entered. Int expected (" + e.Message + ")\n");
            }
            return quantity;
        }

        public static int setNewQuantity()
        {
            int newQuantity = 0;
            Console.Write("Enter the number of elements to add to the lists (int): ");
            try
            {
                newQuantity = int.Parse(Console.ReadLine());
                Console.Write("\n");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Illegal input. Number expcted (" + e.Message + ")\n");
            }

            catch (OverflowException e)
            {
                Console.WriteLine("Illegal input. Too big number entered. Int expected (" + e.Message + ")\n");
            }
            return newQuantity;
        }

        public static int setValue()
        {
            int value = 0;
            Console.Write("Enter the value (number less than quantity of objects): ");
            try
            {
                value = int.Parse(Console.ReadLine());
                Console.Write("\n");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Illegal input. Number expcted (" + e.Message + ")\n");
            }

            catch (OverflowException e)
            {
                Console.WriteLine("Illegal input. Too big number entered. Int expected (" + e.Message + ")\n");
            }
            return value;
        }

    }
}

