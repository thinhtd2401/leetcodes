using leetcodes.Problems;

TwoSum twoSumAlgorithm = new TwoSum();
int[] nums = { 2, 7, 11, 15 };
int target = 9;
int[] result = twoSumAlgorithm.TwoSumFunc(nums, target);
Console.WriteLine($"[{result[0]}, {result[1]}]");