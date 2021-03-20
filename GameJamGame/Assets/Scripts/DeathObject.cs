using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathObject : MonoBehaviour
{
    public float speed;
    private bool _canMove = false;

    // Start is called before the first frame update
    void Start()
    {
        Counter counter = FindObjectOfType<Counter>();
        counter.OnStartSignal += Counter_OnStartSignal;
    }

    private void Counter_OnStartSignal(object sender, System.EventArgs e)
    {
        _canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(_canMove)
            transform.position += transform.up * Time.deltaTime * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            PlayerManager.Instance.PlayerCount--;
        }
    }
}
