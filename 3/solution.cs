public class Solution {

    //my version
    public int LengthOfLongestSubstring(string s) {
    let longest = "";
    let current = "";
    let start = 0;

    for(let i = start; i < s.length; i++){
        if(i == start){
            current += s[i];
        }
        else if(!(current.contains(s[i]))){
            current += s[i];
        }
        else {
            if(current.length > longest.length){
                longest = current;
            }
            start++;
        }
    }

    return longest;
    }
}