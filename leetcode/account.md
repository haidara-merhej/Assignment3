# Single Number

## Problem Link
[Single Number - LeetCode](https://leetcode.com/problems/single-number/)

## Problem Description

Given a non-empty array of integers `nums`, every element appears twice except for one element, which appears only once. Find that single element.

## Approach: Bit Manipulation (XOR)

The solution uses the bitwise XOR (`^`) operator to identify the number that appears only once.

### Key Observations

The XOR operator has three important properties:

- `a ^ a = 0` — A number XORed with itself equals zero.
- `a ^ 0 = a` — A number XORed with zero remains unchanged.
- XOR is commutative and associative, so the order of operations does not matter.

Since duplicate numbers cancel each other out, the remaining value is the number that appears only once.

### Algorithm

1. If the array contains one element, return that element.
2. Initialize a variable `result` to `0`.
3. Iterate through the array and XOR each element with `result`.
4. Return `result` after processing all elements.

### C# Solution

```csharp
public class Solution
{
    public int SingleNumber(int[] nums)
    {
        if (nums.Length <= 1)
            return nums[0];

        int result = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            result ^= nums[i];
        }

        return result;
    }
}
```

### Example

**Input:**
```text
nums = [4, 1, 2, 1, 2]
```

**Execution:**

```text
0 ^ 4 = 4
4 ^ 1 = 5
5 ^ 2 = 7
7 ^ 1 = 6
6 ^ 2 = 4
```

**Output:**
```text
4
```

The duplicate values cancel each other out, leaving `4` as the single number.

### Complexity Analysis

- **Time Complexity:** `O(n)` — The array is traversed once.
- **Space Complexity:** `O(1)` — Only a constant amount of extra memory is used.

## LeetCode Profile

[Visit my leetcode profile](https://leetcode.com/u/Haidara_Merhej/)



