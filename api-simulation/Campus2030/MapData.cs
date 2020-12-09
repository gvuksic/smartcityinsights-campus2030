using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Campus2030
{
    public static class MapData
    {
        [FunctionName("MapData")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log, ExecutionContext context)
        {
            try
            {
                Index index;
                var indexPath = Path.Combine(context.FunctionAppDirectory, "Index.json");
                using (StreamReader file = File.OpenText(indexPath))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o2 = (JObject)JToken.ReadFrom(reader);
                    index = o2.ToObject<Index>();
                }

                string fileName = "Data.json";
                var direct = Directory.GetCurrentDirectory();
                string path = Path.Combine(context.FunctionAppDirectory, fileName);

                Root root;
                using (StreamReader file = File.OpenText(path))
                using (JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject o2 = (JObject)JToken.ReadFrom(reader);
                    root = o2.ToObject<Root>();
                }

                int finalIndex = 0;
                try
                {
                    finalIndex = int.Parse(index.index);
                }
                catch (Exception)
                {
                }
                if (finalIndex == root.items.Count)
                {
                    finalIndex = 0;
                }
                index.index = (++finalIndex).ToString();


                using (StreamWriter file = File.CreateText(indexPath))
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    JObject.FromObject(index).WriteTo(writer);
                }

                return new OkObjectResult(root.items[finalIndex - 1]);
            }
            catch (Exception ex)
            {

                return new OkObjectResult(ex.Message);
            }

        }
    }
}
