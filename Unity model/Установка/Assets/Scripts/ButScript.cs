using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButScript : MonoBehaviour, IPointerClickHandler
{

        [SerializeField]
        private Text message;               //ОБЪЕКТНАЯ ПЕРЕМЕННАЯ ТИПА TEXT  
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
        CloseT(); //  Закрываем всплывающее окно в момент начала игры. 
        PanelDown.SetActive(false);
    }

    public void OnOpenSettings()
    {
        Open(); //  Заменяем отладочный текст методом всплывающего окна. 
        message.text = "Раскроечный центр Selco EB70";
    }

    public void Open()
    {
        textT.SetActive(true); //   Активировать объект, чтобы открыть окно.  
    }
    public void CloseT()
    {
        textT.SetActive(false); // Деактивировать объект, чтобы закрыть окно.  
    }

    //public void OpenParam()
    //{
    //    tableParam.SetActive(true); //   Активировать объект, чтобы открыть окно.  
    //}
    //public void CloseParam()
    //{
    //    tableParam.SetActive(false); // Деактивировать объект, чтобы закрыть окно.  
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
    //{   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
    //    message.text = "Раскроечный центр Selco EB70";
    //}
    public void OnExit()
    {  //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ПРИ УХОДЕ КУРСОРА МЫШИ С КНОПКИ
        CloseT();
        message.text = " ";
    }
    public void ChangColCPU()
    {
        comp.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        task1.text = "ЧПУ - содержит основные команды управления и позволяет устанавливать параметры распила деталей.";
    }

    public void ChangCol1CPU()
    {
        comp.GetComponent<Renderer>().material = cpu;
    }
    public void ChangColCorp()
    {
        corp.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        task1.text = "Корпус - содержит в себе основную и подрезную пилу.";

    }

    public void ChangCol1Corp()
    {
        corp.GetComponent<Renderer>().material = cpu;
    }
    public void ChangColDer()
    {
        der.GetComponent<Renderer>().material.color = new Color(1, 0, 0);
        task1.text = "Суппорт - поддерживает деталь во время погрузки и разгрузки.";

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
        task1.text = "Доски - основные рабочие детали.";

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
        task1.text = "Основание - основная структура станка .";

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
    //    table.SetActive(false); // Деактивировать объект, чтобы закрыть окно.  
    //}
    public void Task1()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        task1.text = "Выберите доску и переместите её на рспилочную панель. (Для этого нажмите на кнопку 'Доска' на панели, после чего, выберете необходимую доску.)";
    }
    public void Task2()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ
 task1.text = "Нажмите на красную кнопку, расположенную на ЧПУ. (Для этого нажмите на кнопку 'ЧПУ' на панели.)";

    }
    public void Task3()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        task1.text = "Введите и занесите в таблицу начальные и конечные параметры распила, соответствующие выбранной доске.";

    }
    public void Task4()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        task1.text = "Нажмите на красную кнопку, расположенную справа на основании распилочного станка. (Для этого нажмите на кнопку 'Основание' на панели.)";
    }
    public void Task5()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        task1.text = "Повторно нажмите на красную кнопку, расположенную справа на основании распилочного станка, для разворота детали. (Для этого нажмите на кнопку 'Основание' на панели.)";
    }
    public void Task6()
    {   //  МЕТОД, ВЫЗЫВАЕМЫЙ ПОЛЬЗОВАТЕЛЕМ ЩЕЛЧКОМ ПО КНОПКЕ 
        task1.text = "Получите результат.";
    }
    public void OutSrc()
    {
        Application.Quit();    // закрыть приложение
    }
}
