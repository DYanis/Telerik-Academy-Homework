using System;
using System.Linq;

class ReverseNumber
{
    public int RevertNumber(int number)
    {
        string numberStr = Convert.ToString(number);
        string reverseNumberStr = string.Empty;

        for (int i = numberStr.Length - 1; i >= 0; i--)
        {
            reverseNumberStr += numberStr[i];
        }

        int result = int.Parse(reverseNumberStr);
        return result;
    }
}
