﻿namespace ProgrammingProblems
{
    class SequentialList<T>
    {
        T[] set;

        public SequentialList(T[] list)
        {
            set = list;
        }

        public bool IsSubset(T[] subset)
        {
            foreach (T value in subset)
            {
                bool found = false;
                foreach (T item in set)
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

    }
}
