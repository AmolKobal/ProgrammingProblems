namespace ProgrammingProblems
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
            foreach (int value in subset)
            {
                bool found = false;
                foreach (int item in set)
                {
                    if (value.Equals(item))
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

        public static string Print(int[] list)
        {
            string output = "";
            output = "[ ";
            foreach (int item in list)
                output += item + " ";
            output += "]";
            return output;
        }
    }

}
