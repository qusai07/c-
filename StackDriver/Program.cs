using System;
namespace HandlingExceptions
{
    public class StackDriver
    {
        public static void Start()
        {
            Console.WriteLine("User-defined exception");
            IntStack intStack = new IntStack(3);
            try
            {
                intStack.Push(1);
                intStack.Push(2);
                intStack.Push(3);
                intStack.Push(4);
            }
            catch (StackOverflowException)
            {
                Console.WriteLine("Start: SOFE");
            }
        }
    }
    public class IntStack
    {
        private int Size;
        private int Current;
        private int[] Items;

        public IntStack(int Size)
        {
            this.Size = Size;
            this.Current = -1;
            this.Items = new int[Size];
        }
        public void Push(int Item)
        {
            try
            {
                this.Current++;
                this.Items[Current] = Item;
            }
            catch (IndexOutOfRangeException e)
            {
                throw new StackOverflowException("The stack is full :(");
            }
        }
    }

    public class StackOverFlowException : Exception
    {
        public StackOverFlowException(string Message) : base(Message)
        {

        }
    }
}
