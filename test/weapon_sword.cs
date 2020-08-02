using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class weapon_sword : MonoBehaviour
{
    void Start()
    {
        weapon sword = new weapon(55.7f, 100, 3);
       
        weapon EXsword = new weapon(71.1f, 100, 5); 
        
        // Debug.Log(sword.get_atkDmg);
        // Debug.Log(EXsword.get_atkDmg);


        // sword.set_atkDmg(55.6f);
        // sword.set_dura(100);
        // sword.set_level(3);

        // EXsword.set_atkDmg(71.6f);
        // EXsword.set_dura(100);
        // EXsword.set_level(5);

        // Debug.Log(sword.get_atkDmg());
        // Debug.Log(EXsword.get_atkDmg());
    }
}