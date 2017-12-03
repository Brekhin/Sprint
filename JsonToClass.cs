using System.Collections.Generic;

namespace twitter_bot
{
    public class JsonToClass
    {
        public class Type
        {
            public string name { get; set; }
            public string code { get; set; }
        }

        public class Medium
        {
            public string name { get; set; }
            public Type type { get; set; }
            public bool active { get; set; }
            public string address { get; set; }
            public object website { get; set; }
            public string reg_date { get; set; }
            public string reg_num { get; set; }
        }

        public class MoneyTransfersSumByType
        {
            public double Contract { get; set; }
            public double Grant { get; set; }
            public double Subsidy { get; set; }
        }

        public class Contract
        {
            public string reg_num { get; set; }
            public string date { get; set; }
            public List<string> description { get; set; }
            public double amount { get; set; }
            public string customer { get; set; }
        }

        public class Subsidie
        {
            public string date { get; set; }
            public string name { get; set; }
            public double amount { get; set; }
            public string customer { get; set; }
            public string customer_inn { get; set; }
            public string customer_kpp { get; set; }
        }

        public class Grant
        {
            public string date { get; set; }
            public List<string> description { get; set; }
            public string source_of_modey { get; set; }
            public string url { get; set; }
        }


        public class Result
        {
            public string name { get; set; }
            public string inn { get; set; }
            public List<Medium> media { get; set; }
            public double money_transfers_sum { get; set; }
            public MoneyTransfersSumByType money_transfers_sum_by_type { get; set; }
            public List<Contract> contracts { get; set; }
            public List<object> subsidies { get; set; }
            public List<object> grants { get; set; }
        }

        public class RootObject
        {
            public int count { get; set; }
            public string next { get; set; }
            public string previous { get; set; }
            public List<Result> results { get; set; }
        }
    }
}
