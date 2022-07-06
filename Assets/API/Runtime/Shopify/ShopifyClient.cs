using System.Collections;
using System.Collections.Generic;
using RSG;
using UnityEngine;
using SimpleGraphQL;

namespace Meta.Api
{

    public class ShopifyClient
    {

        private Settings settings;
        private GraphQLClient graphQLClient;

        public ShopifyClient(Settings settings)
        {
            this.settings = settings;
            this.graphQLClient = new GraphQLClient(settings.baseUrl);
        }

    }

}