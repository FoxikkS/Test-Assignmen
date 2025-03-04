using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button spawnButton;

    private BoxSpawner _spawner;

    private void Start()
    {
        _spawner = GetComponent<BoxSpawner>();
    }

    public void OnSpawnButton()
    {
        _spawner.SpawnBox();
    }
}
