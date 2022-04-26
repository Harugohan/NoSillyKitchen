using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChooseItem : MonoBehaviour
{
    SpriteRenderer sprite;      // 获取当前物体的sprite，SpriteRenderer用于渲染图像

    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnMouseEnter() {
        // 注意，要添加碰撞体组件，且该函数的触发依赖碰撞体(Collider2D)
        sprite.color = new Vector4(0.7f, 0.7f, 0.7f, 1);
    }

    private void OnMouseExit() {
        sprite.color = new Vector4(1, 1, 1, 1);     // 改色深
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
