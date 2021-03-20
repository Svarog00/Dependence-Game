using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
        Health.Instance.OnHeartChanged += Instance_OnHeartChanged;
    }

    private void Instance_OnHeartChanged(object sender, Health.OnHeartChangedEventAgrs e)
    {
        Destroy(this);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Health.Instance.RestoreHealth();
            
        }
    }
}
