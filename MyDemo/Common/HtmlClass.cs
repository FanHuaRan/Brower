using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo.Common
{
    public static class HtmlClass
    {
        public static bool SaveHtml(string url, string filePath)
        {
            try
            {
                HttpWebRequest wReq = (HttpWebRequest) WebRequest.Create(url);
                wReq.UserAgent =
                    "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.0; .NET CLR 1.1.4322; .NET CLR 2.0.50215; " +
                    Guid.NewGuid().ToString() + ")";
                HttpWebResponse wResp = wReq.GetResponse() as HttpWebResponse;
                wReq.AllowAutoRedirect = true;
                // 获取输入流
                Stream respStream = wResp.GetResponseStream();
                StreamReader reader = new StreamReader(respStream);
                string content = reader.ReadToEnd();
                reader.Close();
                reader.Dispose();
                respStream.Close();
                respStream.Dispose();
                wResp.Close();
                FileStream fileStream=new FileStream(filePath,FileMode.OpenOrCreate,FileAccess.Write);
                StreamWriter writer=new StreamWriter((Stream)fileStream);
                writer.Write(content);
                writer.Close();
                writer.Dispose();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}


