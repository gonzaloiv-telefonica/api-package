using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;
using RSG;
using Proyecto26;
using UnityEngine;

namespace Meta.Api
{

    /// <summary>
    /// Works as an adapter for RestClient adding the conversion to business logic entities
    /// </summary>
    public class PostmanClient : IRestClient
    {

        private Settings settings;

        public PostmanClient(Settings settings)
        {
            this.settings = settings;
        }

        public virtual Promise<List<T>> Get<T>(string uri)
        {
            Promise<List<T>> promise = new Promise<List<T>>();
            RequestHelper requestHelper = new RequestHelper();
            requestHelper.Uri = settings.baseUrl + "/" + uri;
            RestClient.Get(requestHelper)
                .Then(response => PostmanParser.ParseAsList<T>(response.Text, uri))
                .Catch(promise.Reject);
            return promise;
        }

        public Promise<T> Get<T>(string uri, int id)
        {
            throw new System.NotImplementedException();
        }

    }

}