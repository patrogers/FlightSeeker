using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FlightSeeker.Core
{
    public class JetStarLookUp: ILookUp
    {
        private string HttpRequest()
        {
            // Create a request for the URL. 
            HttpWebRequest request = (HttpWebRequest) HttpWebRequest.Create(
              "http://booknow.jetstar.com/Select.aspx");
            
            //Create Cookie Container//

            request.CookieContainer = new CookieContainer();

            Uri target = new Uri("http://booknow.jetstar.com/");

            

            //Start Cookies//
            request.CookieContainer.Add(new Cookie("superT_v1", "1415788473426.556016%3A1%3A1%3A1"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("optimizelyEndUserId", "oeu1415788474481r0.47265329607762396"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("SiteCore_POS", "Australia"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("Country_POS", "au-en"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("loc-pref", "SYD"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("AMCV_8D0D1C8B532B54B40A490D4D%40AdobeOrg", "136688995%7CMCMID%7C34875390915085752740800242808674835740%7CMCAAMLH-1416393278%7C8%7CMCAID%7CNONE"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("txtOrigin#02", "Melbourne%20%28all%20airports%29%20%28VIZ%29"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("txtOriginCityCode#02", "VIZ%7CMEL"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("txtDestination#02", "Adelaide%20%28ADL%29"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("txtDestinationCityCode#02", "ADL"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("txtDepart#02", "13/11/2014"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("txtReturn#02", "14/11/2014"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("ddlCurrency#02", "null"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("ddlAdults#02", "1"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("ddlKids#02", "0"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("rdoFlightTypeReturn#02", "checked"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("rdoFlightTypeOneWay#02", "undefined"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("rdoTravelPrefFixed#02", "checked"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("rdoTravelPrefCheap#02", "undefined"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("compactSearchSubmit#02", "1415788584820"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("j30RecSrc1#02", "typ%3D2%7C%7Corg%3DVIZ%7CMEL%7C%7Cdst%3DADL%7C%7Cout%3D13/11/2014%7C%7Crtn%3D14/11/2014%7C%7Ca%3D1%7C%7Cc%3D0%7C%7Ci%3D0%7C%7Cpref%3D1%7C%7C"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("ASP.NET_SessionId", "rx4lcz55vuzk1i45gkv55v55"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("skysales", "454287882.20480.0000"){ Domain = target.Host });
//request.CookieContainer.Add(new Cookie("user-location", "country_code", "AU,region_code", "NSW,city", "SYDNEY,lat", "-33.88,long", "151.22"){ Domain = target.Host });//
request.CookieContainer.Add(new Cookie("jumpseat_uid", "vuZU8aF5LnUdveyCUZTRBKN"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("jumpseat_ab_watch_price_visible_20140826", "true"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("s_nr", "1415788599440"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("session_start_time", "1415793558695"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("k_visit", "1"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("__utmt", "1"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("superT_s1", "1415793556052.449899"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("superT_v1", "1415788473426.556016%3A1%3A2%3A2"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("optimizelySegments", "%7B%221769861189%22%3A%22gc%22%2C%221772450570%22%3A%22false%22%2C%221782270528%22%3A%22referral%22%2C%222159600287%22%3A%22none%22%7D"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("optimizelyBuckets", "%7B%7D"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("multitabtimestamp", "1415793565910.07"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("__utma", "20450727.1126825626.1415788472.1415788472.1415793557.2"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("__utmb", "20450727.2.10.1415793557"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("__utmc", "20450727"){ Domain = target.Host });
            // request.CookieContainer.Add(new Cookie("__utmz", "20450727.1415788472.1.1.utmcsr", "(direct)|utmccn", "(direct)|utmcmd", "(none)"){ Domain = target.Host });//
request.CookieContainer.Add(new Cookie("s_cc", "true"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("s_fid", "07E207C2BFC52FBB-32D2EF039BA159CE"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("gpv_pn", "%2Fsearch.aspx"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("gpv_v1", "%2Fbooking-flow"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("34092332-VID", "111690767819303"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("34092332-SKEY", "3777238496681694835"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("HumanClickSiteContainerID_34092332", "STANDALONE"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("s_sq", "jetstarprd%3D%2526pid%253D%25252Fsearch.aspx%2526pidt%253D1%2526oid%253DSearch%252520for%252520Flights%2526oidt%253D3%2526ot%253DSUBMIT"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("skySearchSubmit", "1415793610065"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("RadioButtonMarketStructure@en-au", "RoundTrip"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("TextBoxMarketOrigin1@en-au", "Melbourne%20%28all%20airports%29%20%28VIZ%29"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("TextBoxMarketDestination1@en-au", "Sydney%20%28SYD%29"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("TextboxDepartureDate1@en-au", "13/11/2014"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("TextboxDestinationDate1@en-au", "14/11/2014"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("ADT@en-au", "1"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("CHD@en-au", "0"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("INFANT@en-au", "0"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("RadioButtonSearchBy@en-au", "SearchStandard"){ Domain = target.Host });
request.CookieContainer.Add(new Cookie("sessionculture", "en-AU"){ Domain = target.Host });
            //End Cookies//

            // If required by the server, set the credentials.
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response = request.GetResponse();
            // Display the status.
            Console.WriteLine(((HttpWebResponse)response).StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Display the content.
            // Clean up the streams and the response.
            reader.Close();
            response.Close();
            return responseFromServer;

        }
        public string GetData ()
        {
            var result = HttpRequest();
            return result;
        }
    }
}
