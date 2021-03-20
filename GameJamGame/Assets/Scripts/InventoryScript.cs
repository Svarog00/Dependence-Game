using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryScript : MonoBehaviour
{
    private IActivatable[] items = new IActivatable[2];

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            items[0].Activate();
        }    
        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            items[1].Activate();
        }
    }
}
