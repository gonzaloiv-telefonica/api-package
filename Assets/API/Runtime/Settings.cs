using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;

namespace Meta.Api
{

    [CreateAssetMenu(fileName = "ApiSettings", menuName = "Xoia/ApiClient/ApiSettings")]
    public class Settings : ScriptableObject
    {
        public string baseUrl;
        public string token;
    }

}