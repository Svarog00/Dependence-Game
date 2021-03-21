using UnityEngine;
using System;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
	public static Key Instance;

	public event EventHandler<OnKeyCountChangedEventArgs> OnKeyCountChanged;

	public class OnKeyCountChangedEventArgs
	{
		public int count;
	}

	int _count = 0;

	private void Awake()
	{
		Instance = this;
	}

	public void Activate(Transform player)
	{
		if(_count > 0)
		{
			Collider2D[] hits = Physics2D.OverlapCircleAll(player.position, 1);
			foreach (var hit in hits)
			{
				if(hit.CompareTag("Door"))
				{
					Debug.Log("XUI");
					Door door = hit.GetComponent<Door>();
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
