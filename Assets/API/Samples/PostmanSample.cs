using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Meta.Api
{

    public class PostmanSample : MonoBehaviour
    {

        public Settings settings;
        public List<Customer> customers;

        private void Start()
        {
            GetCustomers();
        }

        private void GetCustomers()
        {
            IClient client = new PostmanClient(settings); // One client for all the needed DAOs 
            IDao<Customer> dao = new PostmanCustomerDao(client);
            dao.Get()
                .Then(customers =>
                {
                    this.customers = customers;
                })
                .Catch(Debug.LogException);
        }

    }

}
