using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : PlayerShooting
{
    [Header("Player stats")]
    public float maxHealth;

    public GameObject gameOverMenu;

    private float health;

    public TMP_Text hpText;

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
        hpText.text = "HP: " + health.ToString();

        if(health <= 0f)
        {
            FindObjectOfType<EnemySpawner>().GameOver();
            gameOverMenu.SetActive(true);
        }
    }
}
