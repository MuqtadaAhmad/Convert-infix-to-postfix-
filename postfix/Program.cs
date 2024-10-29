using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postfix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack1 st = new Stack1(10);
            string fumction = "((A-(B+C))*D/(E+F)#";
            string posfix = "";
            for (int i=0;i<fumction.Length;i++)
            {
                if (fumction[i] == '+' || fumction[i] == '-' || fumction[i] == '*' || fumction[i] == '/' || fumction[i] == '(')
                {
                    if (st.isEmty())
                        st.push(fumction[i]);
                 

                    else if (st.peek() == '('|| fumction[i] == '(')
                    {
                        st.push(fumction[i]);
                    }
                    else if (st.piorty(fumction[i]) <= st.piorty(st.peek()))
                    {

                        posfix += st.pop();
                        st.push(fumction[i]);

                    }
                    else

                        st.push(fumction[i]);
                    
                }
                else
                {
                    if (st.stop(fumction[i]))
                    {
                        for (int j=0;j<st.stackSize()+1;j++)
                        {
                            if (st.peek() == '(')
                                 st.pop();
                            else
                                posfix += st.pop();
                        }
                        Console.WriteLine(posfix);
                        break;
                    }
                    if (fumction[i]==')')
                    {
                        while (fumction[i] != st.ip(st.peek()))
                        {
                            posfix += st.pop();
                            if (st.peek() == '(')
                            {
                                st.pop();
                                break;
                            }


                        }





                    }
                    else
                    posfix += fumction[i];
                }
            }
            Console.ReadLine();
        }
    }
}
