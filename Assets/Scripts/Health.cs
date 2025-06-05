using UnityEngine;

public class Health : Powerups
{
    protected override void PerformAction(Collider other)
    {
        ShipHealth shipHealth = other.GetComponent<ShipHealth>();
        shipHealth.AdjustHealth(5);
    }
}
