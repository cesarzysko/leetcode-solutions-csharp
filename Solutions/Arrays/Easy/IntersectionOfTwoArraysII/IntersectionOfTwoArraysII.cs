using System.Collections.Generic;

namespace Solutions.Arrays.Easy
{
    public static class IntersectionOfTwoArraysII
    {
        public static int[] Solution(int[] nums1, int[] nums2) 
        {
            int n = nums1.Length;
            List<int> intersection = new List<int>();
            Dictionary<int, IntWrapper> dict = new Dictionary<int, IntWrapper>();
        
            for (int i = 0; i < n; ++i)
            {
                int key = nums1[i];
                if (dict.TryGetValue(key, out IntWrapper wrapper))
                {
                    ++wrapper.Value;
                }
                else
                {
                    dict.Add(key, new IntWrapper(1));
                }
            }
        
            n = nums2.Length;
        
            for (int i = 0; i < n; ++i)
            {
                int key = nums2[i];
                if (dict.TryGetValue(key, out IntWrapper occurrences))
                {
                    intersection.Add(key);
                    if ((--occurrences.Value) == 0)
                    {
                        dict.Remove(key);
                    }
                }
            }
        
            return intersection.ToArray();
        }
        
        private sealed class IntWrapper
        {
            public int Value;
        
            public IntWrapper(int val)
            {
                Value = val;
            }
        }
    }
}
