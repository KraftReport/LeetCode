using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console.Solutions
{
     public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
     {
        public int val = val;
        public TreeNode? left = left;
        public TreeNode? right = right;
     }

    public static class MaximunBinaryTree
    {
        public static TreeNode? Solution(int[] nums)
        {
            return BuildTreeNode(nums, 0, nums.Length-1);
        }

        private static TreeNode? BuildTreeNode(int[] nums,int start,int end)
        {
            if (start > end)
            { 
                return null;
            }
            int maxIndex = start;
            for(int i = start; i <= end; i++)
            {
                if (nums[i] > nums[maxIndex]) maxIndex = i;
            } 
            return new TreeNode(nums[maxIndex],BuildTreeNode(nums,start,maxIndex-1),BuildTreeNode(nums,maxIndex+1,end)); 
        }
    }
}
