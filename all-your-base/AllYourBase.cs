using System;
using System.Linq;
using System.Collections.Generic;

public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        int baseTen = 0;

        if(inputBase <= 1 || outputBase <= 1)
            throw new ArgumentException();
        if (!inputDigits.Any())
            return new int[] {0};
        if (inputDigits.Where(ch => ch < 0 || ch >= inputBase).Any())
            throw new ArgumentException();
        for(int i = 0; i < inputDigits.Length; i++) {
            baseTen += (int) Math.Pow(inputBase,i) * inputDigits[inputDigits.Length - i - 1];
        }
        Stack<int> newBaseDigits = new Stack<int>(); 
        while(baseTen > 0) {
            newBaseDigits.Push(baseTen % outputBase);
            baseTen /= outputBase;
        }
        if(newBaseDigits.Any(ch => ch != 0))
            return newBaseDigits.ToArray();
        return new int[] {0};
    }
}