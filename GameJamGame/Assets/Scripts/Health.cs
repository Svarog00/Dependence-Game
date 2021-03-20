using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public static Health Instance;
    public event EventHandler<OnHeartChangedEventAgrs> OnHeartChanged;
    public class OnHeartChangedEventAgrs
    {
        public int currentHealth;
        public bool isRestore;
    }

    private int _currentHealth;

    void Awake()
    {
        Instance = this;
        _currentHealth = 3;
    }

    
    public void RestoreHealth()
    {
        if(_currentHealth < 3)
        { 
            _currentHealth++;
            OnHeartChanged?.Invoke(this, new OnHeartChangedEventAgrs { currentHealth = _currentHealth, isRestore = true });
        }
    }

    public void DecreaseHealth()
    {
        if(_currentHealth > 0)
        {
            OnHeartChanged?.Invoke(this, new OnHeartChangedEventAgrs { currentHealth = _currentHealth, isRestore = false});
            _currentHealth--;
        }
    }
}
