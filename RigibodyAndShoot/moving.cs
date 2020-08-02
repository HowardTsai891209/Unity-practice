using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    //移動速度
    public float speed = 100;
    //取得cube rigidbody
    private new Rigidbody rigidbody;
    //取得發射物件
    private shoot shootObj;
    void Start()
    {
        //取得cube rigidbody元件
        rigidbody = GetComponent<Rigidbody>();
        //取得子物件的shoot元件
        shootObj = GetComponentInChildren<shoot>();
    }
    //因為是物理部分所以放在fixedupdate
    void FixedUpdate()
    {
        //左右移動
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        //按下滑鼠左鍵
        if(Input.GetMouseButton(0)){
            shootObj.Shoot();
        }
        //設定力的方向
        Vector3 force = new Vector3(x * speed, 0, y * speed);
        //給rigidbody一個力
        rigidbody.AddForce(force);
    }
}
