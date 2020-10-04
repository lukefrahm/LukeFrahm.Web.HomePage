using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LukeFrahm.Web.HomePage.Models
{
    public static class Terminal
    {
        public static string HtmlTab => "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
        public static string HtmlBreak => "<br />";

        public static string ConsoleHelpMenu =>
            $"COMMANDS{HtmlBreak}" +
            $"{HtmlTab}nav: Navigates to the selected resource.{HtmlBreak}" +
            $"{HtmlTab}navigate: Navigates to the selected resource.{HtmlBreak}" +
            $"{HtmlTab}cls: Clears the terminal window.{HtmlBreak}" +
            $"{HtmlTab}clear: Clears the terminal window.{HtmlBreak}" +
            $"{HtmlTab}echo: Displays the entered test on screen.{HtmlBreak}";

        public static string HelpNav => CreateCommandHelpString(
                command:     "nav",
                synopsis:    "nav [...]",
                description: "Navigates to the selected resource.",
                options:     "None.",
                otherInfo:   "navigate"
        );

        public static string HelpNavigate => CreateCommandHelpString(
                command:     "navigate",
                synopsis:    "nav [...]",
                description: "Navigates to the selected resource.",
                options:     "None."
            );

        public static string CreateCommandHelpString(string command, string synopsis, string description, string options, string otherInfo = null)
        {
            return
                $"NAME{HtmlBreak}" +
                $"{HtmlTab}{command}{HtmlBreak}" +
                $"SYNOPSIS{HtmlBreak}" +
                $"{HtmlTab}{synopsis}{HtmlBreak}" +
                $"DESCRIPTION{HtmlBreak}" +
                $"{HtmlTab}{description}{HtmlBreak}" +
                $"OPTIONS{HtmlBreak}" +
                $"{HtmlTab}{options}{HtmlBreak}" +
                $"SEE ALSO{HtmlBreak}" +
                $"{HtmlTab}{otherInfo ?? "None."}";
        }
    }
}
