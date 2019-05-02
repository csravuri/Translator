using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Translator.FullLogic
{
    public class TranslateText
    {

        // Translate

        public string Translate(string input, string languagePair)
        {
            string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
            string data = $"ie=UTF8&text={input}&langpair={languagePair}";
            MyWebRequest request = new MyWebRequest(url, "POST", "");

            string result = request.GetResponse();
            return result;

        }

        //public static string TranslateText(string input, string languagePair)
        //{
        //    string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
        //    HttpClient httpClient = new HttpClient();
        //    string result = httpClient.GetStringAsync(url).Result;
        //    result = result.Substring(result.IndexOf("<span title=\"") + "<span title=\"".Length);
        //    result = result.Substring(result.IndexOf(">") + 1);
        //    result = result.Substring(0, result.IndexOf("</span>"));
        //    return result.Trim();
        //}

        //public string Translate(string input, string languagePair)
        //{
        //    string url = String.Format("http://www.google.com/translate_t?hl=en&ie=UTF8&text={0}&langpair={1}", input, languagePair);
        //    WebClient webClient = new WebClient();
        //    webClient.Encoding = System.Text.Encoding.Default;
        //    string result = webClient.DownloadString(url);
        //    result = result.Substring(result.IndexOf("TRANSLATED_TEXT"));
        //    result = result.Substring(result.IndexOf("'") + 1);
        //    result = result.Substring(0, result.IndexOf("'"));
        //    return result;
        //}

        //public string Translate(string word, string languagePair,int a)
        //{
        //    var toLanguage = "en";//English
        //    var fromLanguage = "te";//Deutsch
        //    var url = "";//$"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(word)}";
        //    var webClient = new WebClient
        //    {
        //        Encoding = System.Text.Encoding.UTF8
        //    };
        //    var result = webClient.DownloadString(url);
        //    try
        //    {
        //        result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
        //        return result;
        //    }
        //    catch
        //    {
        //        return "Error";
        //    }
        //}
    }
}
