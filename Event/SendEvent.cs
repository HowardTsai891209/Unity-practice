using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendEvent : MonoBehaviour
{
    public bool canDestory;
    public int second = 2;
    //宣告一個代理(delegate)類型
    //命名為DestoryAction
    public delegate void DestoryAction(int second);
    //宣告一個event是DestoryAction類型的
    //能註冊的方法必須滿足以下條件
    //沒有回傳值
    //可接收一個整數參數
    public static event DestoryAction DestoryActionEvent;
    void Update()
    {
        if(canDestory){
            //觸發Destory事件
            if(DestoryActionEvent != null){
                DestoryActionEvent(second);
            }
            canDestory = false;
        }
    }
}
