using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeTest : MonoBehaviour
{
    //給予Time.timeScale的數值
    public float timeScale = 0;
    //是否可設定Time.timeScale
    public bool changeScale = false;
    void Awake(){
        Application.targetFrameRate = 30;
    }
    void Update()
    {
        //如果可以改變scale
        if(changeScale){
            Time.timeScale = timeScale;
            changeScale = false;
        }
        Debug.Log("Time: " + Time.time);
        Debug.Log("RealTime: " + Time.realtimeSinceStartup);
        //Debug.Log("Update DeltaTime: " + Time.deltaTime);
    }
    void FixedUpdate(){
        //Debug.Log("FixedUpdate DeltaTime: " + Time.deltaTime);
    }
}
