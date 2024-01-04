using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class img_ui : MonoBehaviour
{
    public Transform objectToFollow; // 設置要跟隨的物件
    public Image moveButton; // 設置你的按鈕

    private Vector3 initialButtonPosition; // 初始按鈕位置
    private Vector3 initialObjectPosition; // 初始物件位置
    public float objectMoveSpeed; // 物件移動速度
    void Start()
    {
        // 儲存初始按鈕和物件位置
        initialButtonPosition = moveButton.transform.position;
        initialObjectPosition = objectToFollow.position;
    }

    // Update is called once per frame
    void Update()
    {

        // 抓取物件的移動向量
        Vector3 objectMovement = (objectToFollow.position - initialObjectPosition) * objectMoveSpeed;


        // 將物件的移動向量應用到按鈕的位置
        moveButton.transform.position += objectMovement;

        // 更新初始按鈕位置
        initialButtonPosition = objectToFollow.position;
        initialObjectPosition = objectToFollow.position;
    }
}
