using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Web.Configuration;

namespace WebConfig
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string logFile = WebConfigurationManager.AppSettings["LogFile"];
            Response.Write(String.Format("<p>LogFile: {0}</p>", logFile));
            ConnectionStringSettings connString = WebConfigurationManager.ConnectionStrings["ProdServer"];
            Response.Write(String.Format("<p>Connection String: {0}</p>", connString.ConnectionString));
        }
    }
}