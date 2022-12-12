using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_circular
{
    class Program
    {
        int FRONT, REAR, max = 5;
        int[] queue_array = new int[5];

        public Program()
        {
            /*initializing the values of the variables REAR and FRONT to -1 to indecate that the queues is initially empty*/
            FRONT = -1;
            REAR = -1;
        }
        public void insert(int element)
        {
            /*this statemenet checks for the overdlow condition*/
            if ((FRONT == 0 && REAR == max - 1) || (FRONT == REAR + 1))
            {
                Console.WriteLine("\nQueues overflow\n");
                return;
            }
            /* This following statement checks whether the queues is empty . if the queues is empty, then the values of the REAR and FRONT variables is tset to 0
             */
            if (FRONT == -1)
            {
                FRONT = 0;
                REAR = 0;
            }
            else
            {
                /*if REAR is at the last position of the array, then the values of REAR is set to 0 that corresponds to the first position of the array*/
                if (REAR == max - 1)
                    REAR = 0;
                else
                    /*if REAR is not at the last posotion, then its values is incremented by one*/
                    REAR = REAR + 1;
            }
            /*once the position of REAR is determined , the element is added at its proper place*/
            queue_array[REAR] = element;
        }
        public void remove()
        {
            /*checks wheather the queues is empty*/
            if (FRONT == -1)
            {
                Console.WriteLine("Queue underflow\n");
                return;
            }
            Console.WriteLine("\nThe Element Deleted From the queue is: " + queue_array[FRONT] + "\n");
            /*check if the queues has one element*/
            if (FRONT == REAR)
            {
                FRONT = -1;
                REAR = -1;
            }
            else
            {
                /*if the element to be deleted is at the last position of the array, then the value of FRONT is set to 0 i.e to the fitst element of the array. */
                if (FRONT == max - 1)
                    FRONT = 0;
                else
                    /* FRONT is incremented by one if it is not the first element of array*/
                    FRONT = FRONT + 1;

            }
        }
        public void display()
        {
            int FRONT_position = FRONT;
            int REAR_position = REAR;
            /*check if the queue is empty*/
            if (FRONT == -1)
            {
                Console.WriteLine("Queue is empty\n");
                return;
            }
            Console.WriteLine("\nElement in the queue are ..................\n");
            if (FRONT_position <= REAR_position)
            {
                /*Travenerse the queue till the last element present in an array*/
                while (FRONT_position <= REAR_position)
                {
                    Console.WriteLine(queue_array[FRONT_position] + "  ");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
            else
            {
                /*traverse the queue till the last positiion of the array*/
                while (FRONT_position <= max - 1)
                {
                    Console.Write(queue_array[FRONT_position] + "");
                    FRONT_position++;
                }
                /*set the FRONT position to the first element of the array*/
                FRONT_position = 0;
                /*traverse the array till the last element present in the queue*/
                while (FRONT_position <= REAR_position)
                {
                    Console.Write(queue_array[FRONT_position] + "");
                    FRONT_position++;
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program queue = new Program();
            char ch;
            while (true)
            {
                try
                {
                    Console.WriteLine("Menu");
                    Console.WriteLine("1. Implement insert Operations");
                    Console.WriteLine("2. Implement delete operation");
                    Console.WriteLine("3. Display values");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\nEnter your Choice (1-4): ");
                    ch = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine();
                    switch (ch)
                    {
                        case '1':
                            {
                                Console.Write("Enter the Number: ");
                                int num = Convert.ToInt32(System.Console.ReadLine());
                                Console.WriteLine();
                                queue.insert(num);
                            }
                            break;
                        case '2':
                            {
                                queue.remove();
                            }
                            break;
                        case '3':
                            {
                                queue.display();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid option !!");
                            }
                            break;

                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("check for the values entered");
                }
            }


        }
    }
}
/*repository error*/
