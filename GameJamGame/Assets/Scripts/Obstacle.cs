using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            ObjectPool.Instance.AddToPool(collision.gameObject);
            Health.Instance.DecreaseHealth();
            PlayerManager.Instance.PlayerCount--;
        }
    }
}
