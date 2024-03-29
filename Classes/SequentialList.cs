﻿namespace ProgrammingProblems
{
    /// <summary>
    /// Check if given list is subset of another list.
    /// E.g. Set = (1, 3, 5, 7), Subset = (1, 3)
    /// Returns true if all elementsof Subset is available in Set.
    /// </summary>

    class SequentialList
    {
        int[] set;

        public SequentialList(int[] list)
        {
            set = list;
        }

        public bool IsSubset(int[] subset)
        {
            foreach (int subsetItem in subset)
            {
                bool found = false;
                foreach (int item in set)
                {
                    if (subsetItem.Equals(item))
                    {
                        found = true;
                        break;
                    }
                }

                if (found == false)
                {
                    return false;
                }
            }

            return true;
        }

    }

}
