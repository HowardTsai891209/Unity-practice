using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTest : MonoBehaviour
{   //移動到哪個位置
    public Vector3 tagerPoint;
    //移動的速度
    public int speed = 3;
    void Update()
    {
        //目前的座標點
        Vector3 currentPoint = transform.position;
        //每次移動的距離
        float maxDistanceDelta = Time.deltaTime * speed;
        //最後會回傳tagerpoint不會超過tagerpoint
        transform.position = Vector3.MoveTowards(currentPoint,
        tagerPoint,
        maxDistanceDelta);
    }
}
