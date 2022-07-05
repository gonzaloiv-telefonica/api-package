﻿using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using RSG;
using UnityEngine;

namespace Meta.Api
{

    public class PostmanCustomerDao : IDao<Customer>
    {

        protected IClient client;
        public string Uri => "customers";

        public PostmanCustomerDao(IClient client)
        {
            this.client = client;
        }

        public Promise<List<Customer>> Get()
        {
            return client.Get<Customer>(Uri);
        }

        public Promise<Customer> Get(int id)
        {
            return client.Get<Customer>(Uri, id);
        }

    }

}