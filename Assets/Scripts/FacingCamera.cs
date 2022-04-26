using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingCamera : MonoBehaviour
{
    Transform[] childs;     // 创建数组变量获取所有子物体


    // Start is called before the first frame update
    void Start()
    {
        childs = new Transform[transform.childCount];   // 遍历子物体并存储
        for(int i=0; i<transform.childCount; i++){
            childs[i] = transform.GetChild(i);          // 遍历
        }
    }

    // Update is called once per frame
    void Update()
    {
        // 在update中将child所有sprite朝向相机
        for(int i=0; i<childs.Length; i++){
            childs[i].rotation = Camera.main.transform.rotation;

        }
    }
}
