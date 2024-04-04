using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    Vector2 screenHalf;
    public GameObject fallingBlock;
    public Vector2 screenSpawnSize;
    public float MaxSpawnAngle;

    float SpawnTimer;
    public Vector2 SpawnTimeDifficulty;

    public static int counter;
    void Start()
    {
        screenHalf = new Vector2(Camera.main.aspect * Camera.main.orthographicSize, Camera.main.orthographicSize);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time> SpawnTimer)
        {
            float TimeBetweenSpawn = Mathf.Lerp(SpawnTimeDifficulty.x, SpawnTimeDifficulty.y, Settings.GetMaxDifficulty());
            SpawnTimer = Time.time+TimeBetweenSpawn;
            float SpawnAngle = Random.Range(-MaxSpawnAngle, MaxSpawnAngle);
            float SpawnSize = Random.Range(screenSpawnSize.x, screenSpawnSize.y);
            Vector2 SpawnPos = new Vector2(Random.Range(-screenHalf.x, screenHalf.x), screenHalf.y + SpawnSize);
            GameObject newObject = (GameObject)Instantiate(fallingBlock, SpawnPos, Quaternion.Euler(Vector3.forward * SpawnAngle));
            newObject.transform.localScale = new Vector2(1, 1) * SpawnSize;
            counter++;
        }

       

    }
}
