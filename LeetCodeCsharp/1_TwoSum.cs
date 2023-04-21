// Two Sum
// https://leetcode.com/problems/two-sum/

public class Program1
{
	public static void Test()
	{
		Program1 p = new();

		Console.WriteLine($"{instructions}");

		int[] nums = new int[] { 2, 7, 11, 15 };
		int target = 9;
		Console.WriteLine($"For input array 'nums' = [{string.Join(", ", nums)}] and 'target' = {target} ... \n\r" +
			$"the 2 indices of 'nums' where values sum to 'target' are: [{string.Join(", ", p.TwoSum(nums, target))}]  \n\r" +
			$" => Correct answer is: [0,1] \n\r\n\r");

		nums = new int[] { 3, 2, 4 };
		target = 6;
		Console.WriteLine($"For input array 'nums' = [{string.Join(", ", nums)}] and 'target' = {target} ... \n\r" +
			$"the 2 indices of 'nums' where values sum to 'target' are: [{string.Join(", ", p.TwoSum(nums, target))}] \n\r" +
			$" => Correct answer is: [1,2]) \n\r\n\r");

		nums = new int[] { 3, 3 };
		target = 6;
		Console.WriteLine($"For input array 'nums' = [{string.Join(", ", nums)}] and 'target' = {target} ... \n\r" +
			$"the 2 indices of 'nums' where values sum to 'target' are: [{string.Join(", ", p.TwoSum(nums, target))}] \n\r" +
			$" => Correct answer is: [0,1])\n\r\n\r");
	}

	public int[] TwoSum(int[] nums, int target)
	{
		int val1, val2, i1, i2;
		List<int> twoSum = new();

		for (i1 = 0; i1 < nums.Length; i1++)
		{
			val1 = nums[i1];

			for (i2 = i1 + 1; i2 < nums.Length; i2++)
			{
				val2 = nums[i2];

				if (target - val1 == val2)
				{
					twoSum.Add(i1);
					twoSum.Add(i2);
					return twoSum.ToArray();
				}
			}
		}
		return twoSum.ToArray();
	}

	private const string instructions = "INSTRUCTIONS: \r\n" +
		$"Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target. \n\r\n\r" +
		$"You may assume that each input would have exactly one solution, and you may not use the same element twice. \n\r\n\r" +
		$"You can return the answer in any order. \n\r\n\r";
}