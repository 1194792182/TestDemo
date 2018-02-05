using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace WebLog
{
    public class WebLogHelper
    {
        private static string _logUrl = "http://localhost:50321/api/logs";
        public static void WebLog(string msg)
        {

            var response = CreatePostHttpResponse(_logUrl, "Remark=" + msg, Encoding.UTF8);
            if (response != null)
            {
                var stream = response.GetResponseStream(); //获取响应的字符串流
                if (stream != null)
                {
                    var sr = new StreamReader(stream); //创建一个stream读取流  
                    var str = sr.ReadToEnd();
                    Console.WriteLine(str);
                }
            }
        }

        private static HttpWebResponse CreatePostHttpResponse(string url, string datas, Encoding charset)
        {
            HttpWebRequest request = null;

            request = WebRequest.Create(url) as HttpWebRequest;
            if (request != null)
            {
                request.UserAgent = "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; .NET CLR 2.0.50727; .NET CLR 3.0.04506.648; .NET CLR 3.5.21022)";
                request.Method = "POST";
                byte[] data = charset.GetBytes(datas);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }
                return request.GetResponse() as HttpWebResponse;
            }
            else
            {
                return null;
            }
        }
    }
}
