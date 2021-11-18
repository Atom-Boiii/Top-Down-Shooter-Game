using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : PlayerShooting
{
    [Header("Player stats")]
    public float maxHealth;

    private float health;

    protected override void OnStart()
    {
        base.OnStart();

        health = maxHealth;
    }

    protected override void OnUpdate()
    {
        base.OnUpdate();
    }

    public void TakeDamage(float damage)
    {
        health -= damage;

        if(health <= 0f)
        {
            FindObjectOfType<EnemySpawner>().GameOver();
        }
    }
}
