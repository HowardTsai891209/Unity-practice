using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRay : MonoBehaviour
{
    //設定距離為100
    public float distance = 100;
    //因為更改顏色所以要取得Renderer
    private Renderer hitRenderer;
    void Update()
    {
        //設定方向為前方 因為會旋轉所以必須轉換座標
        Vector3 forward = transform.
        TransformDirection(Vector3.forward);
        //建立一個射線
        Ray ray = new Ray(transform.position, forward);
        //劃出射線(除錯用 遊戲內看不到)
        Debug.DrawRay(ray.origin, ray.direction * distance, Color.blue);
        //取得碰撞
        RaycastHit hit;
        //使用Layername取得layerMask
        int layerMask = LayerMask.GetMask("NPC_Layer");
        //判斷是否有碰撞物體加入了layerMask
        if(Physics.Raycast(ray, out hit, distance, layerMask)){
            //改變顏色為藍色
            hitRenderer = hit.collider.GetComponent<Renderer>();
            hitRenderer.material.color = Color.blue;
        }else if(hitRenderer != null){
            //沒有碰撞改變為紅色
            hitRenderer.material.color = Color.red;
            hitRenderer = null;
        }
    }
}
