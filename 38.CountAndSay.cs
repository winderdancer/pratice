// https://leetcode.com/problems/count-and-say/description/

using System;
using System.Collections.Generic;

public class Test
{
    public static string CountAndSay(int n) {
      string finalString = "";
      for (int i = 1; i <= n ; i++)
      {
        if (i == 1)
        {
          finalString = "1";
        }
        else
        {
          finalString = ReadPreviousString(finalString);
        }
      }
      
      return finalString;
        
    }
  
    public static string ReadPreviousString(string s){
      string newReadString = "";
      int tempCount = 1;
      for (int i = 0; i < s.Length; i ++)
      {
        if (i == (s.Length -1) || s[i] != s[i+1])
        {
          newReadString += tempCount.ToString() + s [i];
          tempCount = 1;
        }
        else
        {
          tempCount += 1;
        }
        
      }
      
      return newReadString;
    }
      
  
  public static void Main()
  {
    Console.WriteLine(CountAndSay(3));
  }
}
