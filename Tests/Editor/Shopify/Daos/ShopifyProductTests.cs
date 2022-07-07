using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Meta.Api;

namespace Meta.Api
{

    public class ShopifyProductTests
    {

        private const string id = "Id";
        private const string name = "Name";

        private ShopifyProduct shopifyProduct;

        [SetUp]
        public void TestSetup()
        {
            shopifyProduct = new ShopifyProduct();
            shopifyProduct.id = id;
            shopifyProduct.title = name;
        }

        [Test]
        public void ToEntityReturnsValidEntity()
        {
            Product product = shopifyProduct.ToEntity();
            Assert.AreEqual(id, product.id, "Incorrect info was returned for product");
            Assert.AreNotEqual(name, product.name, "Incorrect info was returned for product");
        }

    }

}