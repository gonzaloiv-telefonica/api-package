using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;

namespace Meta.Api
{

    public static class ShopifyParser
    {

        public static List<T> ParseAsList<T, A>(string results) where T : BaseEntity, new() where A : IApiEntity<T>, new()
        {
            JObject response = JObject.Parse(results);
            JArray objs = (JArray)response["data"]["products"]["edges"];
            List<T> entities = new List<T>();
            foreach (JObject obj in objs)
            {
                A apiEntity = obj["node"].ToObject<A>();
                entities.Add(apiEntity.ToEntity());
            }
            return entities;
        }

    }

}