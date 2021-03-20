using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public DoorButton button;
    private BoxCollider2D boxCollider;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        boxCollider = GetComponent<BoxCollider2D>();
        button.OnButtonPressed += Button_OnButtonPressed;
    }

    private void Button_OnButtonPressed(object sender, System.EventArgs e)
    {
        Open();
    }

    public void Open()
    {
        Score.Instance.AddPoints(PlayerManager.Instance.PlayerCount);
        button.OnButtonPressed -= Button_OnButtonPressed;
        animator.Play("Door_Open");
        Invoke("SetActiveFalse", 0.5f);
    }

    // Update is called once per frame
    private void SetActiveFalse()
    {
        boxCollider.isTrigger = true;
    }
}
