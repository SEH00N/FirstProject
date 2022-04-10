using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManger : MonoBehaviour
{
    public static SpawnManger Instance
    {
        get
        {
            if (instance == null)
            {
                instance = FindObjectOfType<SpawnManger>();
            }
            return instance;
        }
    }
    private static SpawnManger instance;

    [SerializeField] GameObject enemy;
    
    [SerializeField] GameObject score;

    int randVal_Score = 0;

    int randVal_Enemy = 0;

    Vector2 spawnPoint;

    Vector2 l_u = new Vector2(-0.75f, 0.75f);
    Vector2 r_u = new Vector2(0.75f, 0.75f);
    Vector2 l_d = new Vector2(-0.75f, -0.75f);
    Vector2 r_d = new Vector2(0.75f, -0.75f);

    private void Start()
    {
        //SpawnScore();
        //SpawnEnemy();
    }

    public void SpawnScore()
    {
        randVal_Score = Random.Range(1, 5);
        switch (randVal_Score)
        {
            case 1:
                spawnPoint = l_u;
                break;
            case 2:
                spawnPoint = r_u;
                break;
            case 3:
                spawnPoint = l_d;
                break;
            case 4:
                spawnPoint = r_d;
                break;
        }
        Instantiate(score, spawnPoint, Quaternion.identity);
    }

    public void SpawnEnemy()
    {
        randVal_Enemy = Random.Range(1, 5);
        switch (randVal_Enemy)
        {
            case 1:
                spawnPoint = l_u;
                break;
            case 2:
                spawnPoint = r_u;
                break;
            case 3:
                spawnPoint = l_d;
                break;
            case 4:
                spawnPoint = r_d;
                break;
        }
        Instantiate(enemy, spawnPoint, Quaternion.identity);
    }
}
