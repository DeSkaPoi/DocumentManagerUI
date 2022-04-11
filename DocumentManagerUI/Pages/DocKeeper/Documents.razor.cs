using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace DocumentManagerUI.Pages.DocKeeper
{
    public partial class Documents
    {
    }

    public static class Extension
    {
        public static async Task<string> GetPayload(this HttpResponseMessage message)
        {
            var responseContent = await message.Content.ReadAsStreamAsync();
            StreamReader reader = new StreamReader(responseContent);
            var payload = reader.ReadToEnd();
            return payload;
        }
    }
}
