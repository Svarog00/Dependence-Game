using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyUI : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<Text>();
        Key.Instance.OnKeyCountChanged += Instance_OnKeyCountChanged;
    }

    private void Instance_OnKeyCountChanged(object sender, Key.OnKeyCountChangedEventArgs e)
    {
        text.text = "x" + e.count;
    }
}

