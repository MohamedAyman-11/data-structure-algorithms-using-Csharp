using System;

namespace ConsoleApp1
{
	public class Stack
	{
		private int Top;
		private int Size;
		private int []myStack;

		public Stack(int size)
		{
			if (size <= 0)
			{
				Size = 10;
			}
			else
			{
				Size = size;
			}
			Top = -1;
			myStack = new int[Size];
		}

		public bool IsEmpty()
		{
			return Top == -1;
		}		
		public bool IsFull()
		{
			return Top == Size - 1;
		}

		public void Push(int item)
		{
			if (IsFull())
			{
				Console.Write("Stack Is Full");
				return;
			};
			Top++;
			myStack[Top] = item;
		}
	public int Pop()
	{
		if (IsEmpty())
		{
			Console.WriteLine("Stack Is Empty");
			return -1;
		}

		int removedItem = myStack[Top];
		Top--;
		return removedItem;
	}
	}
}

