using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileGenerator : MonoBehaviour
{
    public GameObject[] tilePrefab;
    public float shift = 0;

    private bool isActivated = false;

    // Start is called before the first frame update
    void Start()
    {
        //subscribe on door open event
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && !isActivated)
        {
            SpawnTile();
        }
    }

    void SpawnTile()
    {
        //Instantiate(tilePrefab, transform.up*shift, transform.rotation);
        Instantiate(tilePrefab[Random.Range(0,tilePrefab.Length)], new Vector2(transform.position.x, transform.position.y+shift), transform.rotation);
        isActivated = true;
    }
}
