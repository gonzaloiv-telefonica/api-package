using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using RSG;
using Proyecto26;
using UnityEngine;

namespace Meta.Api
{

    public class PostmanClient : IClient
    {

        public Settings Settings { get; private set; }

        public PostmanClient(Settings settings)
        {
            Settings = settings;
        }

        public virtual Promise<List<T>> Get<T>(string uri)
        {

            Promise<List<T>> promise = new Promise<List<T>>();
            RequestHelper requestHelper = new RequestHelper();
            requestHelper.Uri = Settings.baseUrl + "/" + uri;
            RestClient.Get(requestHelper)
                .Then(result =>
                {
                    JObject joResponse = JObject.Parse(result.Text);
                    JArray ojObject = (JArray)joResponse["data"][uri.ToString()];
                    List<T> entities = ojObject.ToObject<List<T>>();
                    promise.Resolve(entities);

                })
                .Catch(promise.Reject);
            return promise;
        }

        public Promise<T> Get<T>(string uri, int id)
        {
            throw new System.NotImplementedException();
        }

    }

}