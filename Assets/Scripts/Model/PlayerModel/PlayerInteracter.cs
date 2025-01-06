using UnityEngine;

public class PlayerInteracter : MonoBehaviour, IInteractable
{
	[SerializeField] private LayerMask _interactionLayerMask;
	
	private IInteractable _interactablceObject;
	
	public void OnTriggerStay2D(Collider2D other)
	{
		if (other.gameObject.layer == _interactionLayerMask)
		{
			_interactablceObject = GetComponent<IInteractable>();
		}
		else
		{
			
		}
	}
	
	public void Interact()
	{
		
	}
}