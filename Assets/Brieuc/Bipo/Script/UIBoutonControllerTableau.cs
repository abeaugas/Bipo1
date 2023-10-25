using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIBoutonControllerTableau : MonoBehaviour
{
    public void incrementMine()
    {
        GestionBipoTest.addBipoMine += 1;
        GestionBipoTest.addBipoZzz -= 1;
    }
    public void decrementMine()
    {
        if (GestionBipo.nbreBipoMine + GestionBipoTest.addBipoMine >= 1)
        {
            GestionBipoTest.addBipoMine -= 1;
            GestionBipoTest.addBipoZzz += 1;
        }
    }
    public void incrementBucheron()
    {
        GestionBipoTest.addBipoBucheron += 1;
        GestionBipoTest.addBipoZzz -= 1;
    }
    public void decrementBucheron()
    {
        if (GestionBipo.nbreBipoBucheron + GestionBipoTest.addBipoBucheron >= 1)
        {
            GestionBipoTest.addBipoBucheron -= 1;
            GestionBipoTest.addBipoZzz += 1;
        }
    }
    public void incrementFarm()
    {

        GestionBipoTest.addBipoFarm += 1;
        GestionBipoTest.addBipoZzz -= 1;
    }
    public void decrementFarm()
    {
        if (GestionBipo.nbreBipoFarm + GestionBipoTest.addBipoFarm >= 1) { 
        GestionBipoTest.addBipoFarm -= 1;
        GestionBipoTest.addBipoZzz += 1;
        }
    }
    public void applybipo() //quand on appui sur apply tous les bipo vont a leurs nouvelles taches
    {
        if(GestionBipo.bipoZzz + GestionBipoTest.addBipoZzz >= 0) { 
        GestionBipo.nbreBipoMine += GestionBipoTest.addBipoMine;
        GestionBipo.nbreBipoBucheron += GestionBipoTest.addBipoBucheron;
        GestionBipo.nbreBipoFarm += GestionBipoTest.addBipoFarm;
        GestionBipo.bipoZzz += GestionBipoTest.addBipoZzz;
        GestionBipoTest.addBipoMine=0;
        GestionBipoTest.addBipoBucheron=0;
        GestionBipoTest.addBipoFarm = 0;
        GestionBipoTest.addBipoZzz = 0;
        }
    }
}
