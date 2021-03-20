using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public static ObjectPool Instance;

    [SerializeField]
    private Queue<GameObject> avialableObjects = new Queue<GameObject>();


    void Awake()
    {
        Instance = this;
        //GrowPool();
    }

    public void AddToPool(GameObject instance)
    {
        instance.SetActive(false);
        avialableObjects.Enqueue(instance);
    }

    public GameObject GetFromPool()
    {
        if (avialableObjects.Count == 0)
            return null;

        var instance = avialableObjects.Dequeue();
        instance.SetActive(true);
        return instance;
    }
}
