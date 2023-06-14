using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    class NurseryList : IDisposable
    {
        private List<ITree> treeList = null;

        public NurseryList()
        {
            treeList = new List<ITree>();
        }

        public void Add(ITree tree)
        {
            treeList.Add(tree);
        }
        public void Remove(ITree tree)
        {
            treeList.Remove(tree);
        }

        public int Count()
        {
            return treeList.Count();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public ITree this[int i]
        {
            get { return treeList[i]; }
        }

        public void Sort()
        {
            treeList.Sort();
        }

        public bool CheckCreditCard(string chceckCCNumber)
        {
            bool result = false;
            if (chceckCCNumber != null && chceckCCNumber != string.Empty)
            {
                char[] CCNumberArray = chceckCCNumber.ToCharArray();
                if (CCNumberArray.Length == 16)
                {
                    for (int i = 0; i < CCNumberArray.Length; i++)
                    {
                        if (char.IsDigit(CCNumberArray[i]))
                        {
                            result = true;
                        }
                        else
                        {
                            result = false;
                            break;
                        }
                    }
                }
            }
            return result;
        }
    }
}
