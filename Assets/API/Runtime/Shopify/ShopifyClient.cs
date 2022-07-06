using System.Collections;
using System.Collections.Generic;
using RSG;
using UnityEngine;

namespace Meta.Api
{

    public class ShopifyClient : IClient
    {

        private Settings settings;

        public ShopifyClient(Settings settings)
        {
            this.settings = settings;
        }

        public Promise<List<T>> Get<T>(string uri)
        {
            throw new System.NotImplementedException();
        }

        public Promise<T> Get<T>(string uri, int id)
        {
            throw new System.NotImplementedException();
        }

    }

}