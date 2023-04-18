Here is a C# console application that solves the problem:

```C#
using System;

class Program
{
    static void Main()
    {
        int[] nums = { 4, 5, 6, 7, 0, 1, 2 };
        int target = 0;

        int result = Search(nums, target);

        Console.WriteLine(result);
    }

    public static int Search(int[] nums, int target)
    {
        int start = 0, end = nums.Length - 1;
        while (start <= end)
        {
            int mid = (start + end) / 2;
            if (nums[mid] == target)
                return mid;
            else if (nums[mid] >= nums[start])
            {
                if (target >= nums[start] && target < nums[mid])
                    end = mid - 1;
                else
                    start = mid + 1;
            }
            else
            {
                if (target <= nums[end] && target > nums[mid])
                    start = mid + 1;
                else
                    end = mid - 1;
            }
        }
        return -1;
    }
}
```

This program uses a binary search algorithm to find the target in the rotated sorted array. The binary search is modified to work with the rotated array by checking if the mid element is greater than or equal to the start element. If it is, then the left half of the array is sorted and the target is checked within this half. If the mid element is less than the start element, then the right half of the array is sorted and the target is checked within this half. The search space is narrowed down until the target is found or the search space is empty.