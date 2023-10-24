using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour{
    [SerializeField] CollectStone collectStone;
    [SerializeField] CollectWood collectWood;
    [SerializeField] CollectFood collectFood;
    [SerializeField] DropRessource dropRessource;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
        collectStone.goCollect();
    }
}
