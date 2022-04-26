using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingCamera : MonoBehaviour
{
    Transform[] childs;     // �������������ȡ����������


    // Start is called before the first frame update
    void Start()
    {
        childs = new Transform[transform.childCount];   // ���������岢�洢
        for(int i=0; i<transform.childCount; i++){
            childs[i] = transform.GetChild(i);          // ����
        }
    }

    // Update is called once per frame
    void Update()
    {
        // ��update�н�child����sprite�������
        for(int i=0; i<childs.Length; i++){
            childs[i].rotation = Camera.main.transform.rotation;

        }
    }
}
