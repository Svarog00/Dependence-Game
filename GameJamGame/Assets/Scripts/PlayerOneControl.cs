using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneControl : MonoBehaviour
{
    public int speed;

    public Counter Counter;

    private bool _canMove;

    void Start()
    {
        Counter.OnStartSignal += Counter_OnStartSignal;
    }

    private void Counter_OnStartSignal(object sender, System.EventArgs e)
    {
        _canMove = true;
        Counter.OnStartSignal -= Counter_OnStartSignal;
    }

    // Update is called once per frame
    void Update()
    {
        if(_canMove)
        {
            if(Input.GetKey(KeyCode.RightArrow))
            {
                transform.position += transform.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.position -= transform.right * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                transform.position += transform.up * speed * Time.deltaTime;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.position -= transform.up * speed * Time.deltaTime;
            }
        }
    }
}
