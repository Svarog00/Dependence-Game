using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoControl : MonoBehaviour
{
    public int speed;

    public Counter Counter;

    private Vector2 _movement;

    private bool _canMove;

    void Start()
    {
        Counter.OnStartSignal += Counter_OnStartSignal;
    }

    private void Counter_OnStartSignal(object sender, System.EventArgs e)
    {
        _canMove = true;
        Counter.OnStartSignal -= Counter_OnStartSignal;
    }

    // Update is called once per frame
    void Update()
    {
        if(_canMove)
        {
            _movement.x = Input.GetAxisRaw("Horizontal");
            _movement.y = Input.GetAxisRaw("Vertical");
        }
        transform.position += transform.right * _movement.x * Time.deltaTime * speed;
        transform.position += transform.up * _movement.y * Time.deltaTime * speed;
    }
}
