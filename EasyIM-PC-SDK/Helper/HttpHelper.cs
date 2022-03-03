using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace EasyIM_PC_SDK.Helper
{
    /*
     * ========================================================================
     * Copyright Notice  2010-2022 Helloes All rights reserved .
     * ========================================================================
     * 机器名称：DESKTOP-KBNKUO5 
     * 文件名：  HttpHelper 
     * 版本号：  V1.0.0.0 
     * 创建人：  kools 
     * 创建时间：2022/3/3 14:01:45 
     * 描述    :
     * =====================================================================
     * 修改时间：2022/3/3 14:01:45 
     * 修改人  ：kools
     * 版本号  ：V1.0.0.0 
     * 描述    ：
	*/
    public class HttpHelper
    {
        #region 发起Get请求-异步
        /// <summary>
        /// 发起Get请求-异步
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <returns>响应结果</returns>
        public static async Task<string> GetAsync(string url)
        {
            string result;
            try
            {
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(url);
                response.EnsureSuccessStatusCode();
                result = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                LogHelper.ErrorFormat("发送http-get请求异常：{0}", e.Message);
                throw new Exception(e.Message);
            }
            return result;
        }
        #endregion

        #region 发起Post请求-异步
        /// <summary>
        /// 发起Post请求-异步
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="paramList">请求参数-键值对</param>
        /// <returns>响应结果</returns>
        public static async Task<string> PostAsync(string url, List<KeyValuePair<string, string>> paramList)
        {
            string result;
            try
            {
                HttpClient httpClient = new HttpClient();
                HttpContent httpContent = new FormUrlEncodedContent(paramList);
                HttpResponseMessage response = await httpClient.PostAsync(url, httpContent);
                response.EnsureSuccessStatusCode();
                result = await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                LogHelper.ErrorFormat("发送http-post请求异常：{0}", e.Message);
                throw new Exception(e.Message);
            }
            return result;
        }
        #endregion

        #region 发起Post请求-同步
        /// <summary>
        /// 发起Post请求-同步
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="paramList">请求参数-键值对</param>
        /// <returns>响应结果</returns>
        public static string Post(string url, List<KeyValuePair<string, string>> paramList)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.MaxResponseContentBufferSize = 256000;
            /*httpClient.DefaultRequestHeaders.Add("user-agent", "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/36.0.1985.143 Safari/537.36");*/
            HttpResponseMessage response = httpClient.PostAsync(new Uri(url), new FormUrlEncodedContent(paramList)).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            return result;
        }
        #endregion

        #region 发起Get请求-同步
        /// <summary>
        /// 发起Get请求-同步
        /// </summary>
        /// <param name="url">请求地址</param>
        /// <param name="postDataStr">请求参数-字符串</param>
        /// <returns>响应结果</returns>
        public static string Get(string url, string postDataStr = "")
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + (postDataStr == "" ? "" : "?") + postDataStr);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }
        #endregion

        #region 发起Post请求-同步
        /// <summary>
        /// 发起Post请求-同步
        /// </summary>
        /// <param name="posturl">请求地址</param>
        /// <param name="postData">请求参数-字符串</param>
        /// <returns>响应结果</returns>
        public static string Post(string url, string postData)
        {
            Stream outstream = null;
            Stream instream = null;
            StreamReader sr = null;
            HttpWebResponse response = null;
            HttpWebRequest request = null;
            Encoding encoding = System.Text.Encoding.GetEncoding("utf-8");
            byte[] data = encoding.GetBytes(postData);
            // 准备请求...
            try
            {
                // 设置参数
                request = WebRequest.Create(url) as HttpWebRequest;
                CookieContainer cookieContainer = new CookieContainer();
                request.CookieContainer = cookieContainer;
                request.AllowAutoRedirect = true;
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                outstream = request.GetRequestStream();
                outstream.Write(data, 0, data.Length);
                outstream.Close();
                //发送请求并获取相应回应数据
                response = request.GetResponse() as HttpWebResponse;
                //直到request.GetResponse()程序才开始向目标网页发送Post请求
                instream = response.GetResponseStream();
                sr = new StreamReader(instream, encoding);
                //返回结果网页（html）代码
                string content = sr.ReadToEnd();
                string err = string.Empty;
                return content;
            }
            catch (Exception ex)
            {
                string err = ex.Message;
                return string.Empty;
            }
        }
        #endregion
    }
}
