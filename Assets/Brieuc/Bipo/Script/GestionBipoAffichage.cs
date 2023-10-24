using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionBipo : MonoBehaviour
{
    static public int nbreBipoMine=0; //nombre de bipo qu'on envoie miner
    static public int nbreBipoBucheron=0;//nombre de bipo bucheron
    static public int nbreBipoFarm = 0;//nombre de bipo a envoyer a la ferme
    static public int nbreBipoGestion = 4;// variable 8 a changer par le nombre de bipo present dans le jeu(len(listedebipo))
    static public int bipoZzz = nbreBipoGestion-nbreBipoFarm-nbreBipoBucheron-nbreBipoMine;//nombre de bipo inactif

    public Text scoreTextm;  
    public Text scoreTextb;
    public Text scoreTextf;
    public Text scoreTextz;
    void Start()
    {

    }

    void Update() //affichage des nombres sur le tableau UI
    {
        scoreTextm.text =" x " + nbreBipoMine.ToString();
        scoreTextb.text =" x " + nbreBipoBucheron.ToString();
        scoreTextf.text =" x " + nbreBipoFarm.ToString();
        scoreTextz.text = " x " + bipoZzz.ToString();
    }
}
