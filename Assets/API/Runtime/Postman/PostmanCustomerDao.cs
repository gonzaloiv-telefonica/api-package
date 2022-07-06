using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using RSG;
using UnityEngine;

namespace Meta.Api
{

    public class PostmanCustomerDao : IDao<Customer>
    {

        protected IRestClient client;
        public string Uri => "customers";

        public PostmanCustomerDao(IRestClient client)
        {
            this.client = client;
        }

        public Promise<List<Customer>> Get()
        {
            return client.Get<Customer, PostmanCustomer>(Uri);
        }

    }

}