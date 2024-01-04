using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pet_move2 : MonoBehaviour
{   
    public Animator ani;
    public float speed = 5f;
    
    

    // Start is called before the first frame update
    void Start()
    {
        ani=GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
        if(Input.GetKey("a")){
            Move(Vector2.left);
            ani.SetBool("a",true);
            ani.SetBool("s",false);
            ani.SetBool("d",false);
            
        }
        else if(Input.GetKey("d")){
            Move(Vector2.right);
            ani.SetBool("d",true);
            ani.SetBool("s",false);
            ani.SetBool("a",false);
            
        }
        else{
            ani.SetBool("s",true);
            ani.SetBool("a",false);
            ani.SetBool("d",false);
            
        }
        

        
    }
    void Move(Vector2 direction)
    {
        // 計算移動向量
        Vector2 movement = direction * speed * Time.deltaTime;

        // 直接將向量加到物體位置上
        transform.position += new Vector3(movement.x, movement.y, 0f);
    }
}

