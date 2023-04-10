// LeetCode problem 392: Is Subsequence
// https://leetcode.com/problems/is-subsequence/

public class Program392
{
	public static void Test()
	{
		Program392 p = new();

		//false test
		string s = "axc";
		string t = "ahbgdc";
		Console.WriteLine($"Is 's' [{s}] a subsequence of 't' [{t}]? \n\rDoes count=s.Length ({s.Length})? Should be FALSE: [{p.IsSubsequence(s, t)}] \n\r \n\r");

		//false test
		s = "acb";
		t = "ahbgdc";
		Console.WriteLine($"Is 's' [{s}] a subsequence of 't' [{t}]? \n\rDoes count=s.Length ({s.Length})? Should be FALSE: [{p.IsSubsequence(s, t)}] \n\r \n\r");

		//true test
		s = "abc";
		t = "ahbgdc";
		Console.WriteLine($"Is 's' [{s}] a subsequence of 't' [{t}]? \n\rDoes count=s.Length ({s.Length})? Should be TRUE: [{p.IsSubsequence(s, t)}] \n\r \n\r");

		//true test
		s = "";
		t = "ahbgdc";
		Console.WriteLine($"Is 's' [{s}] a subsequence of 't' [{t}]? \n\rDoes count=s.Length ({s.Length})? Should be TRUE: [{p.IsSubsequence(s, t)}] \n\r \n\r");

		//false test
		s = "b";
		t = "c";
		Console.WriteLine($"Is 's' [{s}] a subsequence of 't' [{t}]? \n\rDoes count=s.Length ({s.Length})? Should be FALSE: [{p.IsSubsequence(s, t)}] \n\r \n\r");

		//true test
		s = "abg";
		t = "ahbgd";
		Console.WriteLine($"Is 's' [{s}] a subsequence of 't' [{t}]? \n\rDoes count=s.Length ({s.Length})? Should be TRUE: [{p.IsSubsequence(s, t)}] \n\r \n\r");
	}

	public bool IsSubsequence(string s, string t)
	{
		int index = -1, count = 0;
		for (int i = 0; i < s.Length; i++)
		{
			for (int j = index + 1; j < t.Length; j++)
			{
				Console.WriteLine($"1 s[i]= {s[i]} i={i} | t[j]= {t[j]} j={j} index={index} count={count} \n\r");
				if (t[j] == s[i])
				{
					count++;
					index = j;
					Console.WriteLine($"2 s[i]= {s[i]} i={i} | t[j]= {t[j]} j={j} index={index} count={count} \n\r");
					break;
				}
			}
		}
		if (count == s.Length)
			return true;
		return false;
	}
}

// best c# solution found, attributed to 'aloneguy'
// https://leetcode.com/problems/is-subsequence/discuss/3331442/C-easy-solution.

// what to paste into leetcode
/*

public bool IsSubsequence(string s, string t)
{
	int index = -1, count = 0;
	for (int i = 0; i < s.Length; i++)
	{
		for (int j = index + 1; j < t.Length; j++)
		{
			if (t[j] == s[i])
			{
				count++;
				index = j;
				break;
			}
		}
	}
	if (count == s.Length)
		return true;
	return false;
}

 */