using System;

namespace ConsoleApp1
{
	public class Queue
	{
		private int Rear;
		private int Front;
		private int Length;
		private int[] myQueue;
		private int Size;

		public Queue(int size)
		{
			if (size <= 0)
			{
				Size = 10;
			}
			else
			{
				Size = size;
			}

			myQueue = new int[Size];
			Rear = Size - 1;
			Front = 0;
			Length = 0;
		}

		public bool IsEmpty()
		{
			return Length == 0;
		}

		public bool IsFull()
		{
			return Length == Size;
		}

		public void Enqueue(int item)
		{
			if (IsFull())
			{
				Console.WriteLine("Queue Is Full");
			}
			else
			{
				Length++;
				Rear = (Rear + 1) % Size;
				myQueue[Rear] = item;
			}
		}

		public int Dequeue()
		{
			if (IsEmpty())
			{
				Console.WriteLine("Queue Is Empty");
				return -1;
			}

			Length--;
			int RemovedItem = myQueue[Front];
			Front = (Front + 1) % Size;
			return RemovedItem;
		}
	}
}

