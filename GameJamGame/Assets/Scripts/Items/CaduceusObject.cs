using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaduceusObject : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Caduceus.Instance.AddCaduceus();
        }
    }
}
