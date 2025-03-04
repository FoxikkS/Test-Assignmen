using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button spawnButton;

    private BoxSpawner _spawner;
    private CameraController _camera;

    private void Start()
    {
        _spawner = GetComponent<BoxSpawner>();
        _camera = FindObjectOfType<CameraController>();
        spawnButton.onClick.AddListener(OnSpawnButton);
    }

    public void OnShowBox(GameObject box)
    {
        _camera.PickUpBox(box);
    }
    
    public void OnSpawnButton()
    {
        GameObject box = _spawner.SpawnBox();
        OnShowBox(box);
    }
}
