
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






































































