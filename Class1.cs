using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public class Rootobject
        {
            public Mark mark { get; set; }
            public Brand[] brands { get; set; }
            public Price[] price { get; set; }
            public object[] test { get; set; }
        }

        public class Mark
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public string is_active { get; set; }
            public string created_at { get; set; }
            public string deleted_at { get; set; }
            public string user { get; set; }
        }

        public class Brand
        {
            public string id { get; set; }
            public string name { get; set; }
            public string slug { get; set; }
            public string is_active { get; set; }
            public string order { get; set; }
            public string created_at { get; set; }
            public string deleted_at { get; set; }
            public string brand { get; set; }
            public string user { get; set; }
            public string last_price { get; set; }
            public float percent_diff { get; set; }
            public string price_diff { get; set; }
            public float valute { get; set; }
            public Price_List[] price_list { get; set; }
        }

        public class Price_List
        {
            public string created_at { get; set; }
            public string _0 { get; set; }
            public string price { get; set; }
            public string _1 { get; set; }
            public string country_id { get; set; }
            public string _2 { get; set; }
        }

        public class Price
        {
            public string price { get; set; }
            public string _0 { get; set; }
            public string created_at { get; set; }
            public string _1 { get; set; }
            public string course { get; set; }
            public string _2 { get; set; }
            public string dollar { get; set; }
            public string _3 { get; set; }
            public string country_id { get; set; }
            public string _4 { get; set; }
        }

    }
    public class ReturnedExcel
    {
        public byte[] Data { get; set; }  
        public string ExcelName { get; set; }
    }

}
