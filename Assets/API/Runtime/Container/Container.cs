using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RSG;

namespace Meta.Api
{

    public class Container : Locator
    {

        public virtual void Register<T>(IDao<T> dao)
        {
            base.Register<T>(dao);
        }

        public virtual Promise<List<T>> Get<T>()
        {
            return For<T>().Get();
        }

        protected virtual IDao<T> For<T>()
        {
            return GetElement<T>() as IDao<T>;
        }

    }

}