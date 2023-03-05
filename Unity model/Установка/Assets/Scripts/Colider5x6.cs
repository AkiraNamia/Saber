using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Colider5x6 : MonoBehaviour, IPointerClickHandler
{

    public Animator anim7x5;
    public Animator anim5x6;
    public Animator anim3x5;
    public Vector3 vec7x5 = new Vector3(1.03f, 3.13f, -6.46f);
    public Vector3 vec3x5 = new Vector3(-0.62f, 3f, -4.96f);

    public void OnPointerClick(PointerEventData eventData)
    {
        anim5x6.Play("wood5x6anim");
        if (GameObject.Find("Доска2").transform.position == vec7x5)
        {
            Debug.Log("YES");
            anim7x5.Play("wood7x5animBack");
            
        }
        if (GameObject.Find("Доска3").transform.position == vec3x5)
        {
            Debug.Log("YES");
            anim3x5.Play("wood3x5animBack");

        }
        else 
        { anim5x6.Play("wood5x6anim"); 
           
        }

    }
  

}