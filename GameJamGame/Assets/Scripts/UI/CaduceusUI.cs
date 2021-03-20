using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CaduceusUI : MonoBehaviour
{
    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        Caduceus.Instance.OnCaduceusCountChanged += Instance_OnCaduceusCountChanged;
    }

    private void Instance_OnCaduceusCountChanged(object sender, Caduceus.OnCaduceusCountChangedEventArgs e)
    {
        text.text = "x" + e.count.ToString();
    }
}
