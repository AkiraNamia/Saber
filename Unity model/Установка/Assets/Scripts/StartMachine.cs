using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class StartMachine : MonoBehaviour, IPointerClickHandler
{
    public Animator anim7x5Cut;
    public Animator anim6x5Cut;
    public Animator anim5x3Cut;
    public Animator elup;
    public Animator prizym;
    public Animator pila;
    public Animator ostatki;
    public Animator ostatki2;
    public GameObject ost;

    public Vector3 vec7x5 = new Vector3(1.03f, 3.13f, -6.46f);
    public Vector3 vec7x5Len = new Vector3(1.03f, 3.13f, -5.49f);
    public Vector3 vec3x5 = new Vector3(-0.62f, 3f, -4.96f);
    public Vector3 vec3x5Len = new Vector3(1.03f, 3.13f, -5.49f);
    public Vector3 vec5x6Len = new Vector3(0.52f, 2.98f, -6.02f);
    public Vector3 vec5x6 = new Vector3(-0.26f, 2.98f, -6.02f);

   
    public void OnPointerClick(PointerEventData eventData)
    {
       
        if (GameObject.Find("Доска2").transform.position == vec7x5)
        {
            anim7x5Cut.Play("wood7x5CutAnimWidth");
            elup.Play("ElementUp");
            prizym.Play("PrizymDown");
            pila.Play("PilaAnim");
            ostatki.Play("ostatki");

        }

        if (GameObject.Find("Доска2").transform.position == vec7x5Len)
        {

            anim7x5Cut.Play("wood7x5CutAnimLength");
            elup.Play("ElementUp2");
            prizym.Play("PrizymDown2");
            pila.Play("PilaAnim2");
            ostatki2.Play("ostatki2");


        }
        if (GameObject.Find("Доска1").transform.position == vec5x6)
        {
            anim6x5Cut.Play("wood5x6animCutWidth");
            elup.Play("ElementUp");
            prizym.Play("PrizymDown");
            pila.Play("PilaAnim");
            ostatki.Play("ostatki");


        }
        if (GameObject.Find("Доска1").transform.position == vec5x6Len)
        {
            anim6x5Cut.Play("wood5x6animCutLength");
            elup.Play("ElementUp2");
            prizym.Play("PrizymDown2");
            pila.Play("PilaAnim2");
            ostatki2.Play("ostatki2");


        }
        if (GameObject.Find("Доска3").transform.position == vec3x5)
        {
            anim5x3Cut.Play("wood3x5animWidth");
            elup.Play("ElementUp");
            prizym.Play("PrizymDown");
            pila.Play("PilaAnim");
            ostatki.Play("ostatki");


        }
        if (GameObject.Find("Доска3").transform.position == vec3x5Len)
        {
            anim5x3Cut.Play("wood3x5animLength");
            elup.Play("ElementUp2");
            prizym.Play("PrizymDown2");
            pila.Play("PilaAnim2");
            ostatki2.Play("ostatki2");

        }
    }


}
