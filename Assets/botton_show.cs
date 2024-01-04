using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
//測試用的
public class botton_show : MonoBehaviour
{
    public Button myButton;
    
    // Start is called before the first frame update
    void Start()
    {
        HideButton();
        StartCoroutine(ShowButtonAfterDelay(3.0f));
    }

    // Update is called once per frame
    void Update()
    {
    
    }
    void HideButton()
    {
        // �N���s�]�m�����i��
        myButton.gameObject.SetActive(false);
       
    }

    void ShowButton()
    {
        // �N���s�]�m���i��
        myButton.gameObject.SetActive(true);
        
    }
    IEnumerator ShowButtonAfterDelay(float delay)
    {
        while (true)
        {
            // �p�G���Х���Q���U
            if (Input.GetKey(KeyCode.Mouse0))
            {
                
                // ��ܫ��s
                ShowButton();

                // ����3��
                yield return new WaitForSeconds(delay);
                // ���ë��s
                HideButton();

            }

            // ���ݤU�@�V
            yield return null;
        }
    }
}
