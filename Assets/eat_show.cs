using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class eat_show : MonoBehaviour
{
    public Button myButton;
    public Button myButton1;
    public Button myButton2;

    // Start is called before the first frame update
    void Start()
    {
        
        myButton = GetComponent<Button>();
        
        HideButton();

    }

    // Update is called once per frame
    void Update()
    {
        if (myButton != null)
        {
            myButton.onClick.AddListener(OnClick);
            
        }
        
    }
    void HideButton()
    {
        // 將按鈕設置為不可見
        if (myButton1 != null)
        {
            myButton1.gameObject.SetActive(false);
        }

        if (myButton2 != null)
        {
            myButton2.gameObject.SetActive(false);
        }
    }

    void ShowButton()
    {
        // 將按鈕設置為可見
        if (myButton1 != null)
        {
            myButton1.gameObject.SetActive(true);
        }

        if (myButton2 != null)
        {
            myButton2.gameObject.SetActive(true);
        }

    }
    void OnClick()
    {
        if (myButton1 != null && myButton2 != null)
        {
            ShowButton();
            Invoke("pink", 3);
        }
        else
        {
            // 处理对象未正确初始化的情况，可以输出错误信息到控制台
            Debug.LogError("myButton1 or myButton2 is not initialized!");
        }
    }
    void pink()
    {
        HideButton();
    }
    

}
