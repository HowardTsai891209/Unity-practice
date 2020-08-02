using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotCross : MonoBehaviour
{
    public Transform taget;
    void Update()
    {
        //本地座標轉換世界座標
        Vector3 forward = transform.
        TransformDirection(Vector3.forward);
        //計算兩個向量方向
        Vector3 toOther = taget.position - transform.position;

        //計算dor,dot沒有順序性
        float dot = Vector3.Dot(forward,toOther);
        Debug.Log("Dot:" + dot);
        if(dot == 0){
            Debug.Log(taget.name + ":平行");
        } else if(dot > 0){
            Debug.Log(taget.name + ":前方");
        } else if(dot < 0){
            Debug.Log(taget.name + ":後方");
        }

        //計算cross,cross有順序性
        Vector3 cross = Vector3.Cross(forward, toOther);
        Debug.Log("Cross:" + cross.y);
        if(cross.y == 0){
            Debug.Log(taget.name + ":重疊");
        } else if(cross.y > 0){
            Debug.Log(taget.name + ":右方");
        } else if(cross.y < 0){
            Debug.Log(taget.name + ":左方");
        }
    }
}
