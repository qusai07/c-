using System;
using System.Collections.Generic;
using static ConsoleApp7.Program.Learner;

namespace ConsoleApp7
{
    internal class Program
    {  public static car[] Createcare(int length)
        {
            car[] c = new car[length];

            return c;
        }
        public static void printcar(car[]caarray)
        {
            foreach(car e in caarray)
            {
                Console.Write($"{e}\n");
            }
            Console.WriteLine();
        }
        public class car
        {
            public string vin;
            public string Model;
            public car(string v, string m)
            {
                this.vin = v;
                this.Model = m;
            }
            public override string ToString()
            {
                return $"({vin}) ({Model})";
            }
        }
     
       public static string[] CreateStringArray(int length)
        {
            string[] array = new string[length];
            return array;
        }
        public static int [] CreateIntArray(int length)
        {
            int [] array = new int[length];
            return array;

        }
        public static void print(int[]intarray)
        {
            for (int i = 0; i < intarray.Length; i++)
            {
                Console.Write($"{intarray[i]} ");

            }
        }
        public static void poparray(int[] intarray)
        {
            Random rnd = new Random();
            for (int i = 0; i < intarray.Length; i++)
            {
                intarray[i] = rnd.Next(1,10);
              //  print(intarray);
            }
        }
        public static void printarr(string[] strarray)
        {
            foreach (string str in strarray)
            {
                Console.Write($"{str} ");
            }

        } public class Emplyee
        {
            public string a;
            public Emplyee(string a)
            {   this.a = a;     }
            public override string ToString()
            {   return $"{a}";     }
        }
        public class HI
        {
            private string name { get; set; }
            private string description { get; set; }
            private double gpa { get; set; }
            private int age { get; set; }
            public HI(string n, string d, double g,int a)
            { name = n; description = d;  gpa = g;age = a;  }
            public void print()
            { Console.WriteLine("Name: " + name + "\n" + "Age: " + age + "\n" + "GPA: " + gpa + "\n"); }
        }
         public static void MyByValue( Emplyee E)
            {
            E = new Emplyee("Amal");
            Console.WriteLine("Name: "+E);
            E.a = "QusaiTT";
            Console.WriteLine("Name: "+E);

        }
        public static void Myref(ref Emplyee E)
        {
            E = new Emplyee("Amal");
            Console.WriteLine("Name: "+E);            
            E.a = "ShadenOB";
            Console.WriteLine("Name: "+E);
        }
        public static void Myvalue1( int y)
        {
            Console.WriteLine($"Y={y}");
            y = 10;
            Console.WriteLine($"Y={y}");
        }
        public static void Myref1(ref int y)
        {
            Console.WriteLine($"Y={y}");
            y = 10;
            Console.WriteLine($"Y={y}");
        }
        public static void oo(out int y)
        {
            y = 10;
            Console.WriteLine($"Y={y}");
        }
        
        public static void printstring2D(string[,] Table)
        {
            for (int r = 0; r < Table.GetLength(0); r++)
            {
                for (int c = 0; c < Table.GetLength(1); c++)
                {
                    Console.Write($"{Table[r, c]} ");
                }
                Console.WriteLine();
            }
        }
  
        public static void printTable(int[,] Table)
        {
            Random ran = new Random();

            for (int r = 0; r < Table.GetLength(0); r++)
            {
                for (int c = 0; c < Table.GetLength(1); c++)
                {
                    Table[r, c] = ran.Next(10, 20);
                    Console.Write($"{Table[r, c]} ");
                }
                Console.WriteLine();
            }

        }
        public static int[,] createTable(int rows, int col)
        {
            int[,] Table = new int[rows, col];
            return Table;
        }
        public static string[,] createTableS(int rows, int col)
        {
            string[,] Table = new string[rows, col];
            return Table;
        }
    
        public class care
        {
            public string vin;
            public string model;
            public care(string vin, string model)
            {
                this.vin = vin;
                this.model = model;
            }
            public override string ToString()
            {
                return $"({vin} {model})";
            }
        }

