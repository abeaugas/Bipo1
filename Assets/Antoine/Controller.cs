using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour{
    [SerializeField] CollectItem collectionLogic;
    [SerializeField] Animator animator;
    [SerializeField] GameObject stone;
    [SerializeField] GameObject tree;
    [SerializeField] GameObject farm;
    [SerializeField] GameObject sign;

    public int nbMining = 0;
    public int nbChopping = 0;
    public int nbFarming = 0;
    public int nbIdle = 0;

    private bool carrying;

    // Start is called before the first frame update
    void Start(){
        // Collecter de la pierre
        carrying = false;
        goPickupObject(stone);
    }

    // Update is called once per frame
    void Update(){
        // Trajet terminé
        if(collectionLogic.finished && !carrying){
            animator.SetBool("Walking", false);
            animator.SetBool("Mining", true);
            animator.SetBool("Carrying", true);
            goPickupObject(sign);
            carrying = true;
        }
        // Dépose de la ressource terminée
        if(collectionLogic.finished && carrying){
            carrying = false;
            goPickupObject(stone);
        }

    }

    void goPickupObject(GameObject obj){
        animator.SetBool("Walking", true);
        collectionLogic.goCollect(obj);
    }
}
