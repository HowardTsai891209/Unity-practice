using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestQuertnion : MonoBehaviour
{
    //look對象
    public Transform target;

    //update is called ince per frame
     void Update()
    {
        testLookRotation();
    }

    void testLookRotation(){
        //算出方向
        Vector3 direction = target.position - transform.position;
        //算出轉向這個角度所需要的四元數Quaternion
        Quaternion lookatQuaternion = Quaternion.LookRotation(direction);
        //平穩的每秒xx單位 往lookatQuaternion方向轉
        // Quaternion.RotateTowards(Quaternion FROM,Quaternion TO, SPEED);
        transform.rotation = Quaternion.RotateTowards(transform.rotation,
        lookatQuaternion, 20 * Time.deltaTime);
    }
}
