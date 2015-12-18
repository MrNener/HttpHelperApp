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
        public string ContentType { get; set; } = "application/x-www-form-urlencoded";
        public string UserAgent { get; set; } = "Mozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; Trident/5.0)";
        public string Referer { get;  set; }
    }

    public class HttpHelper
    {
        private HttpConfig conf;
        private long totalCount = 1;
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
                httpRequest.ContentType = conf.ContentType;
                httpRequest.UserAgent = conf.UserAgent;
                httpRequest.ReadWriteTimeout = conf.Timeout;
                httpRequest.Referer = conf.Referer;
                if (!string.IsNullOrEmpty(conf.SendData))
                {
                    byte[] btBodys = Encoding.UTF8.GetBytes(conf.SendData);
                    httpRequest.ContentLength = btBodys.Length;
                    httpRequest.GetRequestStream().Write(btBodys, 0, btBodys.Length);
                }
                var httpResResponse = (System.Net.HttpWebResponse)httpRequest.GetResponse();
                using (System.IO.Stream receiveStream = httpResResponse.GetResponseStream())
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
                var task = new Task(() =>
                 {
                     var c = singleCount;
                     while (c > 0)
                     {
                         int i = singleCount;
                         var res = GetRes();
                         HandelRes($"WorkId {workerId}; Task Id:{Task.CurrentId};Index:{ totalCount++};Result:{res}");
                         --c;
                     }
                 });
                tLs.Add(task);
                --theadCount;
            }
            tLs.ForEach(a =>
            {
                a.Start();
            });
        }
    }
}