        public static void printTablecar(car[,] Table)
        {
            for (int r = 0; r < Table.GetLength(0); r++)
            {
                for (int c = 0; c < Table.GetLength(1); c++)
                {
                    Console.Write($"{Table[r, c]} ");
                }
                Console.WriteLine();
            }
        }
        public static int [][]createIntJagged(int length)
        {
            int [][]IntJagged=new int[3][];
            return IntJagged;
        }
        public static void printJadeed(int[][] JaggedArray)
        {
            for (int i = 0; i < JaggedArray.GetLength(0); i++)
            {
                int []e= JaggedArray[i];
                for (int j = 0; j < e.Length; j++)
                {
                    Console.Write($"{e[j]} ");
                }
                Console.WriteLine();
            }
        }
        public static void printJadeedForeach(int[][] JaggedArray)
        {
            foreach (int[] e in JaggedArray)
            {
                foreach (int j in e)
                {
                    Console.Write($"{j} ");
                }
            Console.WriteLine();
            }
        }
            public static void popJaggedarray(int[][] JaggedArray)
        {
            for (int i = 0; i < JaggedArray.GetLength(0); i++)
            {
                JaggedArray[i] = new int[i + 2];
                for(int j = 0; j < JaggedArray[i].Length; j++)
                {
                    JaggedArray[i][j] = i + j;
                }
            }
        }
        public class Learner:IComparable<Learner>
        {
            public int ID;
            public string Name;
            public Learner(int ID, string Name)
            {
                this.ID = ID;
                this.Name = Name;
            }

            public int CompareTo(Learner other)
            {
                /*
                 * 1 Method 
                 * if(this.ID < other.ID)
                 * {
                 * return -1;
                 * }
                 * else if(this.ID == other.ID)
                 * {
                 * return 0;
                 * }
                 * return -1;
                 * 
                 * 2 method bests
                 */
                if(this.ID.Equals(other.ID))
                {
                    return this.Name.CompareTo(other.Name);
                }
                return this.ID.CompareTo(other.ID);
            }

