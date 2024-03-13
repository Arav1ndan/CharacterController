using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]
[RequireComponent(typeof(PlayerInput))]
public class characterController : MonoBehaviour
{
    [SerializeField]
    private float MoveSpeed = 2.0f;

    [SerializeField]
    private float SprintSpeed = 5f;

    private CharacterController Charactercontroller;
    private Vector2 moveVector;


    void Start()
    {
        Charactercontroller = GetComponent<CharacterController>();
    }
    void Update()
    {
        Move();
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        moveVector = context.ReadValue<Vector2>();
    }
    private void Move()
    {
        Vector3 move = transform.right * moveVector.x + transform.forward* moveVector.y;
        Charactercontroller.Move(move*MoveSpeed*Time.deltaTime);
    }
}
