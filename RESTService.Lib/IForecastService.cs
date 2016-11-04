using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.IO;

namespace WebService.Lib
{
    [ServiceContract(Name = "RESTDemoServices")]
    public interface IForecastService
    {
        [OperationContract]
        [WebGet(UriTemplate = Routing.HelloWorldRoute, ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        Stream HelloWorld();

        [OperationContract]
        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, UriTemplate = Routing.GetForecastIORoute)]
        Stream getForecastIO();

        [WebGet(BodyStyle = WebMessageBodyStyle.Bare, ResponseFormat = WebMessageFormat.Json, UriTemplate = Routing.GetForecastWURoute)]
        Stream getForecastWU();
    }
}
