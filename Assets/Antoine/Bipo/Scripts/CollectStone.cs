using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CollectStone : MonoBehaviour{
    public Transform stoneSource;
    private NavMeshAgent agent;
    private GameObject reserve;

    // Start is called before the first frame update
    void Start(){
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    int Update(){
        // Définir la destination : pierre
        agent.destination = stoneSource.position;

        // Arreter lorsque la destination est atteinte
        if(agent.isStopped = agent.remainingDistance <= 4) return 1;
        else return 0;
    }
}
