using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(meetup_trial_net.Startup))]
namespace meetup_trial_net
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
