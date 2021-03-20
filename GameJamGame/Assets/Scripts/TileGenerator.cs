using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    public GameObject tilePrefab;
    public float shift = 0;

    // Start is called before the first frame update
    void Start()
    {
        //subscribe on door open event
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        {
            SpawnTile();
        }
    }

    void SpawnTile()
    {
        //Instantiate(tilePrefab, transform.up*shift, transform.rotation);
        Instantiate(tilePrefab, new Vector2(transform.position.x, transform.position.y+shift), transform.rotation);
    }
}
