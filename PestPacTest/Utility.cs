using Gherkin;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;
using WorkWave.TA.TestEngine;

namespace WorkWave.PestPac.TA
{

    public class UtilityClass
    {
        public static RestClient Client;
        public static RestRequest restRequest;
        public static RestResponse restResponse;
        //public static List<string> TenantIdList = new List<string>();
        public static String tenantId;

        static string Baseurl1 = ConfigurationManager.AppSettings.Get("BaseUrl1");
        static string Baseurl5 = ConfigurationManager.AppSettings.Get("BaseUrl5");
        static string Baseurl3 = ConfigurationManager.AppSettings.Get("BaseUrl3");
        static string validateTokenEndpoint = ConfigurationManager.AppSettings.Get("IDSValidateToken");
        static string getNewTokenEndpoint = ConfigurationManager.AppSettings.Get("IDSGetToken");


        /// <summary>
        /// This method will set the url by fetching the baseurl and concatenate with endpoint
        /// Note that the base url will be fetched from the app.config and the endpoint from specflow feature file.
        public static RestClient SetUrl(string endpoint)
        {
            WebConfig config = SUT.Web.Config;
             if (endpoint.Contains("workwave"))
            {
                var url = endpoint;
                if (config.HomePage.Contains("ppt"))
                {
                    tenantId = "333500";
                }
                else if (config.HomePage.Contains("pps"))
                {
                    tenantId = "333700";
                }

                return Client = new RestClient(url);
            }
            else if (endpoint.Contains("geocode"))
            {
                var url = endpoint;
                return Client = new RestClient(url);
            }
            else if (config.HomePage.Contains("pps"))
            {
                string Testurl = "https://ppsapi.pestpac.com";
                var url = Path.Combine(Testurl + endpoint);
                return Client = new RestClient(url);
            }
            else
            {
                string Testurl = "https://pptapi.pestpac.com";
                var url = Path.Combine(Testurl + endpoint);
                return Client = new RestClient(url);
            }           

        }
        public static RestClient SetUrl1(string endpoint)
        {
            WebConfig config = SUT.Web.Config;
            if (endpoint.Contains("workwave"))
            {               
                var url = endpoint;
               
                if (config.HomePage.Contains("ppt"))
                {                    
                    tenantId = "333575";
                }
                else if (config.HomePage.Contains("pps"))
                {
                    tenantId = "333775";
                }

                return Client = new RestClient(url);
            }
            else if(config.HomePage.Contains("pps"))
            {
                string Testurl = "https://ppsapi.pestpac.com";
                var url = Path.Combine(Testurl + endpoint);
                return Client = new RestClient(url);
            }
            else
            {
                string Testurl = "https://pptapi.pestpac.com";
                var url = Path.Combine(Testurl + endpoint);
                return Client = new RestClient(url);
            }
            

        }

