using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadPointsSpawn : MonoBehaviour
{
    public Transform[] spawnPoints = new Transform[9];

    public GameObject[] prefabs;

    private int _numOfPoints;
    private float _weight;
    // Start is called before the first frame update
    void Start()
    {
        _numOfPoints = Random.Range(0, 6);
        for(int i = 0; i < _numOfPoints; i++)
        {
            Instantiate(generateObject(), spawnPoints[i]);
        }
    }

    GameObject generateObject()
    {
        _weight = Random.Range(0f, 100f);
        if (_weight >= 0f && _weight < 35f)
        {
            return prefabs[0]; //yama || spikes
        }
        else if (_weight >= 35f && _weight < 71f)
        {
            return prefabs[1]; //yama || spikes
        }
        else if (_weight >= 71f && _weight < 83.5f)
        {
            return prefabs[2]; //heart || caduceus
        }
        else if (_weight >= 83.5f && _weight < 88.5f)
        {
            return prefabs[3]; //key
        }
        else if (_weight >= 88.5f && _weight < 100f)
        {
            return prefabs[4]; //heart || caduceus
        }
        else return null;
    }
}
