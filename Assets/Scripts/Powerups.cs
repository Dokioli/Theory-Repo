using UnityEngine;

public abstract class Powerups : MonoBehaviour // ABSTRACTION
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PerformAction(other);
            Destroy(gameObject);
        }
    }
    protected abstract void PerformAction(Collider other);
}
