using UnityEngine;
using System;

public class Caduceus : MonoBehaviour
{
    public static Caduceus Instance;

    public event EventHandler<OnCaduceusCountChangedEventArgs> OnCaduceusCountChanged;

    public class OnCaduceusCountChangedEventArgs
    {
        public int count;
    }

    private int _count = 0;

    private void Awake()
    {
        Instance = this;
        OnCaduceusCountChanged?.Invoke(this, new OnCaduceusCountChangedEventArgs { count = _count });
    }

    public void Activate()
    {
        if (_count > 0 && PlayerManager.Instance.Revive())
        {
            PlayerManager.Instance.Revive();
            _count--;
            OnCaduceusCountChanged?.Invoke(this, new OnCaduceusCountChangedEventArgs { count = _count });
        }
    }

    public void AddCaduceus()
    {
        _count++;
        OnCaduceusCountChanged?.Invoke(this, new OnCaduceusCountChangedEventArgs { count = _count });
    }
}
