
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOSE5
{
    public class Formulas
    {
        public int CounterInc(int count)
        {
            ++count;
            return count;
        }
        public int CounterDec(int count)
        {
            if (count > 0)
                --count;
            else
                count = 0;
            return count;
        }
        public int CounterBillNo()
        {
            Random r = new Random();
            return r.Next(100, 999)+ r.Next(20,70);
        }
        public int PassDecode(string s)
        {
            char[] a = s.ToCharArray();
            int code = 0, loc=0;
            foreach (char c in a)
            {
                code += Convert.ToInt32(c);
            }
            loc = code % 10 + 2;
            return loc;
        }
        public int totalamount(int quantity, int price)
        {
            return quantity * price;
        }

    }
}
