﻿using System;
using System.Collections;
using System.Collections.Generic;
using Proyecto26;
using RSG;
using UnityEngine;

namespace Meta.Api
{

    public interface IClient
    {
        Settings Settings { get; }
        Promise<List<T>> Get<T>(string uri);
        Promise<T> Get<T>(string uri, int id);
    }

}