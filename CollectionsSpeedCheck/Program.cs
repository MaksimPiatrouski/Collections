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
            int quantity;
            int newQuantity;
            int value;
            bool loop = true;
            while (loop)
            {
                Utils.printMenu();
                string menuSelector = Console.ReadLine();
                Console.Write("\n");

                switch (menuSelector)
                {
                    case "1":
                        quantity = Utils.setNewQuantity();
                        if (quantity != 0)
                        {
                            ArrayListUtils.checkEmptyListAddSpeed(quantity);
                            LinkedListUtils.checkEmptyListAddSpeed(quantity);
                        }
                        break;

                    case "2":
                        quantity = Utils.setQuantity();
                        newQuantity = Utils.setNewQuantity();
                        if (quantity != 0 && newQuantity != 0)
                        {
                            ArrayListUtils.checkListInsertAtMiddleSpeed(quantity, newQuantity);
                            LinkedListUtils.checkListInsertAtMiddleSpeed(quantity, newQuantity);
                        }

                        break;

                    case "3":
                        quantity = Utils.setQuantity();
                        newQuantity = Utils.setNewQuantity();
                        if (quantity != 0 && newQuantity != 0)
                        {
                            ArrayListUtils.checkListInsertAtBeginningSpeed(quantity, newQuantity);
                            LinkedListUtils.checkListInsertAtBeginningSpeed(quantity, newQuantity);
                        }
                        break;

                    case "4":
                        quantity = Utils.setQuantity();
                        value = Utils.setValue();
                        if (quantity != 0 && value != 0)
                        {
                            ArrayListUtils.listFindObjectSpeed(quantity, value);
                            LinkedListUtils.listFindObjectSpeed(quantity, value);
                        }
                        break;

                    case "5":

                        quantity = Utils.setQuantity();
                        if (quantity != 0)
                        {
                            ArrayListUtils.checkListDeleteLastSpeed(quantity);
                            LinkedListUtils.checkListDeleteLastSpeed(quantity);
                        }
                        break;

                    case "6":
                        quantity = Utils.setQuantity();
                        if (quantity != 0)
                        {
                            ArrayListUtils.checkListDeleteMidSpeed(quantity);
                            LinkedListUtils.checkListDeleteMidSpeed(quantity);
                        }
                        break;

                    case "7":
                        quantity = Utils.setQuantity();
                        if (quantity != 0)
                        {
                            ArrayListUtils.checkListDeleteFirstSpeed(quantity);
                            LinkedListUtils.checkListDeleteFirstSpeed(quantity);
                        }
                        break;

                    case "0":
                        loop = false;
                        break;

                    default:
                        Console.Write("Illegal input");
                        break;

                }
            }
        }
    }
}
