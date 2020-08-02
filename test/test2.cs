using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{
    void Start()
    {
        SceneInfo se1 = new SceneInfo(50, 60);
        SceneInfo se2 = se1;

        se1._height = 99;
        se2._height = 99;

        Debug.Log(se1._height);
        Debug.Log(se2._height);
    }

}
