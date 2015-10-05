using System.Collections;
using System.Text;
using System.Web;

namespace ScoutAssistant.Views.Helpers
{
    /// <summary>
    /// Exposes a collection of view helper methods specifically for rendering dynamic controls in layouts.
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Builds the navigation section for output into layouts.
        /// </summary>
        /// <returns>
        /// Returns an <see cref="HtmlString" /> containing ready to display HTML for the navigation links; otherwise string.Empty.
        /// </returns>
        public static IHtmlString BuildNavigation()
        {
            string result = string.Empty;
            bool IsRoot = (HttpContext.Current.Request.Url.Segments.Length == 1);
            string ControllerURL = (HttpContext.Current.Request.Url.Segments.Length > 1) ? HttpContext.Current.Request.Url.Segments[1].Replace("/", string.Empty) : string.Empty;
            string ActionURL = (HttpContext.Current.Request.Url.Segments.Length > 2) ? HttpContext.Current.Request.Url.Segments[2].Replace("/", string.Empty) : string.Empty;

            StringBuilder s = new StringBuilder();

            s.AppendLine("<div class=\"navbar-collapse collapse\">\n");
            s.AppendLine("<ul id=\"menu-top\" class=\"nav navbar-nav navbar-right\">\n");

            if (!HttpContext.Current.Request.IsAuthenticated)
            {
                if (ControllerURL == "Account" && ActionURL == "Login")
                    s.AppendLine("<li><a class=\"menu-top-active\" href=\"/Account/Login\">Login</a></li>");
                else
                    s.AppendLine("<li><a href=\"/Account/Login\">Login</a></li>");
            }
            else
            {
                if ((ControllerURL == "Home" && ActionURL == "Index") || IsRoot)
                    s.AppendLine("<li><a class=\"menu-top-active\" href=\"/Home/Index\">Dashboard</a></li>");
                else
                    s.AppendLine("<li><a href=\"/Home/Index\">Dashboard</a></li>");

                if (ControllerURL == "School" && ActionURL == "List")
                    s.AppendLine("<li><a class=\"menu-top-active\" href=\"/School/List\">Schools</a></li>");
                else
                    s.AppendLine("<li><a href=\"/School/List\">Schools</a></li>");

                if (ControllerURL == "Player" && ActionURL == "List")
                    s.AppendLine("<li><a class=\"menu-top-active\" href=\"/Player/List\">Players</a></li>");
                else
                    s.AppendLine("<li><a href=\"/Player/List\">Players</a></li>");

                    s.AppendLine("<li><a href=\"/Account/Logout\">Logout</a></li>");
            }
            s.AppendLine("</ul>\n");
            s.AppendLine("</div>\n");

            result = s.ToString();

            return new HtmlString(result);
        }
    }
}