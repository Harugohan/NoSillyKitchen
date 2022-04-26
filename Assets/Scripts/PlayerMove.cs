using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed; //  取2-3合适
    new private Rigidbody2D rigidbody;
    private Animator animator;
    private float inputX, inputY;
    private float stopX, stopY;   

    private Vector3 offset;      
    // 记录用户停止输入后,最后InputXY的值,防止动画器回归默认
    // 只有inputXY不为0时才更新这两个值,然后把这两个值传给动画

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        offset = Camera.main.transform.position - transform.position;       // 设置摄像机跟随玩家
    }

    // Update is called once per frame
    void Update()
    {
        inputX = Input.GetAxisRaw("Horizontal");    // 获取左右AD并返回[-1,1]的值
        inputY = Input.GetAxisRaw("Vertical");
        Vector2 input = new Vector2(inputX, inputY).normalized; // 执行标准化,否则x,y方向速度叠加,整体移动的速度就会大于1
        rigidbody.velocity = input * speed;


        // 控制动画
        if(input != Vector2.zero){
            animator.SetBool("isMoving", true);     // 函数挺好理解
            stopX = inputX;
            stopY = inputY;
            
        }
        else{
            animator.SetBool("isMoving", false);
        }
        animator.SetFloat("InputX", stopX);
        animator.SetFloat("InputY", stopY);     // 注意变量名一定要打对,否则动画器看不到任何反应
        Camera.main.transform.position = transform.position + offset;       // 相机跟随玩家
    }
}
