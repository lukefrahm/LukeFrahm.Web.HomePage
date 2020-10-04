using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using LukeFrahm.Web.HomePage.Models;

namespace LukeFrahm.Web.HomePage.Services
{
    internal static class ApiService
    {
        private static readonly HttpClient HttpClient = new HttpClient();
        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            AllowTrailingCommas = false
        };

        internal static async Task<bool> SendEmailToSelf(Email email)
        {
            try
            {
                StringContent todoItemJson = new StringContent(
                    JsonSerializer.Serialize(email, JsonOptions),
                    Encoding.UTF8,
                    "application/json");

                using HttpResponseMessage httpResponse = await HttpClient.PostAsync("/api/TodoItems", todoItemJson);

                return httpResponse.IsSuccessStatusCode;
            }
            catch
            {
                return false;
            }
        }
    }
}
