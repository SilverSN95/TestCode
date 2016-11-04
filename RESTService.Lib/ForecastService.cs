using System.Text;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Net;
using System.IO;
using System.ServiceModel.Web;
using RESTService.Lib;

namespace WebService.Lib
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Single, IncludeExceptionDetailInFaults = true)]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ForecastService:IForecastService
    {

        public Stream HelloWorld()
        {
            string HELLO_WORLD =  "HELLO WORLD!!";

            WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
            return new MemoryStream(Encoding.UTF8.GetBytes(HELLO_WORLD));
        }

        public Stream getForecastIO()
        {
            WebRequest request = WebRequest.Create("https://api.forecast.io/forecast/" + Constants.FORECAST_IO_KEY + '/' + Constants.NEWARK_LAT + ',' + Constants.NEWARK_LON);

            return returnStreamFromService(request);
        }

        public Stream getForecastWU()
        {
            WebRequest request = WebRequest.Create("http://api.wunderground.com/api/" + Constants.FORECAST_WU_KEY + "/forecast10day/q/DE/Newark.json");

            return returnStreamFromService(request);
        }

        private Stream returnStreamFromService(WebRequest request)
        {
            request.ContentType = "application/json";

            Stream objStream = request.GetResponse().GetResponseStream();

            using (var reader = new StreamReader(objStream, Encoding.UTF8))
            {
                WebOperationContext.Current.OutgoingResponse.ContentType = "application/json; charset=utf-8";
                return new MemoryStream(Encoding.UTF8.GetBytes(reader.ReadToEnd()));
            }
        }


    }
}
