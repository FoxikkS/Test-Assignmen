using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    public GameObject[] boxes;
    public Transform spawnPoint;

    public GameObject SpawnBox()
    {
        float rand = Random.Range(0f, 1f);
        GameObject boxPrefab;

        if (rand < 0.6f) boxPrefab = boxes[0];
        else if (rand < 0.9f) boxPrefab = boxes[1];
        else boxPrefab = boxes[2];
        
        GameObject spawnedBox = Instantiate(boxPrefab, spawnPoint.position, spawnPoint.rotation);
        return spawnedBox;
    }
}