using UnityEngine;

[RequireComponent(typeof(PlayerMover))]
[RequireComponent(typeof(PlayerAnimationView))]
public class PlayerInput : MonoBehaviour
{
	[Header("Model")]
	[SerializeField] private PlayerMover _playerMover;
	[SerializeField] private PlayerInteracter _playerInteracter;
	
	[Header("View")]
	[SerializeField] private PlayerAnimationView _playerAnimationView;
	
	private InputMap _inputMap;
	
	public void Awake()
	{
		_inputMap = new InputMap();
		
		_playerMover = GetComponent<PlayerMover>();
		_playerInteracter = GetComponent<PlayerInteracter>();
		_playerAnimationView = GetComponent<PlayerAnimationView>();
		
		_inputMap.PlayScene.Interact.performed += context => _playerInteracter.Interact();
	}
	
	private void OnEnable()
	{
		_inputMap.Enable();
	}
	
	private void OnDisable()
	{
		_inputMap.Disable();
	}
	
	private void Update()
	{
		UpdateModel();
		UpdateView();
	}
	
	private void UpdateModel()
	{
		_playerMover.Move(_inputMap.PlayScene.Move.ReadValue<Vector2>());
	}
	
	private void UpdateView()
	{
		_playerAnimationView.ChangeMoveAnimationByDirection(_inputMap.PlayScene.Move.ReadValue<Vector2>());
	}
}