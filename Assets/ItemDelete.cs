using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�ʏ�ۑ�
public class ItemDelete : MonoBehaviour
{
    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;
    
    //Unity�����ƃJ�����̋���
    private float difference;
    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
        //Unity�����ƃJ�����̈ʒu�iz���W�j�̍������߂�
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
