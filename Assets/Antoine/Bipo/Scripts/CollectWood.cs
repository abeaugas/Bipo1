using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CollectWood : MonoBehaviour{
    public Transform woodSource;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start(){
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    int Update(){
        // Définir la destination : pierre
        agent.destination = woodSource.position;

        // Arreter lorsque la destination est atteinte
        if(agent.isStopped = agent.remainingDistance <= 0.5f) return 1;
        else return 0;
    }
}
