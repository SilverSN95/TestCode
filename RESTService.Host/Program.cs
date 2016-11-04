using System;
using WebService.Lib;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;

namespace WebService.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ForecastService DemoServices = new ForecastService();
            WebHttpBinding binding = new WebHttpBinding();
            WebHttpBehavior behavior = new WebHttpBehavior();

            WebServiceHost _serviceHost = new WebServiceHost(DemoServices, new Uri("http://localhost:8000/DEMOService"));
            _serviceHost.AddServiceEndpoint(typeof(IForecastService), binding, "");
            _serviceHost.Open();
            Console.ReadKey();
            _serviceHost.Close();
        }
    }
}
