using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public int sens;
    public float rotationX = 0f;
    

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens;
        float mouseY = Input.GetAxis("Mouse Y") * sens;
        
        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -45, 45);

        player.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);
    }
}
