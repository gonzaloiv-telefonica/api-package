
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Meta.Api
{

    public class ShopifyProduct : IApiEntity<Product>
    {

        public string id;
        public string title;

        public Product ToEntity()
        {
            Product product = new Product();
            product.id = id;
            product.name = title;
            return product;
        }

    }

}