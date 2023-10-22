using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DropRessource : MonoBehaviour{
    public Transform reserve;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start(){
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    int Update(){
        // Définir la destination : pierre
        agent.destination = reserve.position;

        // Arreter lorsque la destination est atteinte
        if(agent.isStopped = agent.remainingDistance <= 2) return 1;
        else return 0;
    }
}
