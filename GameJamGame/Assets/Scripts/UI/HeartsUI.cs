using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeartsUI : MonoBehaviour
{
    public Image[] hearts;

    void Start()
    {
        Health.Instance.OnHeartChanged += Instance_OnHeartChanged;
    }

    private void Instance_OnHeartChanged(object sender, Health.OnHeartChangedEventAgrs e)
    {
        hearts[e.currentHealth - 1].enabled = e.isRestore;
    }
}
