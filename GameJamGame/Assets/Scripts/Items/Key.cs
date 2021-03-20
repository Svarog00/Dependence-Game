using UnityEngine;
using System;

public class Key : MonoBehaviour
{
    public static Key Instance;

    public event EventHandler<OnKeyCountChangedEventArgs> OnKeyCountChanged;

    public class OnKeyCountChangedEventArgs
    {
        public int count;
    }

    int _count = 0;

    private void Start()
    {
        Instance = this;
        OnKeyCountChanged?.Invoke(this, new OnKeyCountChangedEventArgs { count = _count });
    }

    public void Activate()
    {
        if(_count > 0)
        {
            RaycastHit2D[] raycast = Physics2D.RaycastAll(transform.position, transform.up);
            foreach(var hit in raycast)
            {
                if(hit.collider.CompareTag("Door"))
                {
                    var door = hit.collider.GetComponent<Door>();
                    door.Open();
                    break;
                }
            }
            _count--;
            OnKeyCountChanged?.Invoke(this, new OnKeyCountChangedEventArgs { count = _count });
        }
    }

    public void AddKey()
    {
        _count++;
        OnKeyCountChanged?.Invoke(this, new OnKeyCountChangedEventArgs { count = _count });
    }

}
