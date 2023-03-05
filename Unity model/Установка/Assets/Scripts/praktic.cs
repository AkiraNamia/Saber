using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class praktic : MonoBehaviour
{
	[SerializeField]
	private Text message;

	void Start()
	{
		Close(); //  ��������� ����������� ���� � ������ ������ ����. 
	}

	public void OnOpenSettings()
	{
		Open(); //  �������� ���������� ����� ������� ������������ ����. 
		message.text = "��������� ��������������� ������� 1-6";
	}

	public void Open()
	{
		gameObject.SetActive(true); //   ������������ ������, ����� ������� ����.  
	}
	public void Close()
	{
		gameObject.SetActive(false); // �������������� ������, ����� ������� ����.  
	}
}
