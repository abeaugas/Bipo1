using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour{
    [SerializeField] CollectStone collectStone;
    [SerializeField] CollectWood collectWood;
    [SerializeField] CollectFood collectFood;
    [SerializeField] DropRessource dropRessource;

    [SerializeField] Animator animator;

    // Start is called before the first frame update
    void Start(){
        goMine();
    }

    // Update is called once per frame
    void Update(){
        // Collecte de pierre terminé
        if(collectStone.finished){
            animator.SetBool("Walking", false);
            animator.SetBool("Mining", true);
            animator.SetBool("Mining", false);
            goDrop();
        }
        // Dépose terminée
        if(dropRessource.finished){
            animator.SetBool("Carrying", false);
            goMine();
        }
    }

    void goMine(){
        animator.SetBool("Walking", true);
        collectStone.goCollect();
    }

    void goDrop(){
        animator.SetBool("Carrying", true);
        dropRessource.goCollect();
    }
}
