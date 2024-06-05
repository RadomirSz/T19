using System.Collections;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;


#region leet 1


// input [2,3,4,7,4] target 10
// int[] TwoSum(int[] nums, int target) 
// {
//     int[] output = new int[2];
//     for(int i = 0; i < nums.Length; i++)
//     {
//         for (int j = i+1; j < nums.Length; j++)
//         {
//             if(nums[j] + nums[i] == target)
//             {
//                 return new int[2]{i,j};
//             }
//         }
//     }
//     return output;  
// }

// int[] example = {2,4,5,7};
// int[] example2 = TwoSum(example, 9);
// foreach (var item in example2)
// {
//     Console.WriteLine(item);
// }


#endregion

#region leet 2
/*
public string LongestPalindrome(string s) {
    if(s.Length == 1) return s;
    int Lenght = 0;
    string Out = "";
    for (int i = 0; i < s.Length-1; i++)
    {
        string tempStr = "";
        for (int j = i; j < s.Length; j++)
        {
            tempStr += s[j];
            if(isPalindrome(tempStr) && tempStr.Length > Lenght)
            {
                Out = tempStr;
                Lenght = tempStr.Length;
            }
        }
        if(Lenght == s.Length) return s;
    }
    return Out;
}
public bool isPalindrome(string s)
{
    if(s == reverse(s)) return true;
    return false;
}
public string reverse(string s)
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
*/
/*
pypon
    def longestPalindrome(self, s):
        if(len(s) == 1): return s
        leng = 0
        out = ""
        for i in range(len(s)):
            temp = ""
            for j in range(i,len(s)):
                temp += s[j]
                if(temp == temp[::-1] and len(temp) > leng):
                    leng = len(temp)
                    out = temp
            if(leng == len(s)): return s
        return out
*/
#endregion

#region leet 3


// public int AppendCharacters(string s, string t) 
// {
//     if(WhatIsIn(s,t).Length == 0) return 0;
//     int slen = s.Length;
//     int whatwasin = t.Length - WhatIsIn(s,t).Length;

//     while(true)
//     {
//         t = WhatIsIn(s,t);
//         if(t!="") s += t[0];
//         else return s.Length - slen + whatwasin;
//     }
// }
// public string WhatIsIn(string s,string t)
// {
//     bool flag = false;
//     for (int i = 0; i < s.Length; i++)
//     {
//         if(s[i] != t[0] && flag) return t;
//         if(s[i] == t[0]){ t = t[1..]; flag = true;}
//         if(t == "") return t;
//     }
//     return t;
// }
//nie wiem no



#endregion

#region leet 4




// public int LongestPalindrome(string s) 
// {
//     int count = 0;
//     bool temp = false;
//     Dictionary<char,int> letters = new Dictionary<char,int>();
    
//     for (int i = 0; i < s.Length; i++)
//     {
//         if(letters.ContainsKey(s[i])) letters[s[i]]++;
//         else letters.Add(s[i], 1);
//     }
//     foreach (var item in letters)
//     {
//         if(item.Value % 2 == 0) count += item.Value;
//         else 
//         {
//             count += item.Value - 1;
//             temp = true;
//         }
//     }
//     if(temp) return count + 1;
//     return count;
// }




#endregion

#region leet 5

// public int ScoreOfString(string s) {
//     int sum = 0; 
//     for (int i = 0; i < s.Length - 1; i++)
//     {
//         sum += Math.Abs(s[i] - s[i + 1]);
//     }
//     return sum;
// }

#endregion


#region leet 6


// public IList<string> CommonChars(string[] words) 
// {
//     List<string> output = new List<string>();
//     bool flag = true;
//     foreach (var i in words[0])
//     {
//         foreach (var j in words)
//         {
//             if(!IsTheLetterInTheWord(i,j))
//             {
//                 flag = false;
//             }
//         }
//         if(flag) output.Add(Char.ToString(i));
//         else flag = true;
//     }
//     return output;
// }

// public bool IsTheLetterInTheWord(char l, string s)
// {
//     foreach(char i in s) if(i == l) return true;
//     return false;
// }
// jednak nie o to chodziło







#endregion























































