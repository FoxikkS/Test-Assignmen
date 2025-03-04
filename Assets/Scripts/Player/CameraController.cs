using System;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;
    public int sens;
    public float rotationX = 0f;

    private UIManager _manager;

    private void Start()
    {
        _manager = FindObjectOfType<UIManager>();
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens;
        float mouseY = Input.GetAxis("Mouse Y") * sens;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -45, 45);

        player.Rotate(Vector3.up * mouseX);
        transform.localRotation = Quaternion.Euler(rotationX, 0, 0);

        RaycastHit raycastHit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out raycastHit, 2f))
        {
            if (raycastHit.collider.CompareTag("Box"))
            {
                _manager.OnShowBox(raycastHit.collider.gameObject);
            }
        }
    }

    public void PickUpBox(GameObject box)
    {
        box.transform.position = player.position + Vector3.forward;
        //box.transform.position = player.position + player.forward * 2f;
    }
}
