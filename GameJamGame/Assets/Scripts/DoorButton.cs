using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DoorButton : MonoBehaviour
{
    public event EventHandler OnButtonPressed;

    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            FindObjectOfType<AudioManager>().Play("Open");
            OnButtonPressed?.Invoke(this, EventArgs.Empty);
            animator.Play("DoorButton_Pressed");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            animator.Play("DoorButton_Idle");
        }
    }
}
