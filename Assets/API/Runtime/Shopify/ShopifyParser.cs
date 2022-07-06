using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;

namespace Meta.Api
{

    public static class ShopifyParser
    {

        public static List<T> ParseAsList<T>(string results)
        {
            JObject response = JObject.Parse(results);
            JArray objs = (JArray)response["data"]["products"]["edges"];
            List<T> entities = new List<T>();
            foreach (JObject obj in objs)
            {
                entities.Add(obj["node"].ToObject<T>());
            }
            return entities;
        }

    }

}