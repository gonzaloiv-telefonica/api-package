using System.Collections;
using System.Collections.Generic;
using RSG;
using UnityEngine;
using SimpleGraphQL;

namespace Meta.Api
{

    public class ShopifyProductDao : IDao<Product>
    {

        private GraphQLClient client;
        private GraphQLConfig config;

        public string Uri => throw new System.NotImplementedException();

        public ShopifyProductDao(GraphQLClient client, GraphQLConfig config)
        {
            this.client = client;
            this.config = config;
        }

        public Promise<List<Product>> Get()
        {
            Promise<List<Product>> promise = new Promise<List<Product>>();
            GetProducts(promise);
            return promise;
        }

        public async void GetProducts(Promise<List<Product>> promise)
        {
            Query query = client.FindQuery("Product", "GetProducts", OperationType.Query);
            string results = await client.Send(query.ToRequest());
            if (string.IsNullOrEmpty(results))
            {
                promise.Reject(new System.Exception("This request had null result!"));
            }
            else
            {
                promise.Resolve(ShopifyParser.ParseAsList<Product, ShopifyProduct>(results));
            }
        }

        public Promise<Product> Get(int id)
        {
            throw new System.NotImplementedException();
        }

    }

}