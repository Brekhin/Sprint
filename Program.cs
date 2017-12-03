using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TweetSharp;
using static twitter_bot.JsonToClass;

namespace twitter_bot
{
    class Program
    {
        private static string cons_key = "v9hhw9Has5ggDVC63K3rnby1v";
        private static string cons_secret = "DoScc4lt710QGXdQPXqB7KiaN8QTkugRpAgnJhjmpFydkfdm4G";
        private static string access_token = "849806977760886785-w26rUBLGnBkFak7IWuT446O0M23zKOU";
        private static string secret_access = "necG42Cvstq5hNSdihMrqr4tcDsXpCrIwLV0wDM6Yg7f5";
        public static string datetime = $"[{DateTime.Now.ToShortTimeString()}]";
        public static TwitterService twitter = new TwitterService(cons_key, cons_secret, access_token, secret_access);
        private static RootObject info;

        public static JObject getInfo()
        {
            WebRequest reqGet = WebRequest.Create("https://openmassmedia.ru/api/founders/");
            WebResponse resp = reqGet.GetResponse();
            Stream stream = resp.GetResponseStream();
            StreamReader sr = new StreamReader(stream);
            string s = sr.ReadToEnd();
            JObject parsed = JObject.Parse(s);
            return parsed;
        }


        static void Main(string[] args)
        {
            run();
        }
        public static void run()
        {
        Start:
            Console.WriteLine("input");
            int count = 0;
            JObject jp = getInfo();
            string result;
            //--------------------------------
            string json = jp.ToString();
            double contractsSum = 0;
            info = JsonConvert.DeserializeObject<RootObject>(json);

            //for(int i = 0; i < info.)
            foreach (Result r in info.results)
            {
                Console.WriteLine(info.results.Count.ToString());
                try
                {
                    foreach (Contract c in info.results[0].contracts)
                    {
                        contractsSum += c.amount;
                    }
                }
                catch (Exception e)
                {

                }
                Console.WriteLine("Учредитель " + r.name + " заключил контракт на сумму " + info.results[0].contracts[0].amount.ToString());
                sendTweet("Учредитель " + r.name + " заключил контракт на сумму " + info.results[0].contracts[0].amount.ToString());
                Thread.Sleep(10000);
            }
            //--------------------------------
            
            count++;
                
          //  }
            Thread.Sleep(4 * 60 * 60 * 1000);
            goto Start;
        }

        public static void sendTweet(string _status)
        {
            twitter.SendTweet(new SendTweetOptions { Status = _status }, (tweet, response) =>
            {

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    Console.WriteLine("OK");
                }
                else
                {
                    Console.WriteLine("not OK");
                }
            });
        }
    }
}
