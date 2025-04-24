

//namespace DotNet29Batch
//{
//    class SingalDelegate
//    {

//        // delegate (referance type):-1.delegate & method signature should be same . 2.delegate it is safe type pointer fuction . 3.it is nothing but pass method as a parameter.
//        //step to use delegate:-1.define delegate.2. Create object And assign . 3.invoking the delegate
//          // there are 2 types of Delegate:- single Class Delegate 2 Multi
//        // Singal class Delegate


//        public delegate void Print(string message); // define delegate

//        static void Main(string[] args)
//        {
//            Studnet st = new Studnet();

//            School sl = new School();

//            Print pt = new Print(st.Display);

//            Print pt1 = new Print(sl.Display1);


//            pt("Good Morning");
//            pt("Good Night");
//            pt("Good Day");


//            pt1("Hello i am from school");
//        }
//        public class Studnet
//        {
//            public void Display(string hello)
//            {
//                Console.WriteLine(hello);
//            }
//        }
//        public class School
//        {
//            public void Display1(string hello)
//            {
//                Console.WriteLine(hello);
//            }
//        }
//    }
//}

//---------------------------multicast Delegate-------------------------------------------------


//class MulticastDelegate

//    //multicast Delegate
//{
//    public delegate void Print(int x); // define delegate

//    static void Main(string[] args)
//    {
//        Studnet st = new Studnet();

//        Print pt = new Print(st.CircleArea);


//        pt += st.Display2;
//        pt += st.Display3;
//        pt += st.Display4;


//        pt.Invoke(2);

//    }
//    public class Studnet
//    {
//        public void CircleArea(int a)
//        {
//            Console.WriteLine(a *a* 3.14);
//        }
//        public void Display2(int a)
//        {
//            Console.WriteLine(a * 2);
//        }
//        public void Display3(int a)
//        {
//            Console.WriteLine(a * 3);
//        }
//        public void Display4(int a)
//        {
//            Console.WriteLine(a * 4);
//        }


//    }



//}

//-------------------------------Multicast with return Method---------------------------------


class MultiCastwithReturn

    //Multicast with return Method
{
    public delegate int Print(int x);    // define delegate

    static void Main(string[] args)
    {
        Student st = new Student();

        Print pt = new Print(st.Display1);

        pt += st.Display2;
        pt += st.Display3;
        pt += st.Display4;

        foreach (Print d in pt.GetInvocationList())
        {
            int i = d.Invoke(12);
            Console.WriteLine(i);
        }

    }
    public class Student
    {
        public int Display1(int a) { return a*2; }


        public int Display2(int a) { return a*3; }


        public int Display3(int a) { return a*4; }

        public int Display4(int a) { return a*5; }
    }
}










