using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleGraphQL;

namespace Meta.Api
{

    public class ShopifySample : MonoBehaviour
    {

        [SerializeField] private GraphQLConfig config;
        private GraphQLClient client;
        [SerializeField] private List<Product> products;

        private void Start()
        {
            this.client = new GraphQLClient(config);
            GetProducts();
        }

        private void GetProducts()
        {
            IDao<Product> dao = new ShopifyProductDao(client, config);
            dao.Get()
                .Then(products => this.products = products)
                .Catch(Debug.LogException);
        }

    }

}
