using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ShipHealth : MonoBehaviour  // ENCAPSULATION
{
    [SerializeField] float currenthealth = 10;
    [SerializeField] float maxHealth = 10;
    bool isPoisoned;

    [SerializeField] Image healthFill;

    public float Health
    {
        get { return currenthealth; }
        set
        {
            if (value < 0)
            {
                currenthealth = 0;
            }
            else
            {
                currenthealth = value;
            }
        }
    }

    private void Start()
    {
        Health = maxHealth;
    }

    public void AdjustHealth(float amount)
    {
        Health += amount;
        UpdateUI();
        if (Health < 0)
        {
            Debug.Log("Destroyed");
        }
    }

    public void Poison()
    {
        StartCoroutine(PoisonShip());
    }

    IEnumerator PoisonShip()
    {
        if (isPoisoned) yield break;
        isPoisoned = true;
        float timer = 0;
        while (timer < 5)
        {
            timer += Time.deltaTime;
            AdjustHealth(-1 * Time.deltaTime);
            UpdateUI();
            yield return null;
        }
        isPoisoned = false;
    }

    public void UpdateUI()
    {
        healthFill.fillAmount = Health / maxHealth;
    }
}
