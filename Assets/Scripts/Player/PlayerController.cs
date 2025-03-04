using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Joystick joystick;
    public float speed;
    
    private CharacterController _controller;
    private Vector3 _move;
    
    
    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        _controller = GetComponent<CharacterController>();
    }
    
    
    void Update()
    {
        JoystickMove();
        PlayerMove();
    }

    private void JoystickMove()
    {
        Vector3 move = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        _controller.Move(move * speed * Time.deltaTime);
    }

    private void PlayerMove()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        _move = new Vector3(moveX, 0, moveZ);
        _controller.Move(_move * speed * Time.deltaTime);
    }
}
