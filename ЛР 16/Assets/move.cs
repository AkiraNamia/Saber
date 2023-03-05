using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Transform bashnya;
    Transform stvol;
    float TankMoveSpeed = 0.1f;
    float RotateSpeed = 1f;
    float min = 260f;
    float max = 300f;

    // Start is called before the first frame update
    void Start()
    {
        bashnya = gameObject.transform.Find("Box003");
        stvol = bashnya.transform.Find("Cylinder031");

    }

    // Update is called once per frame
    void Update()
    {
        float z = Input.GetAxis("Vertical");         // клавиши W и S
        if (z != 0)
        {
            transform.position += transform.TransformDirection(Vector3.forward * TankMoveSpeed * z);
        }
        float x = Input.GetAxis("Horizontal");    // клавиши A и D
        if (x != 0)
        {
            // поворачиваем на угол x вокруг оси Y
            transform.Rotate(0f, x, 0f);
        }
        float h = Input.GetAxis("Mouse X");
        if (h != 0)
        {
            bashnya.Rotate(0f, h * RotateSpeed, 0f);
        }

        float v = Input.GetAxis("Mouse Y");
        if (v != 0)
        {
            float stvol_angle =
         Mathf.Clamp(stvol.transform.localEulerAngles.z, min, max);

            stvol.localEulerAngles = new Vector3(0f, 0f, stvol_angle);

            stvol.transform.Rotate(0f, 0f, v * RotateSpeed);
        }
    }
}
