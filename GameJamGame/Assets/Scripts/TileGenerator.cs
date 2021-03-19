using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    public TileGenerator Instance;
    public GameObject[] tilePrefabs;
    public float shift = 0;

    // Start is called before the first frame update
    void Start()
    {
        //subscribe on door open event
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTile()
    {
        Instantiate(tilePrefabs[Random.Range(0, tilePrefabs.Length)], transform.forward*shift, transform.rotation);
    }
}
