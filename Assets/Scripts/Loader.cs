using System;
using System.Collections;
using System.Collections.Generic;
using TriLibCore;
using UnityEngine;

public class Loader : MonoBehaviour
{
    void Start()
    {
        var options = AssetLoader.CreateDefaultLoaderOptions();
        Action<AssetLoaderContext> onLoaded = context =>
        {
            Debug.Log("Loaded model.");
        };

        Action<IContextualizedError> onError = error =>
        {
            Debug.Log("Failed to load model.");
        };
        AssetLoader.LoadModelFromFile("Bla.fbx", null, onLoaded, null, onError, null, options);
    }
}
