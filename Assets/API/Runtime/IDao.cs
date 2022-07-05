using System.Collections;
using System.Collections.Generic;
using RSG;
using UnityEngine;

namespace Meta.Api
{

    public interface IDao<T>
    {
        string Uri { get; }
        Promise<T> Get(int id);
        Promise<List<T>> Get();
    }

}
