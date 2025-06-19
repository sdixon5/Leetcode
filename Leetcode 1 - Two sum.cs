public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        //this is not ideal as it is O(n^2)
        /*
        List<int> output = new List<int>();
        for(var i = 0; i < nums.Length; i++){
            for(var j = 1; j < nums.Length; j++){
                if(i != j && nums[i] + nums[j] == target){
                    output.Add(i);
                    output.Add(j);
                    return output.ToArray();
                }
            }
        }
        return output.ToArray();
        */
        
        //this is O(n)
        List<int> output = new List<int>();
        Dictionary<int, int> map = new Dictionary<int, int>();
        
        for(var i = 0; i < nums.Length; i++){
            if(!map.ContainsKey(nums[i])){
                map.Add(i, nums[i]);
            }
            
            int remaining = target - nums[i];
                        
            if (map.ContainsValue(remaining)){
                int key = map.FirstOrDefault(x => x.Value == remaining).Key;
                if(key != i){
                    output.Add(i);
                    output.Add(Array.IndexOf(nums, remaining));
                    return output.ToArray();
                }
            }
        }
        
        return output.ToArray();
    }
}