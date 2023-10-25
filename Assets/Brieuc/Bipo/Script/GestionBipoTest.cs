using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GestionBipoTest : MonoBehaviour
{
    static public int addBipoMine = 0;
    static public int addBipoBucheron = 0;
    static public int addBipoFarm = 0;
    static public int addBipoZzz = 0;
    public Text scoreTextm;
    public Text scoreTextb;
    public Text scoreTextf;
    public Text scoreTextz;
    public Button applybutton;
    public ColorBlock cb;
    public Boolean test;
    void Start()
    {
        cb = applybutton.colors;
        test = true;
}

    // Update is called once per frame
    void Update()
    {

        scoreTextm.text = " + " + addBipoMine.ToString();
        scoreTextb.text = " + " + addBipoBucheron.ToString();
        scoreTextf.text = " + " + addBipoFarm.ToString();
        scoreTextz.text = " + " + addBipoZzz.ToString();
        if(GestionBipo.bipoZzz < -addBipoZzz) { 
            scoreTextz.color = Color.red;
            cb.normalColor = Color.red;
        }
        else
        {
            scoreTextz.color = Color.black;
            cb.normalColor = Color.blue;
        }

    }
}
