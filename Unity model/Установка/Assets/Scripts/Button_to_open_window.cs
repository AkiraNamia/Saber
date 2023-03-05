using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Button_to_open_window : MonoBehaviour
{
	public GameObject table;
	// Update is called once per frame


	void Start()
	{
		Close(); //  ��������� ����������� ���� � ������ ������ ����. 
	}
	public void OnClose()
	{
		Close(); //  �������� ���������� ����� ������� ������������ ����. 
		
	}
	public void Open()
	{
		table.SetActive(true); //   ������������ ������, ����� ������� ����.  
	}
	public void Close()
	{
		table.SetActive(false); // �������������� ������, ����� ������� ����.  
	}
	public void OnMouseUp()
	{
		Open();
		Debug.Log("Table opened");
	}
	
}