        /// <summary>
        /// This method will perform the GET method request
        /// Note that the "path" parameter is to set the path of the json file where the header values are defined.
        /// Note that the "token" parameter is the json token name in the json file under which the required headers values are defined. This will help us in fetch those values.
        public static RestRequest GetRequest(string path, string token)
        {
            try
            {
                restRequest = new RestRequest(RestSharp.Method.GET);

                var json = File.ReadAllText(path);
                var jobj = JObject.Parse(json);

                if (jobj.ContainsKey(token))
                {
                    string str = jobj[token].ToString();
                    if (str.Contains("Authorization"))
                    {
                        string auth = jobj[token]["Authorization"].ToString();
                        restRequest.AddHeader("Authorization", auth);
                    }
                    if (str.Contains("Content-Type"))
                    {
                        string cont = jobj[token]["Content-Type"].ToString();
                        restRequest.AddHeader("Content-Type", cont);
                    }
                    if (str.Contains("Host"))
                    {
                        string host = jobj[token]["Host"].ToString();
                        restRequest.AddHeader("Host", host);
                    }
                    if (str.Contains("Accept"))
                    {
                        string Accept = jobj[token]["Accept"].ToString();
                        restRequest.AddHeader("Accept", Accept);
                    }
                    if (str.Contains("apikey"))
                    {
                        string apikey = jobj[token]["apikey"].ToString();
                        restRequest.AddHeader("apikey", apikey);
                    }
                    //if (str.Contains("tenant-id"))
                    {
                        restRequest.AddHeader("tenant-id", tenantId);
                        //string tenantId = jobj[token]["tenant-id"].ToString();
                        // restRequest.AddHeader("tenant-id", TenantIdList[0]);// tenantId);
                    }


                }
                return restRequest;
            }
            catch (HttpException ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// This method will perform the PUT method request
        /// Note that the "headerpath" parameter is to set the path of the json file where the header values are defined.
        /// Note that the "token" parameter is the json token name in the json file under which the required headers values are defined. This will help us in fetch those values.
        /// Note that the "bodypath" parameter is to set the path of the json file which defines the resquest body.
        public static RestRequest PutRequest(string headerPath, string token, string bodyPath)
        {
            try
            {
                string readResult = string.Empty;
                restRequest = new RestRequest(RestSharp.Method.PUT);

                var json = File.ReadAllText(headerPath);
                var jobj = JObject.Parse(json);

                if (jobj.ContainsKey(token))
                {
                    string str = jobj[token].ToString();
                    if (str.Contains("Authorization"))
                    {
                        string auth = jobj[token]["Authorization"].ToString();
                        restRequest.AddHeader("Authorization", auth);
                    }
                    if (str.Contains("Content-Type"))
                    {
                        string cont = jobj[token]["Content-Type"].ToString();
                        restRequest.AddHeader("Content-Type", cont);
                    }
                    if (str.Contains("Host"))
                    {
                        string host = jobj[token]["Host"].ToString();
                        restRequest.AddHeader("Host", host);
                    }
                    if (str.Contains("Accept"))
                    {
                        string Accept = jobj[token]["Accept"].ToString();
                        restRequest.AddHeader("Accept", Accept);
                    }
                    if (str.Contains("apikey"))
                    {
                        string apikey = jobj[token]["apikey"].ToString();
                        restRequest.AddHeader("apikey", apikey);
                    }
                    //if (str.Contains("tenant-id"))
                    {
                        //string tenantId = jobj[token]["tenant-id"].ToString();
                        restRequest.AddHeader("tenant-id", tenantId);

                    }

                    if (bodyPath != null)
                    {
                        if (bodyPath.Contains("json"))
                        {
                            var jbody = File.ReadAllText(bodyPath);
                            readResult = jbody.ToString();
                            restRequest.AddJsonBody(readResult);
                        }
                        else
                        {
                            restRequest.AddFile("file", bodyPath);
                        }
                    }

                }
                return restRequest;
            }
            catch (HttpException ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// This method will perform the POST method request
        /// Note that the "headerpath" parameter is to set the path of the json file where the header values are defined.
        /// Note that the "token" parameter is the json token name in the json file under which the required headers values are defined. This will help us in fetch those values.
        /// Note that the "bodypath" parameter is to set the path of the json file which defines the resquest body.
        public static RestRequest PostRequest(string headerPath, string token, string bodyPath)
        {
            try
            {
                string readResult = string.Empty;
                restRequest = new RestRequest(RestSharp.Method.POST);

                var json = File.ReadAllText(headerPath);
                var jobj = JObject.Parse(json);

                if (jobj.ContainsKey(token))
                {
                    string str = jobj[token].ToString();
                    if (str.Contains("Authorization"))
                    {
                        string auth = jobj[token]["Authorization"].ToString();
                        restRequest.AddHeader("Authorization", auth);
                    }
                    if (str.Contains("Content-Type"))
                    {
                        string cont = jobj[token]["Content-Type"].ToString();
                        restRequest.AddHeader("Content-Type", cont);
                    }
                    if (str.Contains("Host"))
                    {
                        string host = jobj[token]["Host"].ToString();
                        restRequest.AddHeader("Host", host);
                    }
                    if (str.Contains("Accept"))
                    {
                        string Accept = jobj[token]["Accept"].ToString();
                        restRequest.AddHeader("Accept", Accept);
                    }
                    if (str.Contains("apikey"))
                    {
                        string apikey = jobj[token]["apikey"].ToString();
                        restRequest.AddHeader("apikey", apikey);
                    }
                    //if (str.Contains("tenant-id"))
                    {
                        //string tenantId = jobj[token]["tenant-id"].ToString();
                        restRequest.AddHeader("tenant-id", tenantId);
                    }

                    if (bodyPath != null)
                    {
                        if (bodyPath.Contains("json"))
                        {
                            var jbody = File.ReadAllText(bodyPath);
                            readResult = jbody.ToString();
                            restRequest.AddJsonBody(readResult);
                        }
                        else
                        {
                            restRequest.AddFile("file", bodyPath);
                        }
                    }

                }

                return restRequest;
            }
            catch (HttpException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// This method will perform the PATCH method request
        /// Note that the "headerpath" parameter is to set the path of the json file where the header values are defined.
        /// Note that the "token" parameter is the json token name in the json file under which the required headers values are defined. This will help us in fetch those values.
        /// Note that the "bodypath" parameter is to set the path of the json file which defines the resquest body.
        public static RestRequest PatchRequest(string headerPath, string token, string bodyPath)
        {
            try
            {
                string readResult = string.Empty;
                restRequest = new RestRequest(RestSharp.Method.PATCH);
                restRequest.RequestFormat = DataFormat.Json;

                var json = File.ReadAllText(headerPath);
                var jobj = JObject.Parse(json);

                if (jobj.ContainsKey(token))
                {
                    string str = jobj[token].ToString();
                    if (str.Contains("Authorization"))
                    {
                        string auth = jobj[token]["Authorization"].ToString();
                        restRequest.AddHeader("Authorization", auth);
                    }
                    if (str.Contains("Content-Type"))
                    {
                        string cont = jobj[token]["Content-Type"].ToString();
                        restRequest.AddHeader("Content-Type", cont);
                    }
                    if (str.Contains("Host"))
                    {
                        string host = jobj[token]["Host"].ToString();
                        restRequest.AddHeader("Host", host);
                    }
                    if (str.Contains("Accept"))
                    {
                        string Accept = jobj[token]["Accept"].ToString();
                        restRequest.AddHeader("Accept", Accept);
                    }
                    if (str.Contains("apikey"))
                    {
                        string apikey = jobj[token]["apikey"].ToString();
                        restRequest.AddHeader("apikey", apikey);
                    }
                    //if (str.Contains("tenant-id"))
                    {
                        //string tenantId = jobj[token]["tenant-id"].ToString();
                        restRequest.AddHeader("tenant-id", tenantId);
                    }
                    var jbody = File.ReadAllText(bodyPath);
                    readResult = jbody.ToString();
                    //restRequest.AddJsonBody(readResult);
                    restRequest.AddParameter("application/json", readResult, ParameterType.RequestBody);
                }

                return restRequest;
            }
            catch (HttpException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// This method will perform the DELETE method request
        /// Note that the "headerpath" parameter is to set the path of the json file where the header values are defined.
        /// Note that the "token" parameter is the json token name in the json file under which the required headers values are defined. This will help us in fetch those values.
        public static RestRequest DeleteRequest(string headerPath, string token)
        {
            try
            {
                string readResult = string.Empty;
                restRequest = new RestRequest(RestSharp.Method.DELETE);
                var json = File.ReadAllText(headerPath);

                var jobj = JObject.Parse(json);
                readResult = json.ToString();

                if (jobj.ContainsKey(token))
                {
                    string str = jobj[token].ToString();
                    if (str.Contains("Authorization"))
                    {
                        string auth = jobj[token]["Authorization"].ToString();
                        restRequest.AddHeader("Authorization", auth);
                    }
                    if (str.Contains("Content-Type"))
                    {
                        string cont = jobj[token]["Content-Type"].ToString();
                        restRequest.AddHeader("Content-Type", cont);
                    }
                    if (str.Contains("Host"))
                    {
                        string host = jobj[token]["Host"].ToString();
                        restRequest.AddHeader("Host", host);
                    }
                    if (str.Contains("Accept"))
                    {
                        string Accept = jobj[token]["Accept"].ToString();
                        restRequest.AddHeader("Accept", Accept);
                    }
                    if (str.Contains("apikey"))
                    {
                        string apikey = jobj[token]["apikey"].ToString();
                        restRequest.AddHeader("apikey", apikey);
                    }
                    //if (str.Contains("tenant-id"))
                    {
                        //string tenantId = jobj[token]["tenant-id"].ToString();
                        restRequest.AddHeader("tenant-id", tenantId);
                    }


                }
                return restRequest;
            }
            catch (HttpException ex)
            {
                throw ex;
            }

        }

        public static RestRequest PostIDServer(string headerPath, string token)
        {
            try
            {
                string readResult = string.Empty;
                restRequest = new RestRequest(RestSharp.Method.POST);

                var json = File.ReadAllText(headerPath);
                var jobj = JObject.Parse(json);
                if (jobj.ContainsKey(token))
                {
                    string str = jobj[token].ToString();
                    if (str.Contains("Authorization"))
                    {
                        string auth = jobj[token]["Authorization"].ToString();
                        restRequest.AddHeader("Authorization", auth);
                    }
                    if (str.Contains("Content-Type"))
                    {
                        string cont = jobj[token]["Content-Type"].ToString();
                        restRequest.AddHeader("Content-Type", cont);
                    }
                    restRequest.AddParameter("grant_type", "client_credentials");
                }
                return restRequest;
            }
            catch (HttpException ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// This method will execute the request and get the response
        public static IRestResponse Response()
        {
            try
            {
                return Client.Execute(restRequest);
            }
            catch (Exception)
            {

                throw restResponse.ErrorException;
            }

        }

        /// <summary>
        /// This method will perform the statuscode verification.
        /// Note that the "statuscode" parameter is to set the exepected response statuscode.
        /// This will vefify if both expected and actual statuscode is matching. If macthes then the case is passed. else, Fail.
        public static RestResponse VerifyStatuscode(int statuscode)
        {
            try
            {
                var response = Response();
                if ((int)response.StatusCode == statuscode)
                {
                    Assert.Pass("The expected status code " + statuscode + " is matching with " + "actual status code " + (int)response.StatusCode);
                }
                else
                {
                    Assert.Fail("The expected status code " + statuscode + " is not matching with " + "actual status code " + (int)response.StatusCode);
                }

                return restResponse;
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }

        /// <summary>
        /// This Method will update or create the selective token value in the JSON file
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="token"></param>
        /// <param name="value"></param>
        public static void WriteTokenToJSON(string filePath, string token, int value)
        {
            string writeResult = string.Empty;
            using (StreamReader r = new StreamReader(filePath))
            {
                var json = r.ReadToEnd();
                var jobj1 = JObject.Parse(json);
                if (jobj1.ContainsKey(token))
                {
                    var rep = jobj1.SelectToken(token);
                    rep.Replace(value);
                    writeResult = jobj1.ToString();

                }
                else
                {
                    JTokenWriter writer = new JTokenWriter();
                    writer.WriteStartObject();
                    writer.WritePropertyName(token);
                    writer.WriteValue(value);
                    writer.WriteEndObject();
                    JObject acc = (JObject)writer.Token;
                    writeResult = acc.ToString();

                }
            }
            File.WriteAllText(filePath, writeResult);
        }

        /// <summary>
        /// Pass the file in that you wish to get the directory for.
        /// Note that this file has to be in the Resources folder
        /// </summary>
        /// <param name="file"></param>
        public static string GetFilePath(string file)
        {
            string workingDir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string newDir = String.Format("{0}\\Resources\\{1}", workingDir, file);
            return newDir;
        }

        public static void AuthTokenWrite(string filePath, string authtoken, string replace)
        {
            try
            {
                string readResult = string.Empty;
                string writeResult = string.Empty;
                var json = File.ReadAllText(filePath);
                var jobj = JObject.Parse(json);
                var rep = jobj["getReq1"].SelectToken(authtoken);
                var rep1 = jobj["PutReq1"].SelectToken(authtoken);
                var rep2 = jobj["PostReqImg"].SelectToken(authtoken);
                var rep3 = jobj["getReq3"].SelectToken(authtoken);
                var rep4 = jobj["PutReq2"].SelectToken(authtoken);
                var rep5 = jobj["PostReqImg1"].SelectToken(authtoken);
                rep.Replace(replace);
                rep1.Replace(replace);
                rep2.Replace(replace);
                rep3.Replace(replace);
                rep4.Replace(replace);
                rep5.Replace(replace);
                writeResult = jobj.ToString();
                File.WriteAllText(filePath, writeResult);
            }


            catch (Exception ex)
            {

                throw ex;
            }

        }

        /// <summary>
        /// This method will write the passed data into the template JSON file which is present
        /// </summary>
        /// <param name="data"></param>
        /// <param name="fileName"></param>
        public static void CreateJSONFile(string data, string fileName)
        {
            try
            {
                JObject Jobj = JObject.Parse(data);
                var result = Jobj.ToString();
                var path = GetFilePath(fileName);
                File.WriteAllText(path, result);
            }
            catch (JsonReaderException)
            {
                JArray Jobj = JArray.Parse(data);
                var result = Jobj.ToString();
                var path = GetFilePath(fileName);
                File.WriteAllText(path, result);

            }

        }

        public static void Authorize(string headerName, string getHeaders, string PostIDSer, string childToken)
        {
            SetUrl(validateTokenEndpoint);
            var headerPath = GetFilePath(headerName);
            GetRequest(headerPath, getHeaders);
            try
            {
                var response = Response();
                if ((int)response.StatusCode != 200)
                {
                    SetUrl(getNewTokenEndpoint);
                    PostIDServer(headerPath, PostIDSer);
                    try
                    {
                        var res = Response();
                        if ((int)res.StatusCode == 200)
                        {
                            JObject Jobj = JObject.Parse(res.Content);
                            var accessToken = "Bearer " + Jobj["access_token"].ToString();
                            AuthTokenWrite(headerPath, childToken, accessToken);
                        }
                    }
                    catch (HttpException ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (HttpException ex)
            {
                throw ex;
            }
        }

        public static void AuthorizeWWP2(string headerName, string getHeaders, string PostIDSer, string childToken)
        {
            SetUrl1(validateTokenEndpoint);
            var headerPath = GetFilePath(headerName);
            GetRequest(headerPath, getHeaders);
            try
            {
                var response = Response();
                if ((int)response.StatusCode != 200)
                {
                    SetUrl1(getNewTokenEndpoint);
                    PostIDServer(headerPath, PostIDSer);
                    try
                    {
                        var res = Response();
                        if ((int)res.StatusCode == 200)
                        {
                            JObject Jobj = JObject.Parse(res.Content);
                            var accessToken = "Bearer " + Jobj["access_token"].ToString();
                            AuthTokenWrite(headerPath, childToken, accessToken);
                        }
                    }
                    catch (HttpException ex)
                    {
                        throw ex;
                    }
                }
            }
            catch (HttpException ex)
            {
                throw ex;
            }
        }

       
    }
}
