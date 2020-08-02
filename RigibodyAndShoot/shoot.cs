using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    //發射速度
    public Vector3 shootSpeed;
    //發射子彈的rigidbody
    private Rigidbody shootRigidbody;
    void Start()
    {
        //取得rigidbody
        shootRigidbody = GetComponent<Rigidbody>();
    }

    public void Shoot(){
        //將靜態預設false,不然無法移動
        shootRigidbody.isKinematic = false;
        //發射子彈
        shootRigidbody.AddForce(shootSpeed);
    }

}
