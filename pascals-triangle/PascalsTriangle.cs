using System;
using System.Collections.Generic;
using System.Linq;
public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        if (rows == 0)
            yield break;
        yield return new int[] {1};
        if(rows == 1)
            yield break;
        int[] PascalsTrianglePreviousRow = new int[] {1, 1};
        yield return PascalsTrianglePreviousRow;
        if(rows == 2)
            yield break;
        int cRow = 3;
        while(cRow <= rows) {
            int[] PascalsTriangleCurrentRow = new int[PascalsTrianglePreviousRow.Length + 1];
            PascalsTriangleCurrentRow[0] = 1;
            PascalsTriangleCurrentRow[PascalsTriangleCurrentRow.Length -1] = 1;
            for(int i = 1; i<PascalsTriangleCurrentRow.Length-1; i++) {
                PascalsTriangleCurrentRow[i] = PascalsTrianglePreviousRow[i-1] + PascalsTrianglePreviousRow[i]; 
            }
            yield return PascalsTriangleCurrentRow;
            cRow++;
            PascalsTrianglePreviousRow = PascalsTriangleCurrentRow;
        }
        yield break;
    }
}