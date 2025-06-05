using System.Collections;
using TMPro;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI coinsText;
    public int coins = 100;

    public void AdjustCoins(int amount)
    {
        coins += amount;
        coinsText.text = "Coins: " + coins  .ToString();
    }
}