            public override string ToString()
            {
                return $" {ID}  {Name}";  
            }
            public override int GetHashCode()
            {
                return this.ID.GetHashCode() * this.Name.GetHashCode();
            }
            public override bool Equals(object obj)
            {
                if (this == obj)
                    return true;
                Learner L= obj as Learner;
                if(L==null) 
                    return false;
                return this.ID.Equals(L.ID) && this.Name.Equals(L.Name);
            }
            public class LearnerComparer:IComparer<Learner>
            {
                public int Compare(Learner x, Learner y)
                {
                    return x.Name.CompareTo(y.Name);
                }

            }

        }
        public static void Main(string[] args)
            {
            Console.Write("------------------------------(1-D Array)------------------------------\n");
            Console.Write("----------Create Array and print with null value----------\n");
            int [] array = CreateIntArray(5); 
            print(array);
            Console.WriteLine();
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.Write("\n----------The same Array but With Random Number----------\n");
            poparray(array);
            print(array);
            Console.WriteLine();
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("\n----------String Array 1D----------");
            string [] stringarray = new string[] {"qusai","shaden","dodo","Saqeer"};
            printarr(stringarray);
            Console.WriteLine();
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.Write("\n----------Class with Object Array 1D----------\n");
            car[] cc = Createcare(3);
            car c1 = new car("1234", "Ford");
            car c2 = new car("5678", "MBW");
            cc[0] = c1;
            cc[1] = c2;
            cc[2] = new car("7415", "Honda");
            printcar(cc);
            Console.WriteLine();
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            Console.WriteLine("------------------------------(2D Array)------------------------------");
            Console.WriteLine("----------(2D-Array Number)----------");
                 createTable(3, 4);
                 int [ , ]inttable=new int [ 3, 4 ];
                 printTable(inttable);
            Console.WriteLine();
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("----------2D-Array String----------");
            string[,] stringtable = new string[,]
                {
                { "Qusai", "Shaden" } ,
                { "Saqer", "Dalia" } ,
                {"Amal","Basil" }
                };
            printstring2D(stringtable);
            Console.WriteLine("Length Array string: "+stringtable.Length);
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("\n----------2D Array with class & Object----------");
            car[,] c = new car[,]
              {
                 {new car ("132","Honda"),
                  new car ("465","Bmw"),
                  new car ("789","Ford")}
              };
                printTablecar(c);
            Console.WriteLine();
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("--------------------(Jagged Array) --> 1D Array of Array--------------------");
            int[][] IntJaggedArray = createIntJagged(3);
            popJaggedarray(IntJaggedArray);
            Console.WriteLine("Print With For Loop");
            printJadeed(IntJaggedArray);
            Console.WriteLine("Print With Foreach not For Loop But that is same");
            printJadeedForeach(IntJaggedArray);
            Console.WriteLine("The length of Jagged(1) = " + IntJaggedArray.Length);
            Console.WriteLine("The GetLength of Jagged(1) of index[0] = "+IntJaggedArray.GetLength(0));
            Console.WriteLine("Another method to create Jagged Array -BUT- Look the code ");
            int[][] Jagged2 = new int[][]
            {
                new int [] { 1, 2, 3 },
                new int [] { 4, 5, 6 },
                new int [] { 7, 8, 9 }
            };
            printJadeedForeach(Jagged2);
            Console.WriteLine("The length of Jagged(2) = "+Jagged2.Length);
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.Write("------------------------------(Call By Value & Call By Reference)------------------------------");
            int x = 5;
            int x1 = 4;
            Console.WriteLine("\n----------Call By out  value----------");
            Console.WriteLine($"X1={x1}");
            oo(out x1);
            Console.WriteLine($"X1={x1}");
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("\n----------Call By value---------- ");
            Console.WriteLine($"X={x}");
            Myvalue1(x);
            Console.WriteLine($"X={x}");
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("\n----------Call By Ref---------- ");
            Console.WriteLine($"X={x}");
            Myref1(ref x);
            Console.WriteLine($"X={x}");
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("\n----------Call by value for a referece Object----------");
            Emplyee E1 = new Emplyee("Qusai");
            Console.WriteLine("Name: "+E1);
            MyByValue(E1); 
            Console.WriteLine("Name: "+E1);
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("\n----------Call by ref for a referece Object----------");
            Emplyee E2 = new Emplyee("Shaden");
            Console.WriteLine("Name: "+E2);
            Myref(ref E2);
            Console.WriteLine("Name: "+E2);
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine();
            Console.WriteLine("----------Call by ref for a referece Object Example 2----------");
            Emplyee E3= new Emplyee("Saqeer");
            Console.WriteLine("Name: "+E3);
            Myref(ref E3);
            Console.WriteLine("Name: "+E3);
            //------------------------------------------------------------------------------------------------------------------------------------------------------------------//
            Console.WriteLine("\n------------------------------(Class With obj)------------------------------ ");
            HI h = new HI("qusai ", "dd", 88.2, 20);
            h.print();
            Console.WriteLine("\n------------------------------(Genrric List Data Collection)------------------------------ ");
            List<int> L = new List<int>();
            L.Add(100);
            L.Add(200);
            foreach (int e in L)
            {
                Console.WriteLine(e);
              
            }
            Console.WriteLine("----------We can print the List Such as Array cw(L[0]) or cw(L[1])----------");
            Console.WriteLine(L[0]);
            Console.WriteLine("-Print the count of List (L.Count)");
            Console.WriteLine($"Count = { L.Count} , Capacity = {L.Capacity}");
            Console.WriteLine("---------- List whith Object----------");
            List <Learner> learners= new List<Learner>();
            Learner learner1 = new Learner(1, "Qusai");
            Console.WriteLine("How to Add value in list-->learners.Add(learner1...)");
            learners.Add(learner1);
          
            Learner learner2 = new Learner(2, "Shaden");
            learners.Add(learner2);
            foreach (Learner e in learners)
            {
                Console.WriteLine($"{e} ");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("How to remove value in list -->learners.Remove(learner2...)");
            learners.Remove(learner2);
            foreach (Learner e in learners)
            {
                Console.WriteLine($"{e} ");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("How to check the List if Empty or have a value ---> lerners.Contains(learner1)");
            Console.WriteLine(learners.Contains(learner1));
            Console.WriteLine("--------------------");
            Console.WriteLine("--------------------(Generic Dictionary Data Collection)--------------------");
            Console.WriteLine("" +
                "keys\t\t    Values\n" +
                "K1 ----------------> V1\n" +
                "K2 ----------------> V2\n" +
                "K3 ----------------> V3" 
               );

            Dictionary<int , Learner> SsnLearnerMap = new Dictionary<int, Learner>();
            Learner L1 = new Learner(1, "Qusai");
            Learner L2 = new Learner(2, "Shaden");
            Learner L3 = new Learner(3, "Dalia");
            SsnLearnerMap.Add(1, L1);
            SsnLearnerMap.Add(2, L2);
            SsnLearnerMap.Add(3, L3);
            Console.WriteLine("--------------------");
            Console.WriteLine("Check IF SsnLearnerMap (ContainsKey) ");
            Console.WriteLine(SsnLearnerMap.ContainsKey(1));
            Console.WriteLine(SsnLearnerMap.ContainsKey(0));
            Console.WriteLine("--------------------Print Dictionary--------------------");
            foreach(KeyValuePair<int , Learner> e in SsnLearnerMap)
                {
                Console.WriteLine($"Key={e.Key} Value={e.Value}"); 
                }
            Console.WriteLine("--------------------SortedDictionary--------------------");
            Console.WriteLine("--------------------Print SortedDictionary--------------------");
            Console.WriteLine("--------------------CompareTo ID--------------------");
            SortedDictionary<Learner, int> SsnLearnerMap2 = new SortedDictionary<Learner,int>();
            SsnLearnerMap2.Add(L1,5);
            SsnLearnerMap2[L2] = 6;
            SsnLearnerMap2[L3] = 7;
            foreach(KeyValuePair<Learner , int> e in SsnLearnerMap2)
            {
                Console.WriteLine($"Key={e.Key} Value={e.Value}");
            }
            Console.WriteLine("////////Don't Forget Look the Code Line:(236 to 275)////////");
            Console.WriteLine("--------------------CompareTo Name--------------------");
            LearnerComparer learnerComparer = new LearnerComparer();
            SortedList<Learner,int> SsnLearnerMapByName = new SortedList<Learner,int>(learnerComparer);
            SsnLearnerMapByName.Add(L1, 5);
            SsnLearnerMapByName[L2] = 6;
            SsnLearnerMapByName[L3] = 7;
            foreach (KeyValuePair< Learner,int>e  in SsnLearnerMapByName)
            {
                Console.WriteLine($"Key={e.Key} Value={e.Value}");

            }
            Console.WriteLine("--------------------Stack Data Collection--------------------");
            Stack<Learner> stack = new Stack<Learner>();
            Console.WriteLine($"Count Befor Push Item = {stack.Count}");
            Console.WriteLine("print after add dirctly");
            stack.Push(L1);
            Console.WriteLine(stack.Peek());
            stack.Push(L2);
            Console.WriteLine(stack.Peek());
            stack.Push(L3);
            Console.WriteLine(stack.Peek());
            Console.WriteLine($"Count After Push 3 Items = {stack.Count}");
            Console.WriteLine("--------------------Print Stack--------------------");
            foreach (Learner e in stack)
            {
                Console.WriteLine($"{e.ID} {e.Name}");
            }
            Console.WriteLine($"--------------------After pop  Items--------------------");
            Console.WriteLine("Last push item First item pop");
            stack.Pop();
            foreach (Learner e in stack)
            {
                Console.WriteLine($"{e.ID} {e.Name}");
            }
            Console.WriteLine("------Contains Stack After Pop------");
            Learner L11=stack.Pop();
            Console.WriteLine(stack.Contains(L11));
            Console.WriteLine("--------------------Queue Data Collection--------------------");
            Queue<Learner> queue = new Queue<Learner>();
            Console.WriteLine( $"Queue Count Befor Enqueue= {queue.Count}");
            queue.Enqueue(L1);
            Console.WriteLine($"Peek = {queue.Peek()}");
            Console.WriteLine($"Queue Count After Enqueue= {queue.Count}");
            queue.Enqueue(L2);
            queue.Enqueue(L3);
            Console.WriteLine($"Peek = {queue.Peek()} Count = {queue.Count}");
            Console.WriteLine($"Dequeue = {queue.Dequeue()} Count = {queue.Count }");
            Console.WriteLine("--------------------LinkedList Data Collection--------------------");

            LinkedListNode < double >N1= new LinkedListNode<double>(1);
            LinkedListNode<double> N2 = new LinkedListNode<double>(2);
            LinkedListNode<double> N3 = new LinkedListNode<double>(3);
            LinkedList<double> LL = new LinkedList<double>();
            Console.WriteLine($"Count Befor Add = {LL.Count}");
            LL.AddFirst(N1);
            Console.WriteLine($"Count After Add = {LL.Count}");
            LL.AddLast(N2);
            LL.AddLast(N3);
            LinkedListNode<double> current = LL.First;
            while (current != null)
            {
                Console.Write($"{current.Value} ->");
                current = current.Next;
            }
            LinkedListNode<double> N4 = new LinkedListNode<double>(4);  
            LinkedListNode<double> N5 = new LinkedListNode<double>(5);
            LL.AddAfter(N4, N5);
            Console.WriteLine();
            current = LL.First;
            while(current != null)
            {
                Console.Write($"{current.Value}");
                current = current.Next; 
            }





        }
    }
    }
