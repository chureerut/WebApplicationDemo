using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationDemo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var myInt = 2;

            int a = 4;
            double b;
            b = (int)a;

            string txtPrice = "12.50";
            int price = (int) Convert.ToDouble(txtPrice);

            int number = 0;
            string numberString = "1234";
            if (int.TryParse(numberString, out number))
            {
                Console.WriteLine("Conversion succeeded");
                Console.WriteLine(number);

            }
            else
            {
                Console.WriteLine("failed");
            }
            Console.ReadKey();
        }
        void WhatYourName()
        {
            String name = Console.Read();
            Console.WriteLine("Hello" + name);
         }
}

    }
}