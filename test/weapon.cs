using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon
{
    private float atkDmg;
    private float dura;
    private int level;
    
    public weapon(){
    }
    public weapon(float get_atkDmg, float get_dura, int get_level){
        atkDmg = get_atkDmg;
        dura = get_dura;
        level = get_level;
    }

    // public float get_atkDmg(){
    //     return atkDmg;
    // }
    // public void set_atkDmg(float i){
    //     atkDmg = i;
    // }

    // public float get_dura(){
    //     return dura;
    // }
    // public void set_dura(float i){
    //     dura = i;
    // }

    // public float get_level(){
    //     return level;
    // }
    // public void set_level(int i){
    //     level = i;
    // }
}
