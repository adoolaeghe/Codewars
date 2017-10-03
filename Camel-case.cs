using System;
public class Kata
{
  public static string ToCamelCase(string str)
  {
    string[] strArr = str.Split('-','_');
    for (int i = 1; i < strArr.Length; i++)
    {
        string word = strArr[i];
        string firstupper = word[0].ToString().ToUpper();
        strArr[i] = firstupper + word.Substring(1, word.Length - 1);
    }
    return String.Join("", strArr);
  }
}
