using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour, IActivatable
{
    int _count;

    public void Activate()
    {
        RaycastHit2D[] raycast = Physics2D.RaycastAll(transform.position, transform.up);
        foreach(var hit in raycast)
        {
            if(hit.collider.CompareTag("Door"))
            {
                var door = hit.collider.GetComponent<Door>();
                door.Open();
                break;
            }
        }
    }
}
