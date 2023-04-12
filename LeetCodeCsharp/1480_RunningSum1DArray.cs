// Running Sum of 1d Array
// https://leetcode.com/problems/running-sum-of-1d-array

public class Program1480
{
	public static void Test()
	{
		Program1480 p = new();

		int[] nums = new int[] { 1, 2, 3, 4 };
		Console.WriteLine($"For input array: [{string.Join(", ", nums)}] \n\r...Running Sum = [{string.Join(", ", p.RunningSum(nums))}]  \n\r");

		nums = new int[] { 1, 1, 1, 1, 1 };
		Console.WriteLine($"For input array: [{string.Join(", ", nums)}] \n\r...Running Sum = [{string.Join(", ", p.RunningSum(nums))}]  \n\r");

		nums = new int[] { 3, 1, 2, 10, 1 };
		Console.WriteLine($"For input array: [{string.Join(", ", nums)}] \n\r...Running Sum = [{string.Join(", ", p.RunningSum(nums))}]  \n\r");
	}

	public int[] RunningSum(int[] nums)
	{
		var lastNum = new Stack<int>();
		lastNum.Push(0);
		var runningSum = new List<int>();

		foreach (int num in nums)
		{
			int last = lastNum.Pop();
			runningSum.Add(num + last);
			lastNum.Push(num + last);
		}
		return runningSum.ToArray();
	}
}