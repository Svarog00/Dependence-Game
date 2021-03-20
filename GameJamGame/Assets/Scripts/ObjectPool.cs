using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    public GameObject prefab;
    public static ObjectPool Instance;

    [SerializeField]
    private Queue<GameObject> avialableObjects = new Queue<GameObject>();


    void Awake()
    {
        Instance = this;
        //GrowPool();
    }

    private void GrowPool()
    {
        for(int i = 0; i < 2; i++)
        {
            var instanceToAdd = Instantiate(prefab);
            instanceToAdd.transform.SetParent(transform);
            AddToPool(instanceToAdd);
        }
    }

    public void AddToPool(GameObject instance)
    {
        instance.SetActive(false);
        avialableObjects.Enqueue(instance);
    }

    public GameObject GetFromPool()
    {
        if (avialableObjects.Count == 0)
            GrowPool();

        var instance = avialableObjects.Dequeue();
        instance.SetActive(true);
        return instance;
    }
}
