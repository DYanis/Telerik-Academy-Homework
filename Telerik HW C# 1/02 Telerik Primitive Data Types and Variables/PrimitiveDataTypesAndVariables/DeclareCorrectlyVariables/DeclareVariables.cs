//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, 
//short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//byte, sbyte, short, ushort, int, uint, long, ulong

using System;

class DeclareVariables
{
    static void Main()
    {
        short SmallerNumber = -10000;       
        sbyte SmallNumber = -115;
        byte SmallestPositiveNumber = 97;
        ushort bigNumber = 52130;        
        long longNumber = 4825932;
    }
}

