using UnityEngine;

public class Poison : Powerups
{
    protected override void PerformAction(Collider other)
    {
        ShipHealth shipHealth = other.GetComponent<ShipHealth>();
        shipHealth.Poison();
    }
}
