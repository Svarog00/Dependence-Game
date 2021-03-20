using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RetryButton : MonoBehaviour
{
    public GameObject background;
    public Sprite newBackground;
    private Image _oldImage;
    private Image _currentImage;
    private BoxCollider2D boxCollider;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        _oldImage = background.GetComponent<Image>();
        _currentImage = _oldImage;
    }

    private void OnMouseEnter()
    {
        Debug.Log("SOSI");
        _currentImage.sprite = newBackground;
    }

    private void OnMouseExit()
    {
        Debug.Log("SOSI SNOVA");
        _currentImage.sprite = _oldImage.sprite;
    }

}
