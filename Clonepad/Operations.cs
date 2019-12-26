using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clonepad
{
    class Operations
    {
        private string copied;
        private Stack actions;
        private Stack deleted;
        public Operations()
        {
            copied = "";
            actions = new Stack();
            deleted = new Stack(30);
        }

        public void copy(string copied)
        {
            this.copied = copied;
        }

        public string paste()
        {
            return this.copied;
        }

        public void addAction(string action)
        {
            this.actions.push(action);
        }

        public void delete(string deletedLine)
        {
            this.deleted.push(deletedLine);
        }
    }
}
