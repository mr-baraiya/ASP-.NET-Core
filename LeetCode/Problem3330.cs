public class Solution {
    public int PossibleStringCount(string word) {
        if (word.Length == 1)
            return 1;

        int count = 1;
        for (int i = 0; i < word.Length - 1; i++) {
            if (word[i] == word[i + 1]) {
                count++;
            }
        }
        return count;
    }
}
