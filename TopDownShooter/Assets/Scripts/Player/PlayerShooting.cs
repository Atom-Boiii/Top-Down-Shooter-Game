using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : PlayerControlls
{
    [Header("Shooting settings")]
    public GameObject bullet;
    public Transform shootPoint;
    public float bulletSpeed;

    public float damage;

    public float autoFireRate;

    public bool autoShoot;

    private float nextTimeToFire = 0f;

    protected override void OnUpdate()
    {
        if (!autoShoot)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                Shoot();
            }
        }
        else
        {
            if(Time.time >= nextTimeToFire)
            {
                nextTimeToFire = Time.time + 1f / autoFireRate;
                Shoot();
            }
        }
    }

    private void Shoot()
    {
        GameObject temp = Instantiate(bullet, shootPoint.transform.position, shootPoint.transform.rotation);

        temp.GetComponent<Bullet>().damage = damage;
        temp.GetComponent<Rigidbody2D>().AddForce(GetComponent<PlayerControlls>().GetDirection() * bulletSpeed);

        Destroy(temp, 5f);
    }

    public void StopAuto()
    {
        StartCoroutine(StopAutoFire());
    }

    private IEnumerator StopAutoFire()
    {
        yield return new WaitForSeconds(3f);
        autoShoot = false;
    }
}
