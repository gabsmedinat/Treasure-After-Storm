using System.Collections.Generic; 
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    public List<GameObject> prefabItems;

    public float spawnTime = 1f;
    private float timeElapsed = 0f;
    private float spawn_xPosition = 17.0f;
    public float MIN_Y = -4.7f;
    public float MAX_Y = 1.7f;
    
    void Update()
    {
        timeElapsed += Time.deltaTime;

        if(timeElapsed >= spawnTime)
        {
            SpawnItem();
            timeElapsed = 0f;
        }
    }

    void SpawnItem()
    {
        if (prefabItems.Count == 0) return;

        int randomIndex = Random.Range(0, prefabItems.Count);

        float spawn_yPosition = Random.Range(MIN_Y, MAX_Y);
        
        GameObject instance = Instantiate(prefabItems[randomIndex]);
        instance.transform.position = new Vector2(spawn_xPosition, spawn_yPosition);
    }
}
