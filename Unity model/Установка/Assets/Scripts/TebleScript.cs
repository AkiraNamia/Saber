using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TebleScript : MonoBehaviour
{
    [SerializeField]
    InputField FirstLengthInput;
    [SerializeField]
    InputField LastLengthInput;
    [SerializeField]
    InputField FirstWidthInput;
    [SerializeField]
    InputField LastWidthInput;

    [SerializeField]
    Text FirstLengthText1;
    [SerializeField]
    Text FirstLengthText2;
    [SerializeField]
    Text FirstLengthText3;
    [SerializeField]
    Text FirstLengthText4;
    [SerializeField]
    Text FirstLengthText5;
    [SerializeField]
    Text LastLengthText1;
    [SerializeField]
    Text LastLengthText2;
    [SerializeField]
    Text LastLengthText3;
    [SerializeField]
    Text LastLengthText4;
    [SerializeField]
    Text LastLengthText5;
    [SerializeField]
    Text FirstWidthText1;
    [SerializeField]
    Text FirstWidthText2;
    [SerializeField]
    Text FirstWidthText3;
    [SerializeField]
    Text FirstWidthText4;
    [SerializeField]
    Text FirstWidthText5;
    [SerializeField]
    Text LastWidthText1;
    [SerializeField]
    Text LastWidthText2;
    [SerializeField]
    Text LastWidthText3;
    [SerializeField]
    Text LastWidthText4;
    [SerializeField]
    Text LastWidthText5;
    public Text square1;
    public Text square2;
    public Text square3;
    public Text square4;
    public Text square5;
    public Text cost1;
    public Text cost2;
    public Text cost3;
    public Text cost4;
    public Text cost5;
    public GameObject table;
    private float length;
    private float width;
    public GameObject doska2;
    public GameObject btner;

    void Start()
    {
        CloseBtn(); //  Закрываем всплывающее окно в момент начала игры. 
    }
    public void OnClose()
    {
        Close(); //  Заменяем отладочный текст методом всплывающего окна. 

    }

    public void Close()
    {
        table.SetActive(false); // Деактивировать объект, чтобы закрыть окно.  
    }
    public void CloseBtn()
    {
        btner.SetActive(false); // Деактивировать объект, чтобы закрыть окно.  
    }
    public void WriteValue()
    {

       
        if (FirstLengthInput.text.ToString() != " " && LastLengthInput.text.ToString() != " " && FirstWidthInput.text.ToString() != " " && LastWidthInput.text.ToString() != " ")
        {
            if (((FirstLengthInput.text.ToString() == "3" && FirstWidthInput.text.ToString() == "3")&&(float.Parse(LastLengthInput.text.ToString()) <= 3 && float.Parse(LastWidthInput.text.ToString()) <= 3)) || ((FirstLengthInput.text.ToString() == "4" && FirstWidthInput.text.ToString() == "3") && (float.Parse(LastLengthInput.text.ToString()) <= 4 && float.Parse(LastWidthInput.text.ToString()) <= 3)) || ((FirstLengthInput.text.ToString() == "4" && FirstWidthInput.text.ToString() == "4") && (float.Parse(LastLengthInput.text.ToString()) <= 4 && float.Parse(LastWidthInput.text.ToString()) <= 4)))
            {
                

                if (FirstLengthText1.text == "-")
                    FirstLengthText1.text = FirstLengthInput.text.ToString();
                else if (FirstLengthText2.text == "-")
                {
                    FirstLengthText2.text = FirstLengthInput.text.ToString();
                }
                else if (FirstLengthText3.text == "-")
                {
                    FirstLengthText3.text = FirstLengthInput.text.ToString();
                }
                else if (FirstLengthText4.text == "-")
                {
                    FirstLengthText4.text = FirstLengthInput.text.ToString();
                }
                else if (FirstLengthText5.text == "-")
                {
                    FirstLengthText5.text = FirstLengthInput.text.ToString();
                }

                if (LastLengthText1.text == "-")
                {
                    LastLengthText1.text = LastLengthInput.text.ToString();
                }
                else if (LastLengthText2.text == "-")
                {
                    LastLengthText2.text = LastLengthInput.text.ToString();
                }
                else if (LastLengthText3.text == "-")
                {
                    LastLengthText3.text = LastLengthInput.text.ToString();
                }
                else if (LastLengthText4.text == "-")
                {
                    LastLengthText4.text = LastLengthInput.text.ToString();
                }
                else if (LastLengthText5.text == "-")
                {
                    LastLengthText5.text = LastLengthInput.text.ToString();
                }
                if (FirstWidthText1.text == "-")
                    FirstWidthText1.text = FirstWidthInput.text.ToString();
                else if (FirstWidthText2.text == "-")
                {
                    FirstWidthText2.text = FirstWidthInput.text.ToString();
                }
                else if (FirstWidthText3.text == "-")
                {
                    FirstWidthText3.text = FirstWidthInput.text.ToString();
                }
                else if (FirstWidthText4.text == "-")
                {
                    FirstWidthText4.text = FirstWidthInput.text.ToString();
                }
                else if (FirstWidthText5.text == "-")
                {
                    FirstWidthText5.text = FirstWidthInput.text.ToString();
                }
                if (LastWidthText1.text == "-")
                {
                    LastWidthText1.text = LastWidthInput.text.ToString();
                    square1.text = (float.Parse(LastLengthText1.text) * float.Parse(LastWidthText1.text)).ToString();
                    cost1.text = (float.Parse(square1.text) * 5).ToString();
                }
                else if (LastWidthText2.text == "-")
                {
                    LastWidthText2.text = LastWidthInput.text.ToString();
                    square2.text = (float.Parse(LastLengthText2.text) * float.Parse(LastWidthText2.text)).ToString();
                    cost2.text = (float.Parse(square2.text) * 5).ToString();
                }
                else if (LastWidthText3.text == "-")
                {
                    LastWidthText3.text = LastWidthInput.text.ToString();
                    square3.text = (float.Parse(LastLengthText3.text) * float.Parse(LastWidthText3.text)).ToString();
                    cost3.text = (float.Parse(square3.text) * 5).ToString();
                }
                else if (LastWidthText4.text == "-")
                {
                    LastWidthText4.text = LastWidthInput.text.ToString();
                    square4.text = (float.Parse(LastLengthText4.text) * float.Parse(LastWidthText4.text)).ToString();
                    cost4.text = (float.Parse(square4.text) * 5).ToString();
                }
                else if (LastWidthText5.text == "-")
                {
                    LastWidthText5.text = LastWidthInput.text.ToString();
                    square5.text = (float.Parse(LastLengthText5.text) * float.Parse(LastWidthText5.text)).ToString();
                    cost5.text = (float.Parse(square5.text) * 5).ToString();

                }
            } 
            else
            {
                btner.SetActive(true);
            }
        }
        else
        {
            btner.SetActive(true);
        }
    }
 
    public void Clean()
    {
        FirstLengthText1.text = "-";
        LastLengthText1.text = "-";
        FirstWidthText1.text = "-";
        LastWidthText1.text = "-";
        FirstLengthText2.text = "-";
        LastLengthText2.text = "-";
        FirstWidthText2.text = "-";
        LastWidthText2.text = "-";
        FirstLengthText3.text = "-";
        LastLengthText3.text = "-";
        FirstWidthText3.text = "-";
        LastWidthText3.text = "-";
        FirstLengthText4.text = "-";
        LastLengthText4.text = "-";
        FirstWidthText4.text = "-";
        LastWidthText4.text = "-";
        FirstLengthText5.text = "-";
        LastLengthText5.text = "-";
        FirstWidthText5.text = "-";
        LastWidthText5.text = "-";
        square1.text = "-";
        square2.text = "-";
        square3.text = "-";
        square4.text = "-";
        square5.text = "-";
        cost1.text = "-";
        cost2.text = "-";
        cost3.text = "-";
        cost4.text = "-";
        cost5.text = "-";
    }

}
