using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject[] boxes;
    public Transform spawnPoint;

    public void SpawnBox()
    {
        float rand = Random.Range(0f, 1f);
        GameObject box;

        if (rand < 0.6f) box = boxes[0];
        else if (rand < 0.9f) box = boxes[1];
        else box = boxes[2];

        Instantiate(box, spawnPoint.position, Quaternion.identity);
    }
}
