using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecieveEvent : MonoBehaviour
{
    void OnEnable(){
        //註冊DestoryActionEvent事件
        SendEvent.DestoryActionEvent += clearGameObject;     
    }
    void OnDisable(){
        //取消DestoryActionEvent事件
        SendEvent.DestoryActionEvent -= clearGameObject;
    }

    //移除GameObject物件
    public void clearGameObject(int second){
        Destroy(gameObject, second);
    }
}
