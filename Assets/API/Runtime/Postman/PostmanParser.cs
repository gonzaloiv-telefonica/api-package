using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json.Linq;

namespace Meta.Api
{

    public static class PostmanParser
    {

        public static List<T> ParseAsList<T>(string response, string uri)
        {
            JObject joResponse = JObject.Parse(response);
            JArray ojObject = (JArray)joResponse["data"][uri.ToString()];
            List<T> entities = ojObject.ToObject<List<T>>();
            return entities;
        }

    }

}
