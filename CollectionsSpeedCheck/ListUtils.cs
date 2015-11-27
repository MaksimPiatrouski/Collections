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
    class ListUtils
    {
        const int quantity = 1000000;
        const int numOfNewObjects = 10000;
        const int mid = quantity / 2;
        const string message = "less than 00.001 seconds";
        static TimeSpan tsAL;
        static TimeSpan tsLL;
        static Stopwatch stopWatchAL = new Stopwatch();
        static Stopwatch stopWatchLL = new Stopwatch();

        public static ArrayList createArrayList()
        {
            ArrayList testAL = new ArrayList();
            for (int i = 0; i < quantity; i++)
            {
                var a = new Temp(i, i, i, i);
                testAL.Add(a);
            }
            return testAL;
        }

        public static LinkedList<Temp> createLinkedList()
        {
            LinkedList<Temp> testLL = new LinkedList<Temp>();
            for (int i = 0; i < quantity; i++)
            {
                var a = new Temp(i, i, i, i);
                testLL.AddLast(a);
            }
            return testLL;
        }

        public static void checkEmptyListAddSpeed()
        {
            ArrayList testAL = new ArrayList();
            LinkedList<Temp> testLL = new LinkedList<Temp>();
            stopWatchAL.Reset();
            stopWatchLL.Reset();

            stopWatchAL.Start();
            for (int i = 0; i < quantity; i++)
            {
                var a = new Temp(i, i, i, i);
                testAL.Add(a);
            }
            stopWatchAL.Stop();

            stopWatchLL.Start();

            for (int i = 0; i < quantity; i++)
            {
                var a = new Temp(i, i, i, i);
                testLL.AddLast(a);
            }
            stopWatchLL.Stop();
            tsAL = stopWatchAL.Elapsed;
            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
               tsLL.Seconds, tsLL.Milliseconds);

            ListUtils.printReportLists(elapsedTimeAL, elapsedTimeLL);
        }

        public static void checkListInsertAtMiddleSpeed()
        {
            ArrayList testAL = createArrayList();
            LinkedList<Temp> testLL = createLinkedList();

            stopWatchAL.Reset();
            stopWatchLL.Reset();

            stopWatchAL.Start();
            for (int i = 0; i < numOfNewObjects; i++)
            {
                var a = new Temp(i, i, i, i);
                testAL.Insert(mid + i, a);
            }
            stopWatchAL.Stop();

            stopWatchLL.Start();


            var curNode = testLL.First;
            for (var k = 0; k < mid; k++)
            {
                curNode = curNode.Next;
            }
            for (int i = 0; i < numOfNewObjects; i++)
            {
                var a = new Temp(i, i, i, i);
                testLL.AddAfter(curNode, a);
            }

            stopWatchLL.Stop();
            tsAL = stopWatchAL.Elapsed;
            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
               tsLL.Seconds, tsLL.Milliseconds);

            ListUtils.printReportLists(elapsedTimeAL, elapsedTimeLL);
        }

        public static void checkListInsertAtBeginningSpeed()
        {
            ArrayList testAL = createArrayList();
            LinkedList<Temp> testLL = createLinkedList();

            stopWatchAL.Reset();
            stopWatchLL.Reset();

            stopWatchAL.Start();
            for (int i = 0; i < numOfNewObjects; i++)
            {
                var a = new Temp(i, i, i, i);
                testAL.Insert(i, a);
            }
            stopWatchAL.Stop();

            stopWatchLL.Start();

            var curNode = testLL.First;
            for (int i = 0; i < numOfNewObjects; i++)
            {
                var a = new Temp(i, i, i, i);
                testLL.AddAfter(curNode, a);
            }

            stopWatchLL.Stop();
            tsAL = stopWatchAL.Elapsed;
            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
               tsLL.Seconds, tsLL.Milliseconds);

            ListUtils.printReportLists(elapsedTimeAL, elapsedTimeLL);
        }

        public static void listFindObjectSpeed()
        {
            ArrayList testAL = createArrayList();
            LinkedList<Temp> testLL = createLinkedList();

            stopWatchAL.Reset();
            stopWatchLL.Reset();

            stopWatchAL.Start();

            int value = 55555;
            int index = 0;
            foreach (Temp t in testAL)
            {
                if (t.i1 == value)
                {
                    index = testAL.IndexOf(t);
                    break;
                }
            }
            stopWatchAL.Stop();

            stopWatchLL.Start();

            foreach (Temp t in testLL)
            {
                if (t.i1 == value)
                {
                    index = testAL.IndexOf(t);
                    break;
                }
            }

            stopWatchLL.Stop();
            tsAL = stopWatchAL.Elapsed;
            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
               tsLL.Seconds, tsLL.Milliseconds);

            ListUtils.printReportLists(elapsedTimeAL, elapsedTimeLL);
        }


        public static void checkListDeleteLastSpeed()
        {
            ArrayList testAL = createArrayList();
            LinkedList<Temp> testLL = createLinkedList();
            stopWatchAL.Reset();
            stopWatchLL.Reset();

            stopWatchAL.Start();
            testAL.RemoveAt(testAL.Count - 1);
            stopWatchAL.Stop();

            stopWatchLL.Start();
            testLL.RemoveLast();
            stopWatchLL.Stop();

            tsAL = stopWatchAL.Elapsed;
            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
               tsLL.Seconds, tsLL.Milliseconds);

            ListUtils.printReportLists(elapsedTimeAL, elapsedTimeLL);
        }

        public static void checkListDeleteMidSpeed()
        {
            ArrayList testAL = createArrayList();
            LinkedList<Temp> testLL = createLinkedList();
            stopWatchAL.Reset();
            stopWatchLL.Reset();

            stopWatchAL.Start();
            testAL.RemoveAt(mid);
            stopWatchAL.Stop();

            stopWatchLL.Start();
            Temp objToRemove = testLL.ElementAt(mid);
            testLL.Remove(objToRemove);
            stopWatchLL.Stop();

            tsAL = stopWatchAL.Elapsed;
            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
               tsLL.Seconds, tsLL.Milliseconds);
            ListUtils.printReportLists(elapsedTimeAL, elapsedTimeLL);
        }

        public static void checkListDeleteFirstSpeed()
        {
            ArrayList testAL = createArrayList();
            LinkedList<Temp> testLL = createLinkedList();
            stopWatchAL.Reset();
            stopWatchLL.Reset();

            stopWatchAL.Start();
            testAL.RemoveAt(0);
            stopWatchAL.Stop();

            stopWatchLL.Start();
            testLL.RemoveFirst();
            stopWatchLL.Stop();

            tsAL = stopWatchAL.Elapsed;
            tsLL = stopWatchLL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            string elapsedTimeLL = String.Format("{0:00}.{1:000}",
               tsLL.Seconds, tsLL.Milliseconds);
            ListUtils.printReportLists(elapsedTimeAL, elapsedTimeLL);
        }

        public static void printReportLists(string elapsedTimeAL, string elapsedTimeLL)
        {
            if (!elapsedTimeAL.Equals("00.000"))
            {
                Console.WriteLine("ArrayList: " + elapsedTimeAL + " seconds");
            }
            else
            {
                Console.WriteLine("ArrayList: " + message);
            }
            if (!elapsedTimeLL.Equals("00.000"))
            {
                Console.WriteLine("LinkedList: " + elapsedTimeLL + " seconds");
            }
            else
            {
                Console.WriteLine("LinkedList: " + message);
            }
        }
    }
}
