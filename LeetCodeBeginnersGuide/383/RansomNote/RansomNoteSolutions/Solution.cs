namespace RansomNoteSolutions
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            Dictionary<char, int> ransomNoteCharacterOccurances = new Dictionary<char, int>();
            Dictionary<char, int> magazineCharacterOccurances = new Dictionary<char, int>();

            foreach (char c in ransomNote)
            {
                if (ransomNoteCharacterOccurances.ContainsKey(c))
                {
                    ransomNoteCharacterOccurances[c]++;
                }
                else
                {
                    ransomNoteCharacterOccurances.Add(c, 1);
                }
            }

            foreach (char c in magazine)
            {
                if (magazineCharacterOccurances.ContainsKey(c))
                {
                    magazineCharacterOccurances[c]++;
                }
                else
                {
                    magazineCharacterOccurances.Add(c, 1);
                }
            }

            //need to check if ransomNote can be constructed from letters in magazine

            foreach(char ransomKey in ransomNoteCharacterOccurances.Keys)
            {
                if (!magazineCharacterOccurances.ContainsKey(ransomKey)){
                    return false;
                }
            }

            foreach(var ransomEntry in ransomNoteCharacterOccurances)
            {
                char key = ransomEntry.Key;
                int count = ransomEntry.Value;

                if (magazineCharacterOccurances.TryGetValue(key, out int countMag))
                {
                    if (countMag < count)
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }
    }
}
