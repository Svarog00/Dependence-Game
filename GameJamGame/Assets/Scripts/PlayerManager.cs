﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager Instance;

    private int _playerCount;

    public int PlayerCount
    {
        get { return _playerCount; }
        set { _playerCount = value; }
    }

    private void Start()
    {
        Instance = this;
        _playerCount = 2;
        
    }

    private void Update()
    {
        if(_playerCount == 0)
        {
            Debug.Log("F");
        }
    }

    public void Revive()
    {
        Instance.PlayerCount++;
        var temp = ObjectPool.Instance.GetFromPool();
        if(temp.name == "PlayerOne")
            temp.transform.position = new Vector2(transform.position.x + 0.65f, transform.position.y);
        else if (temp.name == "PlayerTwo")
            temp.transform.position = new Vector2(transform.position.x - 0.65f, transform.position.y);
    }
}
