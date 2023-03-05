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
		Close(); //  Закрываем всплывающее окно в момент начала игры. 
	}
	public void OnClose()
	{
		Close(); //  Заменяем отладочный текст методом всплывающего окна. 
		
	}
	public void Open()
	{
		table.SetActive(true); //   Активировать объект, чтобы открыть окно.  
	}
	public void Close()
	{
		table.SetActive(false); // Деактивировать объект, чтобы закрыть окно.  
	}
	public void OnMouseUp()
	{
		Open();
		Debug.Log("Table opened");
	}
	
}
