using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoFire : PowerUp
{
    protected override void OnPickup(Collider2D other)
    {
        other.GetComponent<PlayerShooting>().autoShoot = true;
        other.GetComponent<PlayerShooting>().StopAuto();

        base.OnPickup(other);
    }
}
