using System;
namespace First{

  class Arrayy{
    public  void arrays(){

      // 1-D array 
      Console.WriteLine("try to learn array in c - sharp language ");
      int [] arr= [1,2,3,4,5];
      foreach(int i in arr){
      Console.WriteLine(i);
      }

     Console.WriteLine("print the 2-d dimensional array ");

     int [,] arr2={{2,3,4,5},{6,7,8,9}};
    
    for(int i=0;i<arr2.GetLength(0);i++){
      for(int j=0;j<arr2.GetLength(1);j++){
            Console.WriteLine(arr2[i,j]);
      }
    }


    }
  }
}