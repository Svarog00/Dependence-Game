using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caduceus : MonoBehaviour, IActivatable
{
    public void Activate()
    {
        PlayerManager.Instance.Revive();
    }
}
