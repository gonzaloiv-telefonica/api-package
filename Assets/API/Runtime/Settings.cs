using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using UnityEngine;

namespace Meta.Api
{

    [CreateAssetMenu(fileName = "Meta.Api.Settings", menuName = "Meta/api-client/Settings")]
    public class Settings : ScriptableObject
    {
        public string baseUrl;
        public string token;
    }

}