using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Meta.Api
{

    public class ShopifySample : MonoBehaviour
    {

        public Settings settings;
        public List<Customer> customers;

        private void Start()
        {
            GetProducts();
        }

        private void GetProducts()
        {
            IClient client = new ShopifyClient(settings); // One client for all the needed DAOs 
            // IDao<Customer> dao = new PostmanCustomerDao(client);
            // dao.Get()
            //     .Then(customers =>
            //     {
            //         this.customers = customers;
            //     })
            //     .Catch(Debug.LogException);
        }

    }

}
