using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postfix
{
    internal class Stack1
    {
        int top;
        int size;
        char[] stackarr;
        public Stack1(int ele)
        {
            size = ele;
            top = -1;
            stackarr = new char[size];
        }
        public void push(char ele)
        {
           
                stackarr[++top] = ele;
            


        }
        public char pop()
        {
            return stackarr[top--];
        }
        public bool isEmty()
        {
            return (top == -1);
        }
        public bool isFull()
        {

            return (top == size - 1);
        }
        public char peek()
        {
            return (stackarr[top]);
        }
        public int stackSize()
        {
            return top + 1;
        }
        public bool stop(char x)
        {
            return (x == '#');
        }
        public int piorty(char x)
        {
            if (x == '(')
                return 0;
            if (x == '+' || x == '-')
                return 1;
            if (x == '*' || x == '/')
                return 2;
            return 3;
        }
        public char ip(char x)
        {
            switch (x)
            {
              

                case '(':
                    return ')';
            }
            return '0';

        }
        
    }
}
