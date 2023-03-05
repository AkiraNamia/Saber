using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Colider3x5 : MonoBehaviour, IPointerClickHandler
{

    public Animator anim7x5;
    public Animator anim5x6;
    public Animator anim3x5;
    public Vector3 vec7x5 = new Vector3(1.03f, 3.13f, -6.46f);
    public Vector3 vec5x6 = new Vector3(-0.26f, 2.98f, -6.02f);
    public Vector3 vec3x5 = new Vector3(-0.62f, 3f, -4.96f);
    public Vector3 vec3x5first = new Vector3(-29.8f, 10.18f, -11.11f);
    public void OnPointerClick(PointerEventData eventData)
    {
        anim3x5.Play("wood3x5anim");
        if (GameObject.Find("Доска1").transform.position == vec5x6)
        {
                Debug.Log("YES");
                anim5x6.Play("wood5x6animBack");

        }
            if (GameObject.Find("Доска2").transform.position == vec7x5)
            {
                Debug.Log("YES");
                anim7x5.Play("wood7x5animBack");
                
            }
        else anim3x5.Play("wood3x5anim");

    }
}