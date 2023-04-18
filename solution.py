Here is a Python console application that solves the problem:

```python
def search(nums, target):
    if not nums:
        return -1

    low, high = 0, len(nums) - 1

    while low <= high:
        mid = (low + high) // 2
        if nums[mid] == target:
            return mid

        if nums[low] <= nums[mid]:
            if nums[low] <= target <= nums[mid]:
                high = mid - 1
            else:
                low = mid + 1
        else:
            if nums[mid] <= target <= nums[high]:
                low = mid + 1
            else:
                high = mid - 1

    return -1

def main():
    nums = list(map(int, input("Enter numbers separated by space: ").split()))
    target = int(input("Enter target number: "))
    result = search(nums, target)
    if result != -1:
        print("Element is present at index %d" % result)
    else:
        print("Element is not present in array")

if __name__ == "__main__":
    main()
```

This console application first takes a list of numbers and a target number as input from the user. It then uses a binary search algorithm to find the target number in the list. If the target number is found, it prints the index of the target number; otherwise, it prints that the target number is not present in the list.