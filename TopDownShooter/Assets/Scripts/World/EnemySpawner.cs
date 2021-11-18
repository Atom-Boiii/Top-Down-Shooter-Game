using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    public int enemyAmount;
    public float range;

    private int enemies;

    private bool gameIsOver;

    private void Update()
    {
        if(enemies == 0  && !gameIsOver)
        {
            StartCoroutine(SpawnEnemies());
        }
    }

    public void RemoveEnemy()
    {
        enemies--;
    }

    private IEnumerator SpawnEnemies()
    {
        for (int i = 0; i < enemyAmount; i++)
        {
            Vector3 pos = Random.insideUnitCircle * range;

            Instantiate(enemy, pos, Quaternion.identity);

            enemies++;

            yield return new WaitForSeconds(.5f);
        }

    }

    public void GameOver()
    {
        gameIsOver = true;
    }
}
