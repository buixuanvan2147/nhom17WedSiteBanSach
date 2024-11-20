using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using DotNetEnv;

namespace nhom17WedsiteBanSach
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            // Tải file .env
            Env.Load();

            // Lấy chuỗi kết nối cơ sở dữ liệu từ file .env
            string connectionString = Env.GetString("DB_CONNECTION");

            // Cập nhật chuỗi kết nối trong Web.config
            System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString = connectionString;


            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
