using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseGrabItem : MonoBehaviour
{
    Vector2 mousePos;
    Vector2 distance;
    Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
        // 注意需要刚体组件
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // 更新鼠标位置
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("mousex:" + distance.x + " mousey:" + distance.y);
    }

    private void OnMouseDown() {
        Debug.Log("onMouseDown");
        // 仅在鼠标按下位置在碰撞体内时，记录位置差
        distance = new Vector2(transform.position.x, transform.position.y) - mousePos;
    }

    private void OnMouseDrag() {
        // 鼠标拖动时实时更新物体位置
        Debug.Log("onMouseDrag");
        transform.position = mousePos + distance;
        
        Debug.Log("x:" + transform.position.x + " y:" + transform.position.y);
        rb2D.gravityScale = 0;  // 防止拖动时仍受重力坠落
        rb2D.velocity = Vector2.zero;
    }

    private void OnMouseUpAsButton() {
        // 在同一碰撞器松开鼠标时
        // rb2D.gravityScale = 3;  // 恢复重力
    }
}
