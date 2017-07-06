using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HelloAngular2.Startup))]
namespace HelloAngular2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
          
        }
    }
}
