using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Meta.Api
{

    public class Test : MonoBehaviour
    {

        public List<Customer> customers;

        private void Start()
        {
            GetCustomers();
        }

        private void GetCustomers()
        {
            Settings settings = ScriptableObject.CreateInstance<Settings>();
            settings.baseUrl = "https://01c19f0d-b0f5-46cd-9acf-c0af4d8ce1ae.mock.pstmn.io";
            IClient client = new PostmanClient(settings);
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
