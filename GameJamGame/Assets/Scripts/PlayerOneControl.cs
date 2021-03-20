using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneControl : MonoBehaviour
{
    public int speed;

    public Counter Counter;

    public Animator animator;

    private bool _canMove;

    private Vector2 _movement;

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
            _movement.x = Input.GetAxisRaw("HorizontalTwo");
            _movement.y = Input.GetAxisRaw("VerticalTwo");
            if (_movement.y != 0 || _movement.x != 0)
            {
                animator.Play("PlayerOne_Run");
            }
            else
            {
                animator.Play("PlayerOne_Idle");
            }
        }
        transform.position += transform.right * _movement.x * Time.deltaTime * speed;
        transform.position += transform.up * _movement.y * Time.deltaTime * speed;
    }
}
