using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class cheak : MonoBehaviour
{
    public Button button_d;
    public Button button_f;
    public Image image_d;
    public Image image_f;
    //public Button button2;
    private int originalLayer;
    private int targetLayer_d;
    private int targetLayer_f;
    public Animator animator;
    int n;
    
    void Start()
    {
        // 获取 Animator 组件
        animator = GetComponent<Animator>();
        // 记录原始图层
        originalLayer = gameObject.layer;

        // 假设 "Other Layer" 在图层管理器中有定义
        targetLayer_d = LayerMask.GetMask("drink");
        targetLayer_f = LayerMask.GetMask("food");

        // 添加按钮点击事件监听器
        button_d.onClick.AddListener(OnButton_dClick);
        button_f.onClick.AddListener(OnButton_fClick);

        // 确保 "JumpTrigger" 触发器存在
        HideImage(image_f);
        HideImage(image_d);


    }
    // 隐藏图片
    void HideImage(Image hide)
    {
        if (hide != null)
        {
            hide.enabled = false;
        }
    }

    // 显示图片
    void ShowImage(Image show)
    {
        if (show != null)
        {
            show.enabled = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnButton_dClick()
    {
        
        // 切换到目标层级
        StartCoroutine(JumpAndPlayAnimation(targetLayer_d, "JumpTrigger_d"));
    }

    void OnButton_fClick()
    {
        // 第二个按钮被点击时执行的逻辑
        StartCoroutine(JumpAndPlayAnimation(targetLayer_f, "JumpTrigger_f"));
    }


    private IEnumerator JumpAndPlayAnimation(int targetLayer, string triggerName)
    {
        // 切换到目标层级
        gameObject.layer = targetLayer;

        
        // 播放跳跃动画
        animator.SetTrigger(triggerName);



        Invoke("pinkd", 0.5f);
        // 等待动画播放完毕
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length);
        
        Invoke("pink", 1.0f);

        if (targetLayer == targetLayer_d)
        {
            n = 1;
        }
        else if (targetLayer == targetLayer_f)
        {
            n = 0;
        }
        // 切回原始层级
        gameObject.layer = originalLayer;
        
    }
    void pink()
    {
        if (n == 1)
        {
            HideImage(image_d);
        }
        else { HideImage(image_f); }
    }
    void pinkd()
    {   
        if(n==1)
        {
            ShowImage(image_d);
        }
        else
        {
            ShowImage(image_f);
        }
        
    }
}

