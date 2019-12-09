using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;
using WebApplication3.ServiceReference1;

namespace WebApplication3.Helpers
{
    public static class SapConnector
    {
        public static Z_ABRANTES_SERVICESClient Client()
        {
            BasicHttpBinding binding = new BasicHttpBinding();
            binding.Security.Mode = BasicHttpSecurityMode.TransportCredentialOnly;
            binding.Security.Transport.ClientCredentialType = HttpClientCredentialType.Basic;
            EndpointAddress endpoint = new EndpointAddress("http://vhcalnplci:8000/sap/bc/srt/rfc/sap/z_abrantes_services/001/zabrantesservices/abrantesservices");
            Z_ABRANTES_SERVICESClient client = new Z_ABRANTES_SERVICESClient(binding, endpoint);

            client.ClientCredentials.UserName.UserName = "USER_REST";
            client.ClientCredentials.UserName.Password = "Test02";
            return client;
        }
    }
}