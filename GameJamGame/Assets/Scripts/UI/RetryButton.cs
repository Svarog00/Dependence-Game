using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RetryButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject background;
    public Sprite newBackground;
    public Sprite _oldImage;
    private Image _currentImage;
    private BoxCollider2D boxCollider;

    private void Start()
    {
        _currentImage = background.GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _currentImage.sprite = newBackground;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _currentImage.sprite = _oldImage;
    }


}
