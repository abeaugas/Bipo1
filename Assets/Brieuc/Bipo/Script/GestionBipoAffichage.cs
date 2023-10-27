using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionBipo : MonoBehaviour
{
    static public int nbreBipoMine=0; //nombre de bipo qu'on envoie miner
    static public int nbreBipoBucheron=0;//nombre de bipo bucheron
    static public int nbreBipoFarm = 0;//nombre de bipo a envoyer a la ferme
    static public int nbreBipoGestion = 2;// variable 8 a changer par le nombre de bipo present dans le jeu(len(listedebipo))
    static public int bipoZzz = nbreBipoGestion-nbreBipoFarm-nbreBipoBucheron-nbreBipoMine;//nombre de bipo inactif

    static public int npierre = 0;
    static public int nbois = 0;
    static public int nouriturre = 0;

    public Text Textm;  
    public Text Textb;
    public Text Textf;
    public Text Textz;
    // compteur de ressource
    public Text stone;
    public Text wood;
    public Text food;
    void Start()
    {

    }

    void Update() //affichage des nombres sur le tableau UI
    {
        Textm.text =" x " + nbreBipoMine.ToString();
        Textb.text =" x " + nbreBipoBucheron.ToString();
        Textf.text =" x " + nbreBipoFarm.ToString();
        Textz.text = " x " + bipoZzz.ToString();
        stone.text =npierre.ToString();
        wood.text =nbois.ToString();
        food.text =nouriturre.ToString();
    }
}
