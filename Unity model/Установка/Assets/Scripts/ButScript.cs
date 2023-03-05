using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButScript : MonoBehaviour, IPointerClickHandler
{

        [SerializeField]
        private Text message;               //��������� ���������� ���� TEXT  
        public Text task1;             
    public GameObject comp;
    public GameObject corp;
    public GameObject der;
    public GameObject dosk;
    public GameObject dosk2;
    public GameObject dosk3;
    public GameObject osnovanie;
    public Material cpu;
    public Material doska;
    public Material osn;
    //public GameObject table;
    //public GameObject tableParam;
    public GameObject textT;
    public GameObject PanelDown;

    void Start()
    {
        CloseT(); //  ��������� ����������� ���� � ������ ������ ����. 
        PanelDown.SetActive(false);
    }

    public void OnOpenSettings()
    {
        Open(); //  �������� ���������� ����� ������� ������������ ����. 
        message.text = "����������� ����� Selco EB70";
    }

    public void Open()
    {
        textT.SetActive(true); //   ������������ ������, ����� ������� ����.  
    }
    public void CloseT()
    {
        textT.SetActive(false); // �������������� ������, ����� ������� ����.  
    }

    //public void OpenParam()
    //{
    //    tableParam.SetActive(true); //   ������������ ������, ����� ������� ����.  
    //}
    //public void CloseParam()
    //{
    //    tableParam.SetActive(false); // �������������� ������, ����� ������� ����.  
    //}

    //public void TableParamShow()
    //{
    //    OpenParam();
    //}
    //public void TableParamClose()
    //{
    //    CloseParam();
    //}
    //public void OnSettings()
    //{   //  �����, ���������� ������������� ������� �� ������ 
    //    message.text = "����������� ����� Selco EB70";
    //}
    public void OnExit()
    {  //  �����, ���������� ������������� ��� ����� ������� ���� � ������
        CloseT();
        message.text = " ";
    }
    public void ChangColCPU()
    {
        comp.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        task1.text = "��� - �������� �������� ������� ���������� � ��������� ������������� ��������� ������� �������.";
    }

    public void ChangCol1CPU()
    {
        comp.GetComponent<Renderer>().material = cpu;
    }
    public void ChangColCorp()
    {
        corp.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        task1.text = "������ - �������� � ���� �������� � ��������� ����.";

    }

    public void ChangCol1Corp()
    {
        corp.GetComponent<Renderer>().material = cpu;
    }
    public void ChangColDer()
    {
        der.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        task1.text = "������� - ������������ ������ �� ����� �������� � ���������.";

    }

    public void ChangCol1Der()
    {
        der.GetComponent<Renderer>().material = cpu;
    }
    public void ChangColDosk()
    {
        dosk.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        dosk2.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        dosk3.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        task1.text = "����� - �������� ������� ������.";

    }

    public void ChangCol1Dosk()
    {
        dosk.GetComponent<Renderer>().material = doska;
        dosk2.GetComponent<Renderer>().material = doska;
        dosk3.GetComponent<Renderer>().material = doska;
    }
    public void ChangColOsn()
    {
        osnovanie.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        task1.text = "��������� - �������� ��������� ������ .";

    }

    public void ChangCol1Osn()
    {
        osnovanie.GetComponent<Renderer>().material = osn;
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        
    }
    //public void Close()
    //{
    //    table.SetActive(false); // �������������� ������, ����� ������� ����.  
    //}
    public void Task1()
    {   //  �����, ���������� ������������� ������� �� ������ 
        task1.text = "�������� ����� � ����������� � �� ���������� ������. (��� ����� ������� �� ������ '�����' �� ������, ����� ����, �������� ����������� �����.)";
    }
    public void Task2()
    {   //  �����, ���������� ������������� ������� �� ������
 task1.text = "������� �� ������� ������, ������������� �� ���. (��� ����� ������� �� ������ '���' �� ������.)";

    }
    public void Task3()
    {   //  �����, ���������� ������������� ������� �� ������ 
        task1.text = "������� � �������� � ������� ��������� � �������� ��������� �������, ��������������� ��������� �����.";

    }
    public void Task4()
    {   //  �����, ���������� ������������� ������� �� ������ 
        task1.text = "������� �� ������� ������, ������������� ������ �� ��������� ������������ ������. (��� ����� ������� �� ������ '���������' �� ������.)";
    }
    public void Task5()
    {   //  �����, ���������� ������������� ������� �� ������ 
        task1.text = "�������� ������� �� ������� ������, ������������� ������ �� ��������� ������������ ������, ��� ��������� ������. (��� ����� ������� �� ������ '���������' �� ������.)";
    }
    public void Task6()
    {   //  �����, ���������� ������������� ������� �� ������ 
        task1.text = "�������� ���������.";
    }
    public void OutSrc()
    {
        Application.Quit();    // ������� ����������
    }
}
