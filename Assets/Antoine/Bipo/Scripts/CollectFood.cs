using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CollectFood : MonoBehaviour{
    public Transform foodSource;
    private NavMeshAgent agent;
    private Vector3 destination;

    // Start is called before the first frame update
    void Start(){
        agent = GetComponent<NavMeshAgent>();
        destination = agent.destination;
    }

    // Update is called once per frame
    public int goCollect(){
        // Définir la destination : pierre
        agent.destination = foodSource.position;

        // Arreter lorsque la destination est atteinte
        if(agent.isStopped = agent.remainingDistance <= 0.5f){
            return 1;
        }else return 0;
    }
}
