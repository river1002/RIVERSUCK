using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class changeimage : MonoBehaviour
{
    public Image image;
    public Sprite[] newSprites;  // 将 newSprite 设计成 Sprite 数组
    private int currentIndex = 0;

    void Start()
    {
        // 无需再次获取 Image 组件，已经在 Inspector 中指定了
        // 在启动时设置初始的 Source Image，如果为空则使用数组中的第一个 Sprite
        image.sprite = image.sprite != null ? image.sprite : (newSprites.Length > 0 ? newSprites[0] : null);
    }

    void Update()
    {
        // 在这里可以添加其他逻辑，例如检测按钮点击、条件判断等

        // 当按下空格键时，循环切换 Source Image
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeImageSource();
        }
    }

    void ChangeImageSource()
    {
        // 循环切换 Image 组件的 Source Image
        if (newSprites.Length > 0)
        {
            currentIndex = (currentIndex + 1) % newSprites.Length;
            image.sprite = newSprites[currentIndex];
        }
    }
}
