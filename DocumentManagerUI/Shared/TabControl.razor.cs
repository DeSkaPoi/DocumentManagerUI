using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.Web.Virtualization;
using Microsoft.AspNetCore.Components.WebAssembly.Http;
using Microsoft.JSInterop;
using DocumentManagerUI;
using DocumentManagerUI.Pages;
using DocumentManagerUI.Shared;
using Blazorise;


namespace DocumentManagerUI.Shared
{
    public partial class TabControl
    {
        public TabPage ActivePage { get; set; }
        List<TabPage> Pages = new List<TabPage>();
        internal void AddPage(TabPage tabPage)
        {
            Pages.Add(tabPage);
            if (Pages.Count == 1)
                ActivePage = tabPage;
            StateHasChanged();
        }

        string GetButtonClass(TabPage page)
        {
            return page == ActivePage ? "buttonClass barButtomActive" : "buttonClass barButtom";
        }

        void ActivatePage(TabPage page)
        {
            ActivePage = page;
        }

        IconName IconMade(string name)
        {
            if (name == "Files")
            {
                return IconName.FileAlt;
            }
            else if (name == "Documents")
            {
                return IconName.Folder;
            }
            else if (name == "Pictures")
            {
                return IconName.TicketAlt;
            }
            else return IconName.Video;
        }
    }
}
