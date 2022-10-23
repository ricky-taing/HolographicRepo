using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spider : Enemy
{

    // Start is called before the first frame update
    void Start()
    {
        //Implement turn based system
        Attack();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Apply "bleed" effect to Player's health
    public void Leech()
    {
        Debug.Log("Gimme your RAM RAAAAAAAH!");
    }

    //Deal damage and heal for some amount
    public void Siphon()
    {
        Debug.Log("Mmm so tasty!");
    }
}
