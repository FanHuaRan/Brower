using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace EntityWebBrowser.Util
{
    public class HomeUrlTxtClass
    {
        public static string GetHomeUrl(string fileName)
        {
            string homeUrl = "";
            using (StreamReader sReader = new StreamReader(fileName))
            {
                homeUrl = sReader.ReadLine();
            }
            return homeUrl;
        }

        public static void  SetHomeUrl(string fileName, string homeUrl)
        {
            using (StreamWriter sWriter = new StreamWriter(fileName,false))
            {
                sWriter.WriteLine(homeUrl);
            }
        }
    }
}
