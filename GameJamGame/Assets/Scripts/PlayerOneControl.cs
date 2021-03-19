using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneControl : MonoBehaviour
{
    public int speed;

    public Counter Counter;

    public Animator animator;

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
            if(Input.GetKey(KeyCode.RightArrow))
            {
                animator.Play("PlayerOne_Run");
                transform.position += transform.right * speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                animator.Play("PlayerOne_Run");
                transform.position -= transform.right * speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                animator.Play("PlayerOne_Run");
                transform.position += transform.up * speed * Time.deltaTime;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                animator.Play("PlayerOne_Run");
                transform.position -= transform.up * speed * Time.deltaTime;
            }
            else
            {
                animator.Play("PlayerOne_Idle");
            }
        }
    }
}
