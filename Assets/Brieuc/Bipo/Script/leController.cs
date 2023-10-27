using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leController : MonoBehaviour
{
    
    

    [SerializeField] static List<GameObject> collectionLogic;
    public static int nbMining = 0;
    public static int nbChopping = 0;
    public static int nbFarming = 0;
    public static int nbIdle = 0;
    [SerializeField] GameObject sign;
    
    bool isEmpty;

    // Start is called before the first frame update
    void Start()
    {
        // Collecter de la pierre
        appeltableau();
        
    }

    // Update is called once per frame
    void Update()
    {
        appeltableau();
        foreach (GameObject b in GameObject.FindGameObjectsWithTag("bipo"))
            {
                jecollecte e = b.GetComponent<jecollecte>();
                if ((e.finished) && (!e.iscarrying()))
                 {
                    e.animator.SetBool("Walking", false);
                    e.working();
                // mettre la tempo?
                    e.carrying = true;
                    e.goPickupObject(sign);
                 }
            // Dépose de la ressource terminée
                if (e.finished && e.iscarrying())
                {
                e.carrying = false;
                e.goPickup();
                }
            }
        }


    public static void appeltableau()
    {
        
        int diffm = nbMining - GestionBipo.nbreBipoMine;
        int diffc = nbChopping - GestionBipo.nbreBipoBucheron;
        int difff = nbFarming - GestionBipo.nbreBipoFarm;
        
        foreach (GameObject b in GameObject.FindGameObjectsWithTag("bipo"))
        {
            jecollecte e = b.GetComponent<jecollecte>();
            if (diffm > 0 && e.state==1)
            {
                e.state = 0;
                diffm--;
              nbMining--;
            }
            else if(diffc > 0 && e.state==2)
            {
                e.state = 0;
                diffc--;
                nbChopping--;
            }
            else if(difff > 0 && e.state==3)
            {
                e.state = 0;
                difff--;
                nbFarming--;
            }
        }
        foreach (GameObject b in GameObject.FindGameObjectsWithTag("bipo"))
        {
            jecollecte e = b.GetComponent<jecollecte>();
            if (diffm < 0 && e.state == 0)
            {
                e.state = 1;
                diffm++;
                nbMining++;
                
            }
            else if (diffc < 0 && e.state ==0)
            {
                e.state = 2;
                diffc++;
                nbChopping++;
            }
            else if (difff < 0 && e.state == 0)
            {
                e.state = 3;
                difff++;
                nbFarming++;
            }
        }
    }
}