using System;
using System.Collections.Generic;


namespace AbstractClasses
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Abstract class");

            //Student S1 = new Student(1, "Mahmoud", "Hammad");
            Student S2 = new UndergraduateStudent(2, "Ahmad", "Saleh");
            S2.LetterGrade();
            Student S3 = new GraduateStudent(3, "Dana", "Rami");
            S3.LetterGrade();
        }
    }


    public abstract class Student
    {
        protected int ID;
        protected string Fname;
        protected string Lname;
        private List<int> Scores;

        public Student() //parameterless constructor
        {
            Console.WriteLine("Student()");
            this.Scores = new List<int>();
        }
        public Student(int ID, string Fname, string Lname)
        {
            Console.WriteLine("Custom Student()");
            this.ID = ID;
            this.Fname = Fname;
            this.Lname = Lname;
            this.Scores = new List<int>();
        }
        public virtual string FullName()
        {
            return string.Format("{0} {1}", this.Fname, this.Lname);
        }
        public void NewScore(int s)
        {
            this.Scores.Add(s);
        }
        public virtual int GetScore(int idx)
        {
            if (idx < 0 || idx >= this.Scores.Count)
            {
                throw new Exception("Not a valid index");
            }
            return this.Scores[idx];
        }
        public override bool Equals(object obj)
        {
            // Student that = (Student) obj; //this statement throws an exception
            //if the obj object is not a student

            Student that = obj as Student; //if obj is not a Student object, that will be null
            if (that == null)
            {
                return false;
            }
            //comparing between this and that
            return this.ID.Equals(that.ID) && this.Fname.Equals(that.Fname)
                && this.Lname.Equals(that.Lname);
        }
        public override string ToString()
        {
            //ID: Fname Lname
            return string.Format("{0}: {1}", this.ID, this.FullName());
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
            //return this.ID.GetHashCode() * this.Fname.GetHashCode() * this.Lname.GetHashCode();
        }
        public Student Copy() //shallow copy
        {
            Student S = (Student)this.MemberwiseClone();
            return S;
        }
        //abstract methods
        public abstract void LetterGrade();
    }

    public class UndergraduateStudent : Student
    {
        public UndergraduateStudent()
        {
            Console.WriteLine("UndergraduateStudent()");
        }
        public UndergraduateStudent(int ID, string Fname, string Lname)
            : base(ID, Fname, Lname)
        {
            Console.WriteLine("Custom UndergraduateStudent()");
            //this.ID = ID;
        }
        public override void LetterGrade()
        {
            Console.WriteLine("UndergraduateStudent letter grade!");
        }
    }

    public class GraduateStudent : Student
    {
        public string Thesis { get; set; }
        private string ReasonToChange;

        public GraduateStudent() : base(0, "None", "None")
        {
            Console.WriteLine("GraduateStudent()");
        }
        public GraduateStudent(int ID, string Fname, string Lname)
            : base(ID, Fname, Lname)
        {
            Console.WriteLine("Custom GraduateStudent()");
        }
        public string FullNameWithID()
        {
            //output: ID FullName{Fname Lname}
            string Result = string.Format("{0} {1}", this.ID, base.FullName());
            return Result;
        }
        //overloading: same name with different signatures
        public void ChangeThesis(string NewThesis)
        {
            Console.WriteLine("ChangeThesis(NewThesis)");
            this.Thesis = NewThesis;
        }
        public void ChangeThesis(string NewThesis, string Reason)
        {
            Console.WriteLine("ChangeThesis(NewThesis, Reason)");
            this.Thesis = NewThesis;
            this.ReasonToChange = Reason;
        }
        //Fullname: Lname, Fname
        public override string FullName()
        {
            return string.Format("{0}, {1}", this.Lname, this.Fname);
        }
        public sealed override int GetScore(int idx)
        {
            return base.GetScore(idx);
        }
        public override void LetterGrade()
        {
            Console.WriteLine("GraduateStudent letter grade!");
        }

    }
}
