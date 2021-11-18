using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : EnemyMovement
{
    [Header("Enemy Stats")]
    public float maxHealth;
    //public GameObject deathEffect;

    private float health;

    protected override void OnStart()
    {
        base.OnStart();

        health = maxHealth;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;


        if(health <= 0f)
        {
            Die();
        }
    }

    protected virtual void Die()
    {
        //GameObject temp = Instantiate(deathEffect, transform.position, transform.rotation);

        FindObjectOfType<EnemySpawner>().RemoveEnemy();
        //Destroy(temp, 10f);
        Destroy(gameObject);
    }
}
