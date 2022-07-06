using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleGraphQL;

namespace Meta.Api
{

    public class DaoContainerSample : MonoBehaviour
    {

        [Header("Postman")]
        public Settings settings;
        public List<Customer> customers;

        [Header("Shopify")]
        [SerializeField] private GraphQLConfig config;
        [SerializeField] private List<Product> products;

        private DaoContainer container;

        private void Start()
        {

            this.container = new DaoContainer();

            IRestClient restClient = new PostmanClient(settings);
            IDao<Customer> customerDao = new PostmanCustomerDao(restClient);
            container.Register(customerDao);

            GraphQLClient graphQLClient = new GraphQLClient(config);
            IDao<Product> productDao = new ShopifyProductDao(graphQLClient, config);
            container.Register(productDao);

            LoadData();

        }

        private void LoadData()
        {
            container.Get<Product>()
                .Then(products => this.products = products)
                .Catch(Debug.LogException);
            container.Get<Customer>()
                .Then(customers => this.customers = customers)
                .Catch(Debug.LogException);
        }

    }

}