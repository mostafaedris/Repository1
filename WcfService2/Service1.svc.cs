using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IRedPill
    {
        //public string GetData(int value)
        //{
        //    return string.Format("You entered: {0}", value);
        //}

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}

        RedPillClient client = new RedPillClient();

        Guid IRedPill.WhatIsYourToken()
        {
            return new Guid("e3d3a0d2-e6a8-4976-be8b-356ba3fc0309");
        }

        long IRedPill.FibonacciNumber(long n)
        {
            long result = 0;
            long v1, v2;
            v1 = 0;
            v2 = 1;

            if (n == 0)
                result = v1;
            else if (n == 1)
                result = v2;
            else if (n > 1)
            {
                for (int i = 2; i <= n; i++)
                {
                    result = v1 + v2;
                    v1 = v2;
                    v2 = result;
                }
            }

            return result;
        }

        knockknock.readify.net.TriangleType IRedPill.WhatShapeIsThis(int a, int b, int c)
        {
            //knockknock.readify.net.TriangleType trigType = knockknock.readify.net.TriangleType.Error;

            if ((a < 1) || (b < 1) || (c < 1))
                return knockknock.readify.net.TriangleType.Error;

            else if ((a == b) && (b == c) && (c == a))
                return knockknock.readify.net.TriangleType.Equilateral;

            else if ((a == b) || (b == c) || (c == a))
                return knockknock.readify.net.TriangleType.Isosceles;
            else
                return knockknock.readify.net.TriangleType.Scalene;

            //return trigType;
        }

        string IRedPill.ReverseWords(string s)
        {
            string res = "";

            string[] str = s.Split(' ');
            Array.Reverse(str);
            res = string.Join(" ", str);

            return res;
        }

        //string IRedPill.ReverseWords(string s)
        // {
        //     string res = "";
        //     char[] charArray;
        //     int i = 0,j=0;

        //     List<string> strList = new List<string>();
        //     strList = s.Split(' ').ToList<string>();

        //     foreach (string _str in strList)
        //     {                
        //         charArray = _str.ToCharArray();
        //         i = charArray.Length;
        //         j = 0;
        //         for (j = i - 1; j >= 0; j--)
        //         {
        //             res = res + charArray[j].ToString();
        //         }
        //         res = res + " ";
        //     }
        //     return res;
        // }
    }
}
