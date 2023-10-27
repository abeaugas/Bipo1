using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class jecollecte : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject reserve;
    public bool finished = false;
    public static leController controller;
    public bool carrying;
    public Animator animator;
    [SerializeField] GameObject stone;
    [SerializeField] GameObject tree;
    [SerializeField] GameObject farm;
    [SerializeField] GameObject sign;
    [SerializeField] GameObject pickaxe;
    [SerializeField] GameObject axe;
    public int state;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.stoppingDistance = 2f;
        finished = false;
        carrying = false;
        axe.SetActive(false);
        pickaxe.SetActive(false);
        state = 0;
    }

    void Update()
    {
        if ((agent.velocity.x <= 0.1f) && (agent.remainingDistance <= agent.stoppingDistance) && !finished && state!=0)
        {
            finished = true;
        }
    }

    // Update is called once per frame
    public void goCollect(GameObject obj)
    {

        agent.destination = obj.transform.position;
        finished = false;
    }
    public bool iscarrying()
    {
        return carrying;
    }
    public void goPickupObject(GameObject obj)
    {
        this.animator.SetBool("Walking", true);
        goCollect(obj);
    }

    public void working()
    {
        if (state == 1)
        {
            animator.SetBool("Walking", false);
            axe.SetActive(false);
            pickaxe.SetActive(true);
            animator.SetBool("Mining", true);
            animator.SetBool("Mining", false);
            animator.SetBool("Carrying", true);
        }
        else if (state == 2)
        {
            animator.SetBool("Chopping", true);
            pickaxe.SetActive(false);
            axe.SetActive(true);

        }
        else if (state == 3)
        {
            animator.SetBool("Farming", true);
            axe.SetActive(false);
            pickaxe.SetActive(false);
        }
    }
    public void goPickup()
    {

        if (state == 1)
        {
            goPickupObject(stone);

        }
        else if (state == 2)
        {
            goPickupObject(tree);

        }
        else if (state == 3)
        {
            goPickupObject(farm);

        }
    }


}

