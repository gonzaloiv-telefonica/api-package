using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Meta.Api
{

    public interface IApiEntity<B> where B : BaseEntity, new()
    {
        B ToEntity();
    }

}