public class Solution {
    public IList<IList<int>> Generate(int numRows) {
        var triangle = new List<IList<int>>();

        for (int i = 0; i < numRows; i++) {
            var row = new List<int>();
            row.Add(1);  // First element is always 1

            for (int j = 1; j < i; j++) {
                int val = triangle[i - 1][j - 1] + triangle[i - 1][j];
                row.Add(val);
            }

            if (i > 0)
                row.Add(1);  // Last element is also 1 (except for first row)

            triangle.Add(row);
        }

        return triangle;
    }
}
