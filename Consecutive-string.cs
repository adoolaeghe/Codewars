using System;
public class LongestConsecutives
{
    public static string LongestConsec(string[] strarr, int k)
    {
        int n = strarr.Length;
        if(n == 0 || k > n || k <=0) return "";

        string longest = "";

        // it goes through each word moins le nombre consecutif parce que

        for(int i = 0; i < n-k+1; i++)
        {
            string str = "";
            // j = 0 but
            for(int j = i; j < k+i; j++)
            {
                str += strarr[j];
            }
            if(str.Length > longest.Length)
                longest = str;
        }

        return longest;
    }
}
