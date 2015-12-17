using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpHelperApp
{
    public class HttpConfig
    {
        public string Url { get; set; }

        public string Method { get; set; } = "POST";

        public int Timeout { get; set; } = 10000;
        public string SendData { get; set; }
    }

    public class HttpHelper
    {
        private HttpConfig conf;
        private int totalCount = 1;
        public Action<string> HandelRes = (a) =>
        {
           System.Console.WriteLine(a);
        };
        private string workerId;
        public HttpHelper(HttpConfig conf)
        {
            this.conf = conf;
            workerId = Guid.NewGuid().ToString("n");
        }
        public HttpHelper(HttpConfig conf,string wid)
        {
            this.conf = conf;
            workerId = wid;
        }
        private string GetRes()
        {
            try
            {
                System.Net.HttpWebRequest httpRequest = (System.Net.HttpWebRequest)System.Net.WebRequest.Create(conf.Url);
                httpRequest.Method = conf.Method;
                httpRequest.Timeout = conf.Timeout;
                if (!string.IsNullOrEmpty(conf.SendData))
                {
                    byte[] btBodys = Encoding.UTF8.GetBytes(conf.SendData);
                    httpRequest.ContentLength = btBodys.Length;
                    httpRequest.GetRequestStream().Write(btBodys, 0, btBodys.Length);
                }

                using (System.IO.Stream receiveStream = httpRequest.GetResponse().GetResponseStream())
                {
                    using (var rs = new System.IO.StreamReader(receiveStream))
                    {
                        return rs.ReadToEnd();
                    }
                }
            }
            catch (Exception e)
            {
                return $"请求失败：{e.Message}";
            }
        }
        public void DoWork(int theadCount, int singleCount)
        {
            List<Task> tLs = new List<Task>();
            while (theadCount > 0)
            {
                tLs.Add(new Task(() =>
                {
                    var c = singleCount;
                    while (c > 0)
                    {
                        int i = singleCount;
                        HandelRes($"WorkId {workerId}; Task Id:{Task.CurrentId};Index:{ totalCount++};Result:{GetRes()}");
                        --c;
                    }
                }));
                --theadCount;
            }
            tLs.ForEach(a =>
            {
                a.Start();
            });
        }
    }
}
