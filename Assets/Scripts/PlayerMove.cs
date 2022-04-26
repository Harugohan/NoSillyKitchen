using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed; //  ȡ2-3����
    new private Rigidbody2D rigidbody;
    private Animator animator;
    private float inputX, inputY;
    private float stopX, stopY;   

    private Vector3 offset;      
    // ��¼�û�ֹͣ�����,���InputXY��ֵ,��ֹ�������ع�Ĭ��
    // ֻ��inputXY��Ϊ0ʱ�Ÿ���������ֵ,Ȼ���������ֵ��������

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        offset = Camera.main.transform.position - transform.position;       // ����������������
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");    // ��ȡ����AD������[-1,1]��ֵ
        inputY = Input.GetAxisRaw("Vertical");
        Vector2 input = new Vector2(inputX, inputY).normalized; // ִ�б�׼��,����x,y�����ٶȵ���,�����ƶ����ٶȾͻ����1
        rigidbody.velocity = input * speed;


        // ���ƶ���
        if(input != Vector2.zero){
            animator.SetBool("isMoving", true);     // ����ͦ�����
            stopX = inputX;
            stopY = inputY;
            
        }
        else{
            animator.SetBool("isMoving", false);
        }
        animator.SetFloat("InputX", stopX);
        animator.SetFloat("InputY", stopY);     // ע�������һ��Ҫ���,���򶯻����������κη�Ӧ
        Camera.main.transform.position = transform.position + offset;       // ����������
    }
}
