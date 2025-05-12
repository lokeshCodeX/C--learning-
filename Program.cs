// // See https://aka.ms/new-console-template for more information

// using System;

// namespace First
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("enter the number 1");
//             int num1= Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("enter the number 2");
//             int num2= Convert.ToInt32(Console.ReadLine());

//             Console.WriteLine("numbers after the swapping number");
//             int temp=num2;
//             num2=num1;
//             num1=temp;

//             Console.Write("number one is"+num1 + "number two is "+ num2);


//         }
//     }
// }


// using System;
// namespace First
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             int[,] arr = new int[4, 4];
//             for (int i = 0; i < 4; i++)
//             {
//                 for (int j = 0; j < 4; j++)
//                 {
//                     arr[i,j] = Convert.ToInt32(Console.ReadLine());
//                 }
//             }
//             for (int i = 0; i < 4; i++)
//             {
//                 for(int j=0;j<4;j++){
//                 Console.WriteLine(arr[i,j]);
//             }
//             }
//         }
//     }
// }


// try to prectise of encpsulation
// using System;

// namespace First
// {
//     class A
//     {
//         private int mobile;

//         public int GetMobile()
//         {
//             return mobile;
//         }

//         public void SetMobile(int mobile)
//         {
//             this.mobile = mobile;
//         }
//     }

//     class Program
//     {
//         int a;
//         string name;

//         public void Print(string name, int a)
//         {
//             Console.WriteLine("Name of the object: " + name + ", Age of the object: " + a);
//         }

//         static void Main(string[] args)
//         {
            
//             Console.WriteLine("Make object");

//             Program a = new Program();
//             a.Print("Lokesh", 23);

//             Console.WriteLine("Try to use getter/setter and the encapsulation concept:");
//             A obj = new A();
//             obj.SetMobile(5734872);
//             Console.WriteLine("Number of the object two: " + obj.GetMobile());
//         }
//     }
// }


using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Console.WriteLine("hello string");
        //    S obj=new S();
        //    obj.run();
        Arrayy arr=new Arrayy();
        arr.arrays();
        }
    }
}



