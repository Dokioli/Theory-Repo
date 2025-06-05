using UnityEngine;

public class Coin : Powerups
{
    MainManager mainManager;
    private void Start()
    {
        mainManager = FindFirstObjectByType<MainManager>();
    }

    protected override void PerformAction(Collider other)
    {
        mainManager.AdjustCoins(50);
    }
}
