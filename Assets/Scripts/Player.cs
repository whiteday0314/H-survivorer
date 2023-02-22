using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private Rigidbody2D rg;
    private Animator ani;
    private SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
        ani = GetComponent<Animator>();
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    void Move() //캐릭터 이동함수 && 캐릭터 애니메이션
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");
        
        gameObject.transform.position += new Vector3(moveX, moveY, 0f).normalized * 5 * Time.deltaTime;
        if (moveX == -1)
            sp.flipX = true;

        if(moveX == 1)
            sp.flipX = false;
  
       
        ani.SetBool("IsRun", true);

        if (moveX == 0 && moveY == 0)
            ani.SetBool("IsRun", false);
    }
}
