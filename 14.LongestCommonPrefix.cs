// https://leetcode.com/problems/longest-common-prefix/description/

using System;

public class Test {
 public static string LongestCommonPrefix(string[] strs) {
  if (strs == null || strs.Length < 1) {
   return "";
  }


  string baseString = strs[0];

  if (strs.Length > 1) {
   for (int i = 1; i < strs.Length; i++) {
    // compare baseString with str[i]
    // extract the new baseString

    int baseStringLength = baseString.Length;
    int compareStringLength = strs[i].Length;
    int loopCharLength = baseStringLength >= compareStringLength ? compareStringLength : baseStringLength;
    baseString = baseString.Substring(0, loopCharLength);

    if (baseString == null || baseString.Length == 0) {
     return "";
    }

    for (int j = 0; j < loopCharLength; j++) {
     if (baseString[j] != strs[i][j]) {
      baseString = baseString.Substring(0, j);
      break;
     }
    }

    if (baseString == null || baseString.Length == 0) {
     return "";
    }

   }
  }

  return baseString;
 }

 public static void Main() {
  string[] weekDays = {
   "aaaa",
   "aaa"
  };
  //string[] weekDays = [];
  Console.WriteLine(LongestCommonPrefix(weekDays));
 }
}
