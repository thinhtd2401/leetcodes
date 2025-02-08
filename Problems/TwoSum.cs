namespace leetcodes.Problems
{
    public class TwoSum
    {
        public int[] TwoSumFunc(int[] nums, int target)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (dict.ContainsKey(complement))
                {
                    return new int[] { dict[complement], i };
                }
                dict[nums[i]] = i;
            }
            return new int[] { };
        }
    }
}
