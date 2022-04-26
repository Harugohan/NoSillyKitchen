using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChooseItem : MonoBehaviour
{
    SpriteRenderer sprite;      // ��ȡ��ǰ�����sprite��SpriteRenderer������Ⱦͼ��

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnMouseEnter() {
        // ע�⣬Ҫ�����ײ��������Ҹú����Ĵ���������ײ��(Collider2D)
        sprite.color = new Vector4(0.7f, 0.7f, 0.7f, 1);
    }

    private void OnMouseExit() {
        sprite.color = new Vector4(1, 1, 1, 1);     // ��ɫ��
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
