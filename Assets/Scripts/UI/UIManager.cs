using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private BoxSpawner _spawner;
    private CameraController _camera;

    private void Start()
    {
        _spawner = FindObjectOfType<BoxSpawner>();
        _camera = FindObjectOfType<CameraController>();
    }

    public void OnShowBox(GameObject box)
    {
        if (box != null)
        {
            _camera.PickUpBox(box);
        }
    }

    public void OnSpawnButton()
    {
        if (_spawner != null)
        {
            _spawner.SpawnBox();
        }
    }
}