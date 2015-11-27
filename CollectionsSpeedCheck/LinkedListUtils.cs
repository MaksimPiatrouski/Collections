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
    class LinkedListUtils
    {
        const string message = "less than 00.001 seconds";
        static TimeSpan tsLL;
        static Stopwatch stopWatchLL = new Stopwatch();

        public static LinkedList<Temp> createLinkedList(int quantity)
        {
            LinkedList<Temp> testLL = new LinkedList<Temp>();
            for (int i = 0; i < quantity; i++)
            {
                var a = new Temp(i, i, i, i);
                testLL.AddLast(a);
            }
            return testLL;
        }

        public static void checkEmptyListAddSpeed(int quantity)
        {
            LinkedList<Temp> testLL = new LinkedList<Temp>();
            Console.WriteLine("Procesing (with LinkedList). Please wait... \n");
            stopWatchLL.Restart();

            for (int i = 0; i < quantity; i++)
            {
                var a = new Temp(i, i, i, i);
                testLL.AddLast(a);
            }
            stopWatchLL.Stop();
            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
               tsLL.Seconds, tsLL.Milliseconds);

            LinkedListUtils.printReportLL(elapsedTimeLL);
        }

        public static void checkListInsertAtMiddleSpeed(int quantity, int newQuantity)
        {
            
            int mid = quantity / 2;

            LinkedList<Temp> testLL = createLinkedList(quantity);
            Console.WriteLine("Procesing (with LinkedList). Please wait... \n");
            stopWatchLL.Restart();

            var curNode = testLL.First;
            for (var k = 0; k < mid; k++)
            {
                curNode = curNode.Next;
            }
            for (int i = 0; i < newQuantity; i++)
            {
                var a = new Temp(i, i, i, i);
                testLL.AddAfter(curNode, a);
            }

            stopWatchLL.Stop();
            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
               tsLL.Seconds, tsLL.Milliseconds);

            LinkedListUtils.printReportLL(elapsedTimeLL);
        }

        public static void checkListInsertAtBeginningSpeed(int quantity, int newQuantity)
        {
            LinkedList<Temp> testLL = createLinkedList(quantity);
            Console.WriteLine("Procesing (with LinkedList). Please wait... \n");
            stopWatchLL.Restart();
            var curNode = testLL.First;
            for (int i = 0; i < newQuantity; i++)
            {
                var a = new Temp(i, i, i, i);
                testLL.AddAfter(curNode, a);
            }

            stopWatchLL.Stop();

            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
                tsLL.Seconds, tsLL.Milliseconds);

            LinkedListUtils.printReportLL(elapsedTimeLL);
        }

        public static void listFindObjectSpeed(int quantity, int value)
        {
            LinkedList<Temp> testLL = createLinkedList(quantity);
            Console.WriteLine("Procesing (with LinkedList). Please wait... \n");
            stopWatchLL.Restart();

            foreach (Temp t in testLL)
            {
                if (t.i1 == value)
                {
                    var index = testLL.Find(t);
                    break;
                }
            }

            stopWatchLL.Stop();
            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
               tsLL.Seconds, tsLL.Milliseconds);

            LinkedListUtils.printReportLL(elapsedTimeLL);
        }


        public static void checkListDeleteLastSpeed(int quantity)
        { 
            LinkedList<Temp> testLL = createLinkedList(quantity);
            Console.WriteLine("Procesing (with LinkedList). Please wait... \n");
            stopWatchLL.Restart();
            testLL.RemoveLast();
            stopWatchLL.Stop();

            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
                 tsLL.Seconds, tsLL.Milliseconds);

            LinkedListUtils.printReportLL(elapsedTimeLL);
        }

        public static void checkListDeleteMidSpeed(int quantity)
        {
            int mid = quantity / 2;

            LinkedList<Temp> testLL = createLinkedList(quantity);
            Console.WriteLine("Procesing (with LinkedList). Please wait... \n");
            stopWatchLL.Restart();
            Temp objToRemove = testLL.ElementAt(mid);
            testLL.Remove(objToRemove);
            stopWatchLL.Stop();

            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
                tsLL.Seconds, tsLL.Milliseconds);
            LinkedListUtils.printReportLL(elapsedTimeLL);
        }

        public static void checkListDeleteFirstSpeed(int quantity)
        {
            LinkedList<Temp> testLL = createLinkedList(quantity);
            Console.WriteLine("Procesing (with LinkedList). Please wait... \n");
            stopWatchLL.Restart();
            testLL.RemoveFirst();
            stopWatchLL.Stop();

            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
                 tsLL.Seconds, tsLL.Milliseconds);
            LinkedListUtils.printReportLL(elapsedTimeLL);
        }

        public static void printReportLL(string elapsedTimeLL)
        {
            if (!elapsedTimeLL.Equals("00.000"))
            {
                Console.WriteLine("LinkedList: " + elapsedTimeLL + " seconds\n");
            }
            else
            {
                Console.WriteLine("LinkedList: " + message + "\n");
            }
        }
    }
}
