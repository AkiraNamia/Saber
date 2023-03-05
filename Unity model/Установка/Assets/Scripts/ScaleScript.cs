using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;



public class ScaleScript : MonoBehaviour
{
    public Vector3 vec7x5Cutwid = new Vector3(1.03f, 3.13f, 0.25f);
    public Vector3 vec7x5Cutlen = new Vector3(1.03f, 3.13f, 1.8f);
    public GameObject doska5x6;
    public Vector3 vec5x6 = new Vector3(-29.8f, 9.89f, -4.34f);
    public Vector3 startpos;
    public Vector3 endpos = new Vector3(0f, 9.89f, -4.34f);
    public float prog;
    public float step = 0.01f;
    [SerializeField]
    Text LastLengthText1;
    [SerializeField]
    Text FirstLengthText1;
    [SerializeField]
    Text LastWidthText1;
    [SerializeField]
    Text FirstWidthText1;
    private int length;
    private int lengthfirst;
    private int width;
    private int widthfirst;
    private int endlen;
    private int endwid;
   
    void Start()
    {
        GameObject.Find("Ostatki").transform.localScale = new Vector3(0f, 0f, 0f);
        GameObject.Find("Ostatki2").transform.localScale = new Vector3(0f, 0f, 0f);

    }
    public void CutWid()
    {
        length = (int.Parse(LastLengthText1.text.ToString()));
        lengthfirst = (int.Parse(FirstLengthText1.text.ToString()));
        width = (int.Parse(LastWidthText1.text.ToString()));
        widthfirst = (int.Parse(FirstWidthText1.text.ToString()));
        Debug.Log(length);
        Debug.Log(width);

        GameObject.Find("Доска2").transform.localScale = new Vector3(length, widthfirst, 0.2f);
        

    }
    public void CutLen()
    {
        length = (int.Parse(LastLengthText1.text.ToString()));
        width = (int.Parse(LastWidthText1.text.ToString()));
        Debug.Log(length);
        Debug.Log(width);

        GameObject.Find("Доска2").transform.localScale = new Vector3(length, width, 0.2f);


    }
   
    public void Cut5x6Wid()
    {
        length = (int.Parse(LastLengthText1.text.ToString()));
        lengthfirst = (int.Parse(FirstLengthText1.text.ToString()));
        width = (int.Parse(LastWidthText1.text.ToString()));
        widthfirst = (int.Parse(FirstWidthText1.text.ToString()));
        Debug.Log(length);
        Debug.Log(width);

        GameObject.Find("Доска1").transform.localScale = new Vector3(lengthfirst, width, 0.2f);



    }
    public void Cut5x6Len()
    {

        length = (int.Parse(LastLengthText1.text.ToString()));
        width = (int.Parse(LastWidthText1.text.ToString()));
        Debug.Log(length);
        Debug.Log(width);

        GameObject.Find("Доска1").transform.localScale = new Vector3(length, width, 0.2f);


    }
    public void Cut3x5Len()
    {
        length = (int.Parse(LastLengthText1.text.ToString()));
        width = (int.Parse(LastWidthText1.text.ToString()));
        Debug.Log(length);
        Debug.Log(width);


        GameObject.Find("Доска3").transform.localScale = new Vector3(length, width, 0.2f);


    }
    public void Cut3x5Wid()
    {
        length = (int.Parse(LastLengthText1.text.ToString()));
        lengthfirst = (int.Parse(FirstLengthText1.text.ToString()));
        width = (int.Parse(LastWidthText1.text.ToString()));
        widthfirst = (int.Parse(FirstWidthText1.text.ToString()));
        Debug.Log(length);
        Debug.Log(width);

        GameObject.Find("Доска3").transform.localScale = new Vector3(lengthfirst, width, 0.2f);


    }
    public void OstWid()
    {
        length = (int.Parse(LastLengthText1.text.ToString()));
        lengthfirst = (int.Parse(FirstLengthText1.text.ToString()));
        width = (int.Parse(LastWidthText1.text.ToString()));
        widthfirst = (int.Parse(FirstWidthText1.text.ToString()));
        endlen = lengthfirst - length;
        endwid = widthfirst - width;
        Debug.Log(endwid);
        Debug.Log(endlen);

        GameObject.Find("Ostatki").transform.localScale = new Vector3(endwid, 0.2f, length);
    }
    public void OstLen()
    {
        length = (int.Parse(LastLengthText1.text.ToString()));
        lengthfirst = (int.Parse(FirstLengthText1.text.ToString()));
        width = (int.Parse(LastWidthText1.text.ToString()));
        widthfirst = (int.Parse(FirstWidthText1.text.ToString()));
        endlen = lengthfirst - length;
        endwid = widthfirst - width;
        Debug.Log(endwid);
        Debug.Log(endlen);

        GameObject.Find("Ostatki2").transform.localScale = new Vector3(width, 0.2f, endlen);


    }
}
