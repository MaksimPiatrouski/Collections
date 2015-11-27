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
    class ArrayListUtils
    {
        const string message = "less than 00.001 seconds";
        static TimeSpan tsAL;
        static Stopwatch stopWatchAL = new Stopwatch();

        public static ArrayList createArrayList(int quantity)
        {
            ArrayList testAL = new ArrayList();

            for (int i = 0; i < quantity; i++)
            {
                var a = new Temp(i, i, i, i);
                testAL.Add(a);
            }
            return testAL;
        }


        public static void checkEmptyListAddSpeed(int quantity)
        {
            ArrayList testAL = new ArrayList();
            Console.WriteLine("Procesing (with ArrayList). Please wait... \n");

            stopWatchAL.Restart();
            for (int i = 0; i < quantity; i++)
            {
                var a = new Temp(i, i, i, i);
                testAL.Add(a);
            }
            stopWatchAL.Stop();

            tsAL = stopWatchAL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            ArrayListUtils.printReportAL(elapsedTimeAL);
        }

        public static void checkListInsertAtMiddleSpeed(int quantity, int newQuantity)
        {
            int mid = quantity / 2;

            ArrayList testAL = createArrayList(quantity);
            Console.WriteLine("Procesing (with ArrayList). Please wait... \n");

            stopWatchAL.Restart();
            for (int i = 0; i < newQuantity; i++)
            {
                var a = new Temp(i, i, i, i);
                testAL.Insert(mid, a);
            }
            stopWatchAL.Stop();

            tsAL = stopWatchAL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            ArrayListUtils.printReportAL(elapsedTimeAL);
        }

        public static void checkListInsertAtBeginningSpeed(int quantity, int newQuantity)
        {
            ArrayList testAL = createArrayList(quantity);
            Console.WriteLine("Procesing (with ArrayList). Please wait... \n");

            stopWatchAL.Restart();
            for (int i = 0; i < newQuantity; i++)
            {
                var a = new Temp(i, i, i, i);
                testAL.Insert(i, a);
            }
            stopWatchAL.Stop();

            tsAL = stopWatchAL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            ArrayListUtils.printReportAL(elapsedTimeAL);
        }

        public static void listFindObjectSpeed(int quantity, int value)
        {
            ArrayList testAL = createArrayList(quantity);
            Console.WriteLine("Procesing (with ArrayList). Please wait... \n");

            stopWatchAL.Restart();
            foreach (Temp t in testAL)
            {
                if (t.i1 == value)
                {
                    var index = testAL.IndexOf(t);
                    break;
                }
            }
            stopWatchAL.Stop();

            tsAL = stopWatchAL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            ArrayListUtils.printReportAL(elapsedTimeAL);
        }

        public static void checkListDeleteLastSpeed(int quantity)
        {
            ArrayList testAL = createArrayList(quantity);
            Console.WriteLine("Procesing (with ArrayList). Please wait... \n");

            stopWatchAL.Restart();
            testAL.RemoveAt(testAL.Count - 1);
            stopWatchAL.Stop();

            tsAL = stopWatchAL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
            tsAL.Seconds, tsAL.Milliseconds);

            ArrayListUtils.printReportAL(elapsedTimeAL);
        }

        public static void checkListDeleteMidSpeed(int quantity)
        {
            int mid = quantity / 2;

            ArrayList testAL = createArrayList(quantity);
            Console.WriteLine("Procesing (with ArrayList). Please wait... \n");

            stopWatchAL.Restart();
            testAL.RemoveAt(mid);
            stopWatchAL.Stop();

            tsAL = stopWatchAL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            ArrayListUtils.printReportAL(elapsedTimeAL);
        }

        public static void checkListDeleteFirstSpeed(int quantity)
        {
            ArrayList testAL = createArrayList(quantity);
            Console.WriteLine("Procesing (with ArrayList). Please wait... \n");

            stopWatchAL.Restart();
            testAL.RemoveAt(0);
            stopWatchAL.Stop();

            tsAL = stopWatchAL.Elapsed;

            string elapsedTimeAL = String.Format("{0:00}.{1:000}",
              tsAL.Seconds, tsAL.Milliseconds);

            ArrayListUtils.printReportAL(elapsedTimeAL);
        }

        public static void printReportAL(string elapsedTimeAL)
        {
            if (!elapsedTimeAL.Equals("00.000"))
            {
                Console.WriteLine("ArrayList: " + elapsedTimeAL + " seconds\n");
            }
            else
            {
                Console.WriteLine("ArrayList: " + message + "\n");
            }
        }
    }
}
