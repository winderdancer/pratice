// 202 https://leetcode.com/problems/happy-number/description/

using System;
using System.Collections.Generic;

public class Test
{
    public static bool IsHappy(int n) {
      List<int> currentNumList = new List<int>{n};
      int currentNum = 0;
      while (n > 0 || (currentNum != 1 && !currentNumList.Contains(currentNum)))
      { 

        if (n == 0)
        {
          currentNumList.Add(currentNum);
          n = currentNum;
          currentNum = 0;
        }
        
        int digit = n % 10;
        currentNum = currentNum + digit * digit;

        n = n / 10;   
      }
      
      return (currentNum == 1);      
    }
  
  public static void Main()
  {
    Console.WriteLine(IsHappy(9));
  }
}
