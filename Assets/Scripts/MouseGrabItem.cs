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
        // ע����Ҫ�������
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // �������λ��
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log("mousex:" + distance.x + " mousey:" + distance.y);
    }

    private void OnMouseDown() {
        Debug.Log("onMouseDown");
        // ������갴��λ������ײ����ʱ����¼λ�ò�
        distance = new Vector2(transform.position.x, transform.position.y) - mousePos;
    }

    private void OnMouseDrag() {
        // ����϶�ʱʵʱ��������λ��
        Debug.Log("onMouseDrag");
        transform.position = mousePos + distance;
        
        Debug.Log("x:" + transform.position.x + " y:" + transform.position.y);
        rb2D.gravityScale = 0;  // ��ֹ�϶�ʱ��������׹��
        rb2D.velocity = Vector2.zero;
    }

    private void OnMouseUpAsButton() {
        // ��ͬһ��ײ���ɿ����ʱ
        // rb2D.gravityScale = 3;  // �ָ�����
    }
}
