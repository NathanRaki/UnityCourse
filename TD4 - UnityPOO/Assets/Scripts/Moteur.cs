using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moteur : MonoBehaviour
{
    private double Essence;

    public Moteur()
    {
        Essence = 10f;
        Debug.Log("Essence : " + Essence);
    }

    public double GetEssence() { return Essence; }
    public void SetEssence(double Value) { Essence = Value; }
    public bool Roule(double Consommation)
    {
        Essence -= Consommation;
        return Essence > 0 ? true : false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
