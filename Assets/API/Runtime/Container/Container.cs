using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RSG;

namespace Meta.Api
{

    public class Container : Locator
    {

        private Client client;

        public Container(Client client)
        {
            this.client = client;
        }

        public virtual void Register<T>(IDao<T> dao)
        {
            base.Register<T>(dao);
            dao.Client = client;
        }

        protected virtual IDao<T> For<T>()
        {
            return Get<T>() as IDao<T>;
        }

        public virtual Promise<T> Get<T>(int id)
        {
            return For<T>().Get(id);
        }

    }

}