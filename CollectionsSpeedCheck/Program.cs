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
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("1. ArrayList vs LinkedList\n"
                + "2. Stack vs Queue\n"
                + "3. HashTable vs Dictionary\n"
                + "0. Exit\n");
            string menuSelector = Console.ReadLine();
            switch (menuSelector)
            {
                case "1":
                    Console.Write("1. Add objects to the empty lists\n"
                    + "2. Add objects to the middle of the lists\n"
                    + "3. Add objects to the beginning of the lists\n"
                    + "4. Find object in the lists\n"
                    + "5. Delete element from the end of the list\n"
                    + "6. Delete element from the middle of the list\n"
                    + "7. Delete element from the beginning of the list\n"
                    + "0. Exit\n");

                    string menuListSelector = Console.ReadLine();
                    switch (menuListSelector)
                    {
                        case "1":
                            ListUtils.checkEmptyListAddSpeed();
                            break;
                        case "2":
                            ListUtils.checkListInsertAtMiddleSpeed();
                            break;
                        case "3":
                            ListUtils.checkListInsertAtBeginningSpeed();
                            break;
                        case "4":
                            ListUtils.listFindObjectSpeed();
                            break;
                        case "5":
                            ListUtils.checkListDeleteLastSpeed();
                            break;
                        case "6":
                            ListUtils.checkListDeleteMidSpeed();
                            break;
                        case "7":
                            ListUtils.checkListDeleteFirstSpeed();
                            break;
                    }
                    break;

                case "2":

                    Stopwatch stopWatchSt = new Stopwatch();
                    Stopwatch stopWatchQ = new Stopwatch();
                    break;

                case "3":

                    Stopwatch stopWatchHT = new Stopwatch();
                    Stopwatch stopWatchD = new Stopwatch();
                    break;

                case "0":
                    break;

                default:
                    Console.Write("Illegal input");
                    break;


            }
            Console.ReadKey();
            {
            }
        }
    }
}
