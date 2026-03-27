using System;


namespace ConsoleApp1
{
    class ArrayFunctions
    
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 10, 20, 30, 40, 50 };
            
            // InsertAtSpecificLocation
            int[] InsertAt(int[] arr, int index, int value)
            {
                if (index < 0 || index > arr.Length)
                {
                    Console.WriteLine("Invalid Position");
                    return arr;
                };
                int[]newArray =new int[arr.Length+1];
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = arr[i];
                }
            
                newArray[index] = value;
                for (int i = index; i < arr.Length; i++)
                {
                    newArray[i + 1] = arr[i];
                }
            
                return newArray;
            }
            int[] newArray1 = InsertAt(myArray, 1, 100);
            foreach (var VARIABLE in newArray1)
            {
                Console.WriteLine(VARIABLE);
            }
    
            
            // Insert At Start
            int[] InsertAtStart(int[] arr, int value)
            {
                int[] newArray = new int[arr.Length+1];
                newArray[0] = value;
                for (int i = 0; i < arr.Length; i++)
                {
                    newArray[i + 1] = arr[i];
                }
            
                return newArray;
            }  
            int[] newArray2 = InsertAtStart(myArray, 100);
            foreach (var VARIABLE in newArray2)
            {
                Console.WriteLine(VARIABLE);
            } 
            
            
            //Insert At End
            int[] InsertAtEnd(int[] arr, int value)
            {
                int[] newArray = new int[arr.Length+1];
                newArray[arr.Length] = value;
                for (int i = 0; i < arr.Length; i++)
                {
                    newArray[i] = arr[i];
                }
            
                return newArray;
            }
            
            
            int[] newArray3 = InsertAtEnd(myArray, 100);
            foreach (var VARIABLE in newArray3)
            {
                Console.WriteLine(VARIABLE);
            }
            
            
            // Delete Form Start

            int[] DeleteFromStart(int[] arry)
            {
                int[] newArray = new int[arry.Length - 1];
                for (int i = 1; i < arry.Length; i++)
                {
                    newArray[i-1] = arry[i];
                }
            
                return newArray;
            }
            int[] newArray4 = DeleteFromStart(myArray);
            foreach (var VARIABLE in newArray4)
            {
                Console.WriteLine(VARIABLE);
            }   
            
            
            // Delete Form End
            int[] DeleteFromEnd(int[] arry)
            {
                int[] newArray = new int[arry.Length - 1];
                for (int i = 0; i < arry.Length-1; i++)
                {
                    newArray[i] = arry[i];
                }
            
                return newArray;
            }
            int[] newArray5 = DeleteFromEnd(myArray);
            foreach (var VARIABLE in newArray5)
            {
                Console.WriteLine(VARIABLE);
            }     
            
            
            // Delete From Specific Location
            int[] DeleteForm(int[] array, int index)
            {
                if (index >= array.Length || index < 0)
                {
                    Console.WriteLine("Invalid Position!!!");
                    return array;
                }
            
                int[] newArray = new int [array.Length - 1];
                for (int i = 0; i < index; i++)
                {
                    newArray[i] = array[i];
                }
            
                for (int i = index; i < array.Length-1; i++)
                {
                    newArray[i] = array[i + 1];
                }
            
                return newArray;
            }
            
            int[] newArray6 = DeleteForm(myArray, 3);
            foreach (var VARIABLE in newArray6)
            {
                Console.WriteLine(VARIABLE);
            }
            
            
            // Array Traversing
            foreach (var VARIABLE in myArray)
            {
                Console.WriteLine(VARIABLE);
            }
            
            
            //  Array Update
            int[] UpdateArray (int[] array, int value, int index)
            {
                if (index >= array.Length || index < 0)
                {
                    Console.WriteLine("Invalid Position !!");
                    return array;
                }
            
                int[] newArray = new int[array.Length];
                newArray = array;
                newArray[index] = value;
                return newArray;
            }
            
            int[] newArray7 = UpdateArray(myArray, 100, myArray.Length - 1);
            foreach (var VARIABLE in newArray7)
            {
                Console.WriteLine(VARIABLE);
            }
            
            
            // Array Sequential Search
            int SequentialSearch(int[] array, int value)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    return array[i] == value ? 1 : -1;
                }
            
                return 0;
            }
            Console.WriteLine(SequentialSearch(myArray,10));

            
            // Stack
            Stack stack = new Stack(2);
            stack.Push(10);
            stack.Push(20);
            Console.WriteLine(stack.Pop());
            Console.WriteLine("Stack######################Stack");
            Console.WriteLine(stack.IsEmpty());
            Console.WriteLine(stack.IsFull()); 
            
            //Queue
            Queue queue = new Queue(2);
            queue.Enqueue(10);
            queue.Enqueue(20);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("Queue######################Queue");
            Console.WriteLine(queue.IsEmpty());
            Console.WriteLine(queue.IsFull());

        }
    }
};

