// LeetCode problem 724: Find Pivot Index
// https://leetcode.com/problems/find-pivot-index/

public class Program724
{
	public static void Test()
	{
		Console.WriteLine($"{instructions}");

		Program724 p = new();

		int[] nums = new int[] { 1, 7, 3, 6, 5, 6 };
		Console.WriteLine($"For input array: [{string.Join(", ", nums)}] \n\rThe Pivot Index is: [{p.PivotIndex(nums)}]  \n\r");

		nums = new int[] { 1, 2, 3 };
		Console.WriteLine($"For input array: [{string.Join(", ", nums)}] \n\rThe Pivot Index is: [{p.PivotIndex(nums)}]  \n\r");

		nums = new int[] { 2, 1, -1 };
		Console.WriteLine($"For input array: [{string.Join(", ", nums)}] \n\rThe Pivot Index is: [{p.PivotIndex(nums)}]  \n\r");
		Console.WriteLine($"That last one is tricky...\n\rOkay, 0 is the unseen VALUE on the left edge, \n\rwhile 0 is the INDEX of the VISIBLE value '2'. \n\rThen, 0 is the VALUE ( 1 + -1 = 0 ) for the right side's sum. \n\r\n\rTherefore, the sum values are [0 (unseen), 2, 0] and that means '2' is actually the pivot member, \n\rand 2 has an INDEX of 0 since it's the first visible member of the array\n\r\n\r");
	}

	public int PivotIndex(int[] nums)
	{
		int sum = 0;
		foreach (int num in nums)
		{
			sum = sum + num;
		}

		int start = 0, index;
		for (index = 0; index < nums.Length; index++)
		{
			sum = sum - nums[index];
			if (start == sum)
			{
				return index;
			}
			start = start + nums[index];
		}
		return -1;
	}

	private const string instructions = "INSTRUCTIONS: \r\n" +
		"Given an array of integers ('nums'), calculate the pivot index of this array.\r\n\r\n" +
		"The pivot index is the index where the sum of all the numbers strictly to the left of the index is equal to the sum of all the numbers strictly to the index's right.\r\n\r\n" +
		"If the index is on the left edge of the array, then the left sum is 0 because there are no elements to the left. This also applies to the right edge of the array.\r\n\r\n" +
		"Return the leftmost pivot index. If no such index exists, return -1.\r\n\r\n\r\n";
}