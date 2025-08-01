using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public static class AfipSoapClient
    {
        public static HttpResponseMessage SendSoapRequestAsync(string soapEnvelope, string soapAction, string url)
        {
            using var client = new HttpClient();
            var content = new StringContent(soapEnvelope, Encoding.UTF8, "text/xml");
            content.Headers.Add("SOAPAction", soapAction);

            return client.PostAsync(url, content).Result;
        }
    }
}
