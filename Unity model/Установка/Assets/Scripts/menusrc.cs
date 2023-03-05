using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class menusrc : MonoBehaviour
{
    bool pressBut;
    bool freeBut;
    public RectTransform slider;
    Vector2 v = new Vector2(90, 0);
    Vector2 v2 = new Vector2(-90, 0);
    public GameObject menubut;

    void Start()
    {
        //v = slider.anchoredPosition;
        slider.anchoredPosition = v;
        Debug.Log(v);

    }
    void Update()
    {
        if (pressBut)
        {
            float x = slider.anchoredPosition.x;
            float y = slider.anchoredPosition.y;
            x += 2;
            slider.anchoredPosition = new Vector2(x, y);
            if (slider.anchoredPosition.x >= v.x)
            {
                pressBut = false;
                Debug.Log(x);
            }

        }

        if (freeBut)
        {
            float x = slider.anchoredPosition.x;
            float y = slider.anchoredPosition.y;
            x -= 2f;
            slider.anchoredPosition = new Vector2(x, y);
            if (slider.anchoredPosition.x <= v2.x)
            {
                freeBut = false;
                Debug.Log(x);

            }
        }
    }
    public void Menu()
    {
        pressBut = true;
    }
    public void MenuShow()
    {
        freeBut = true;
    }
    public void ButMenuHide()
    {
        menubut.SetActive(false); //   Активировать объект, чтобы открыть окно.  
    }
    public void ButMenuShow()
    {
        menubut.SetActive(true); //   Активировать объект, чтобы открыть окно.  
    }
}
