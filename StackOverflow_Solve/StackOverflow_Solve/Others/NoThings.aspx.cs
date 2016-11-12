using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StackOverflow_Solve.Others
{
    class RepeatedValue
    {
        public char C { get; set; }
        public int Count { get; set; }

        public RepeatedValue(Char C)
        {
            this.C = C;
            this.Count = 1;
        }
    }
    public partial class NoThings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String testCase="1";
            Int64 testCaseLength = Convert.ToInt64(testCase);
            for (int i = 0; i < testCaseLength; i++)
            {
                String Output = "3 5";
            }
            
           



            var r = IsCoolNumber(6);
            /*
            String reveser = @"$$code$$";
            String output=string.Empty;
            int length = reveser.Length;
            for (int i = length-1; i >=0; i--)
            {
                output = output + reveser[i];
            }
            var ss = output;*/

            String data = "zzraa";
            Char[] charArray = data.ToCharArray();
            int length = data.Length;
            List<RepeatedValue> list=new List<RepeatedValue>();
            for (int i = 0; i < length; i++)
            {
                int indx = list.FindIndex(x => x.C == charArray[i]);
                if (indx != -1)
                {
                    list[indx].Count = list[indx].Count+1;
                }
                else
                {
                    RepeatedValue value = new RepeatedValue
                        (charArray[i]);
                    list.Add(value);
                }
            }

            list = list.OrderByDescending(i => i.Count).ThenBy(i => i.C).ToList();
            var hhh = list;



        }


        long IsCoolNumber(long x)
        {
            for (long i = x; ; i++)
            {
                string res = i.ToString();
                if (!res.Contains('0') && !res.Contains('1') && !res.Contains('3') && !res.Contains('4') &&
                    !res.Contains('6') && !res.Contains('7') && !res.Contains('8') && !res.Contains('9'))
                {
                    return i;
                }
            }
           // return 0;
        }
    }
}