using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//通常課題
public class ItemDelete : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    
    //Unityちゃんとカメラの距離
    private float difference;
    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとカメラの位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
         if(unitychan.transform.position.z - transform.position.z > 8f)
         {
             Destroy(this.gameObject);
         }

    }
}
