using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clonepad
{
    class Stack
    {
        private List<String> stackList;
        private int maxSize;

        public Stack(int maxSize = int.MaxValue)
        {
            stackList = new List<string>();
            this.maxSize = maxSize;
        }

        public String pop()
        {
            String result = null;
            if(stackList.Count > 0)
            {
                result = stackList[stackList.Count-1];
                stackList.RemoveAt(stackList.Count - 1);
            }
            return result;
        }

        public void push(String line)
        {
            if(stackList.Count > maxSize)
            {
                stackList.RemoveAt(0);
            }
            stackList.Add(line);
        }
    }
}
