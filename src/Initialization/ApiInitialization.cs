using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using System.Web.Http;

namespace EPiGraphQL.Api.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(FrameworkInitialization))]
    public class ApiInitialization : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            GlobalConfiguration.Configure(config =>
            {
                if (!config.Routes.ContainsKey("MS_attributerouteWebApi"))
                {
                    config.MapHttpAttributeRoutes();
                }
            });
        }

        public void Uninitialize(InitializationEngine context)
        {
        }
    }
}
