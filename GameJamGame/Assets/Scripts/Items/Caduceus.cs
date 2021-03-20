using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caduceus : IActivatable
{
    private int _count = 0;

    public void Activate()
    {
        if (_count > 0 && PlayerManager.Instance.Revive())
            _count--;
    }
}
