using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class jecollecte : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject reserve;
    public bool finished = false;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.stoppingDistance = 2f;
        finished = false;
    }

    void Update()
    {
        if ((agent.velocity.x <= 0.1f) && (agent.remainingDistance <= agent.stoppingDistance) && !finished)
        {
            Debug.Log("Agent stopped");
            finished = true;
        }
    }

    // Update is called once per frame
    public void goCollect(GameObject obj)
    {
        // Définir la destination : pierre
        agent.destination = obj.transform.position;
        finished = false;
    }
}

