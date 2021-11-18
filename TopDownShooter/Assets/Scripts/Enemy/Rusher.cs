using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rusher : EnemyStats
{
    [Header("Rusher")]
    public int pointsOnDeath;

    protected override void OnUpdate()
    {
        base.OnUpdate();
    }

    protected override void Die()
    {
        base.Die();

        GameManager.instance.AddScore(pointsOnDeath);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Player>().TakeDamage(10f);
        FindObjectOfType<EnemySpawner>().RemoveEnemy();
        Destroy(gameObject);
    }
}
