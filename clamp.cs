    // March 22 -2021 (14 years)
    // Project : Clamp a number

using System;
class HelloWorld {
  static void Main() {
    Console.WriteLine(Clamp(8,1,5));
  }
  
  static int Clamp(int value,int min,int max){
      if(value >= min && value <= max)
          return value;
      if(value < min)
          return min;
          return max;
  }
}
