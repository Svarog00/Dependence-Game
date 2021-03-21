using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    public event EventHandler OnPlayerDead;

    private int _playerCount;

    public int PlayerCount
    {
        get { return _playerCount; }
        set { _playerCount = value; }
    }

    private void Awake()
    {
        Instance = this;
        _playerCount = 2;
        
    }

    private void Update()
    {
        if(_playerCount == 0)
        {
            Debug.Log("F");
            OnPlayerDead?.Invoke(this, EventArgs.Empty);
        }
    }

    public bool Revive()
    {
        if (_playerCount == 1)
        {
            Instance.PlayerCount++;
            var temp = ObjectPool.Instance.GetFromPool();
            if (temp.name == "PlayerOne")
                temp.transform.position = new Vector2(transform.position.x + 0.65f, transform.position.y);
            else if (temp.name == "PlayerTwo")
                temp.transform.position = new Vector2(transform.position.x - 0.65f, transform.position.y);
            FindObjectOfType<AudioManager>().Play("Revive");
            return true;
        }
        else return false;
    }
}
