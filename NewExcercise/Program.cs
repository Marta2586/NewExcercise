using System;

namespace NewExcercise
{
    class Program
    {
        public bool More14(int[] nums)
        {
            // 1. Piedefinēt, kur skaitīsim 1 un 4

            int numberOfOnes = 0;
            int numberOfFours = 0;

            // 2.Saskaitīt masīvā esošos 1 un 4

            foreach (int num in nums)
            {
               if (num ==1)
                {
                    numberOfOnes++;
                }

               if (num == 4)
                {
                    numberOfFours++;
                }

            }

        }
        /////
        public bool Either24(int[] nums)
        {
            bool hasNext2 = false;
            bool hasNext4 = false;

            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] == 2 && nums[i + 1] == 2)
                {
                    hasNext2 = true;
                }

                if (nums[i] == 4 && nums[i + 1] == 4)
                {
                    hasNext4 = true;
                }
            }

            if (hasNext2 && hasNext4)
            {
                return false;
            }

            if (hasNext2 || hasNext4)
            {
                return true;
            }

            return false;
        }//
        ////////////////////////
        
        public bool IsEverywhere(int[] nums, int val)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                // Vienam no elementu pāra ir jābūt val vērtībai, ja tā nav tad ir false
                if (nums[i] == val || nums[i + 1] == val)
                {
                    continue;
                }

                // Ja ir continue, tad šī rindiņa neizpildās
                return false;
            }

            return true;


        }

       

    }

    }
}
