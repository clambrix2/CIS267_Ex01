using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject[] spawnlocations;
    // Start is called before the first frame update
    void Start()
    {
        spawnenemies();
    }

    public void spawnenemies()
    {
        int randomIndex;
        GameObject spawnedPrefab;
        for(int i = 0; i < spawnlocations.Length; i++)
        {
            randomIndex = Random.Range(0, enemies.Length);

            spawnedPrefab = Instantiate(enemies[randomIndex].gameObject);
            spawnedPrefab.transform.position = new Vector2(spawnlocations[i].transform.position.x, spawnlocations[i].transform.position.y);
        }
    }
}
