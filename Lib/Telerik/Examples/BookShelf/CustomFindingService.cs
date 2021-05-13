using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using FindingAPI_WebApp_Sample.com.ebay.developer;

namespace BookShelf
{
    public class CustomFindingService : FindingService
    {
        protected override WebRequest GetWebRequest(Uri uri)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)base.GetWebRequest(uri);
                request.Headers.Add("X-EBAY-SOA-SECURITY-APPNAME", "askme115e-b184-4942-93d7-14c64620781"); //this is my app name 
                request.Headers.Add("X-EBAY-SOA-OPERATION-NAME", "findItemsByCategory");
                request.Headers.Add("X-EBAY-SOA-SERVICE-NAME", "FindingService");
                request.Headers.Add("X-EBAY-SOA-MESSAGE-PROTOCOL", "SOAP11");
                request.Headers.Add("X-EBAY-SOA-SERVICE-VERSION", "1.0.0");
                request.Headers.Add("X-EBAY-SOA-GLOBAL-ID", "EBAY-US");
                return request;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
