    // March 22 -2021 (14 years)
    // Project : Clamp a number

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine(Clamp(5,1,5));
  }
  
  static int Clamp(int value,int min,int max){
      if(value >= min && value <= max){
          return value;
      }else if(value < min){
          return min;
      }else{
          return max;
      }
  }
  
}
