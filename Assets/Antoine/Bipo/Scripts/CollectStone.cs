using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class CollectStone : MonoBehaviour{
    public Transform stoneSource;
    private NavMeshAgent agent;
    private GameObject reserve;
    public bool finished = false;

    // Start is called before the first frame update
    void Start(){
        agent = GetComponent<NavMeshAgent>();
    }

    void update(){
        // Si la destination est atteinte on prévient
        if(agent.isStopped = agent.remainingDistance <= 4) finished = true;
    }

    // Update is called once per frame
    public void goCollect(){
        // Définir la destination : pierre
        agent.destination = stoneSource.position;
        finished = false;
    }
}
