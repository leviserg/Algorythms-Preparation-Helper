//Console.WriteLine("it works");
//Console.ReadKey();

using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using zConsole;
using zConsole.Codility_exercises;
using zConsole.Codility_exercises.ArrayMergeSortClassic;
using zConsole.Codility_exercises.DictionaryHashTable;
using zConsole.Codility_exercises.RecursionExamples;
using zConsole.Codility_exercises.Stack;
using zConsole.Codility_exercises.String;


/*
var convert = new PersonConverter();
var people = convert.ConvertFromJson("[ { Name: 'Sam', Salary: 15 } ]", "[{ Name: 'Bob', Salary: 5.50 }]");
foreach (var person in people)
{
    Console.WriteLine($"{person.GetType().Name}");
}
*/

int[] nums = new int[] { 0, 0, -1 };

Console.WriteLine(LongestConsecutiveSequence.LongestConsecutive(nums));


Console.ReadLine();



int[] RunningSum(int[] nums)
{
    int[] resultNums = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        if(i == 0)
        {
            resultNums[i] = nums[i];
        }
        else
        { 
            resultNums[i] = resultNums[i - 1] + nums[i];
        }
    }
    return resultNums;
}


string ArrayToString(int[] nums)
{
    StringBuilder sb = new StringBuilder("[");
    for (int i = 0; i < nums.Length; i++)
    {
        sb.Append($"{nums[i].ToString()},");
    }
    sb.Replace(",","]",sb.Length - 1,1);
    return sb.ToString();
}

int MajorityElement(int[] nums)
{
    Dictionary<int, int> dict = new Dictionary<int, int>();
    foreach(int number in nums)
    {
        if(!dict.TryGetValue(number, out int cnt))
        {
            dict[number] = 1;
        }
        else
        {
            dict[number]++;
        }
    }

    return dict.OrderByDescending(x => x.Value).First().Key;
    
}

int MaxProfit(int[] prices)
{
    int left = 0; // 0
    int right = prices.Length - 1; // 1
    int profit = 0;
    while (left < right)
    {
        if (prices[right] > prices[left])
        {
            profit = Math.Max(profit, prices[right] - prices[left]);
            left++;
        }
        else
        {
            profit = Math.Max(profit, prices[right] - prices[left]);
            right--;
        }
    }
    return profit;
}
bool IsSubsequence(string s, string t)
{
    string ss = s;
    for (int i = 0; i < s.Length; i++)
    {
        char c = s[i];
        if (t.Contains(c))
        {
            t = t.Remove(t.IndexOf(c), 1);
            ss = ss.Remove(i, 1);
        }
    }

    return ss.Length == 0;
}

void Rotate(int[] nums, int k)
{
    LinkedList<int> numsLL = new LinkedList<int>(nums);
    int arrLength = nums.Length;
    int t = (k < arrLength) ? k : k % arrLength;

    for (int i = 0; i < t; i++)
    {
        int valForFirst = nums[nums.Length - 1 - i];
        numsLL.AddFirst(valForFirst);
    }

    int[] temp = numsLL.ToList().Take(arrLength).Skip(0).ToArray();
    for (int i = 0; i < arrLength - 1; i++)
    {
        nums[i] = temp[i];
    }
}


public class PersonConverter
{
    public IEnumerable<Person> ConvertFromJson(string salariedPeople, string hourlyPeople)
    {
        // todo #1: Add a reference to Json.NET (Newtonsoft.Json) using NuGet
        // todo #2: Remove the Ignore attribute and make the tests pass
        // todo #3: Refactor so there is only one call to the Json.NET library and no loops

        //Person deserializedPerson JsonConvert.DeserializeObject<Person>(salariedPeople);

        char[] charsToTrim = { '[', ' ', ']' };

        string?[] arr = { salariedPeople.Trim(charsToTrim), hourlyPeople.Trim(charsToTrim) };

        //arr.ToList<String>().ForEach(i => Console.Write("{0}\t", i));

        //return JsonConvert.DeserializeObject<List<T>>(arr);

        //return JsonConvert.DeserializeObject<List<Person>>($"[{arr[0]},{arr[1]}]");

        List <Person> persons = new List<Person>{ 

            JsonConvert.DeserializeObject<SalariedEmployee>(arr[0]), 
            JsonConvert.DeserializeObject<HourlyEmployee>(arr[1])

        };
        return persons;

        //return null;//deserializedPerson;
    }
}

public class Person
{
    public string Name { get; set; }
}

public class SalariedEmployee : Person
{
    public decimal Salary { get; set; }
}

public class HourlyEmployee : Person
{
    public decimal RatePerHour { get; set; }
}
