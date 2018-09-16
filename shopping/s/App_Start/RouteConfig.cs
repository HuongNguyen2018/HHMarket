using System.Web.Mvc;
using System.Web.Routing;

namespace s
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "Index", id = UrlParameter.Optional }
            );
            routes.MapRoute(
                name: "RegisterAccount",
                url: "{controller}/{action}",
                defaults: new { controller = "User", action = "RegisterAccount" }
       );


            //routes.MapRoute(
                            //    name: "Student",
                            //    url: "student/{id}/{name}/{standardId}",
                            //    defaults: new { controller = "Student", action = "Index", id = UrlParameter.Optional, name = UrlParameter.Optional, standardId = UrlParameter.Optional },
                            //    constraints: new { id = @"\d+" }
                            //);

            //routes.MapRoute(
            //       name: "UserListScreen",
            //       url: "{controller=User}/{action=ShowUserList}");
            //routes.MapRoute(
            //name: "RegisterAccount",
            //url: "{controller=User}/{action=RegisterAccount}/{id?}");
            //routes.MapRoute(
            //    name: "UserLoginScreen",
            //    url: "{controller=User}/{action=Index}");
            //routes.MapRoute(
            //name: "UserLogin",
            //url: "User/Login/{username?}/{password?}");
        }
    }
}
