using LeetCode.Problems.Easy;
using Xunit;

namespace LeetCode.Test;

public class TwoSumTests
{
    [Fact]
    public void TwoSum_Example1_ReturnsCorrectIndices()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = new int[] { 2, 7, 11, 15 };
        int target = 9;
        
        // Act
        var result = solution.TwoSum(nums, target);
        
        // Assert
        Assert.Equal(new int[] { 0, 1 }, result);
    }
    
    [Fact]
    public void TwoSum_Example2_ReturnsCorrectIndices()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = new int[] { 3, 2, 4 };
        int target = 6;
        
        // Act
        var result = solution.TwoSum(nums, target);
        
        // Assert
        Assert.Equal(new int[] { 1, 2 }, result);
    }
    
    [Fact]
    public void TwoSum_Example3_ReturnsCorrectIndices()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = new int[] { 3, 3 };
        int target = 6;
        
        // Act
        var result = solution.TwoSum(nums, target);
        
        // Assert
        Assert.Equal(new int[] { 0, 1 }, result);
    }
    
    [Fact]
    public void TwoSum_NoSolution_ReturnsEmptyArray()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = new int[] { 1, 2, 3 };
        int target = 10;
        
        // Act
        var result = solution.TwoSum(nums, target);
        
        // Assert
        Assert.Empty(result);
    }
    
    [Fact]
    public void TwoSum_NegativeNumbers_ReturnsCorrectIndices()
    {
        // Arrange
        var solution = new Solution();
        int[] nums = new int[] { -3, 4, 3, 90 };
        int target = 0;
        
        // Act
        var result = solution.TwoSum(nums, target);
        
        // Assert
        Assert.Equal(new int[] { 0, 2 }, result);
    }
}