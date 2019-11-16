using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleExamples.GenericClassess
{
    #region [ Userdefined Generic Class ]
        public class MyGeneric<T>
        {
            private List<T> list= null;
            public MyGeneric()
            {
                list = new List<T>();
            }

            public void AddItem(T t)
            {
                list.Add(t);
            }
            public T GetItem()
            {
                return list[0];
            }
            public T GetItem(Int32 index)
            {
                return list[index];
            }
        }

        public class MyList : IList, ICloneable
        {
            private ArrayList mArrayList;

            public MyList()
            {
                mArrayList = new ArrayList();
            }

            public override string ToString()
            {
                return "MyList";
            }

            #region [ IList Members ]

            int IList.Add(object value)
            {
                return mArrayList.Add(value);
            }

            void IList.Clear()
            {
                mArrayList.Clear();
            }

            bool IList.Contains(object value)
            {
                return mArrayList.Contains(value);
            }

            int IList.IndexOf(object value)
            {
                return mArrayList.IndexOf(value);
            }

            void IList.Insert(int index, object value)
            {
                mArrayList.Insert(index, value);
            }

            bool IList.IsFixedSize
            {
                get
                {
                    return mArrayList.IsFixedSize;
                }
            }

            bool IList.IsReadOnly
            {
                get
                {
                    return mArrayList.IsReadOnly;
                }
            }

            void IList.Remove(object value)
            {
                mArrayList.Remove(value);
            }

            void IList.RemoveAt(int index)
            {
                mArrayList.RemoveAt(index);
            }

            object IList.this[int index]
            {
                get
                {
                    return mArrayList[index];
                }
                set
                {
                    mArrayList[index] = value;
                }
            }

            #endregion

            #region [ ICollection Members ]

            void ICollection.CopyTo(Array array, int index)
            {
                mArrayList.CopyTo(array, index);
            }

            int ICollection.Count
            {
                get
                {
                    return mArrayList.Count;
                }
            }

            bool ICollection.IsSynchronized
            {
                get
                {
                    return mArrayList.IsSynchronized;
                }
            }

            object ICollection.SyncRoot
            {
                get
                {
                    return mArrayList.SyncRoot;
                }
            }

            #endregion

            #region [ IEnumerable Members ]

            IEnumerator IEnumerable.GetEnumerator()
            {
                return mArrayList.GetEnumerator();
            }

            #endregion

            #region [ ICloneable Members ]

            object ICloneable.Clone()
            {
                return this.mArrayList.Clone();
            }

            #endregion
        }
    #endregion
}
