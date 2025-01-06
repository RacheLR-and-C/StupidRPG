using System;
using UnityEngine;

public abstract class BaseItem : MonoBehaviour, IInteractable
{
	public bool _isPickedUp { get; private set; }

	public void Interact()
	{
		_isPickedUp = true;
	}
}