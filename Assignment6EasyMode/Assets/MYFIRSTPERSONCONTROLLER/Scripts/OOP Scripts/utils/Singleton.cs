﻿/*
 * Adam Field
 * Assignment 6
 * sets up the singleton
 */



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    private static T instance;
    public static T Instance
    {
        get { return instance; }
    }

    public static bool IsInitialized
    {
        get { return instance != null; }
    }

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("[singleton] trying to instantiate a second instance of a single class");
        }
        else
        {
            instance = (T)this;
        }
    }

    protected virtual void OnDestroy()
    {
        //if this object is destroyed, make instance null so another can be created.
        if(instance == this)
        {
            instance = null;
        }
    }
}
