using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour // Parent Class
{
    NavMeshAgent agent;

    public float speed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = null;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            HandleTarget();
        }

        if (Input.GetMouseButtonDown(0))
        {
            HandleMovement();
        }
    }

    public virtual void DisplayName()
    {
        Debug.Log("Name Of Ships");
    }

    public void HandleTarget()  // ABSTRACTION
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            agent = hit.collider.gameObject.GetComponent<NavMeshAgent>();
        }
    }

    public void HandleMovement()  // ABSTRACTION
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit) && agent != null)
        {
            agent.SetDestination(hit.point);
            DisplayName();
        }
    }
}
