using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HttpAuthenticate
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new WebClient();

            // current user credentiaos:
            client.Credentials = CredentialCache.DefaultCredentials;
            // unless it's manual:
            client.Credentials = new NetworkCredential("User", "Password");

            var data = client.DownloadString("https://example.com");

            Console.WriteLine(data);
        }
    }
}
