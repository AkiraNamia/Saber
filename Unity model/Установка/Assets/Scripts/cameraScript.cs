using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class cameraScript : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    float scrollSpeed = 10f;

    [SerializeField]
    public Transform targetPos;
    int sensivity = 3;
    Quaternion startRotation;
    Quaternion needRotaton;

    //int maxDistance = 30;
    //int minDistance = -30;
    //int minHeight = 0;
    //int maxHeight = 20;
    //Vector3 leftDist = new Vector3(-30, 10, 0);


    ////  ÔÓÍÊÖÈß ÎÃÐÀÍÈ×ÅÍÈß ÏÐÅÄÅËÎÂ ÄÂÈÆÅÍÈß ÊÀÌÅÐÛ 
    //bool ControlDistance(float distance)
    //{
    //    if (distance > minDistance && distance < maxDistance)
    //    {
    //        return true;
    //    }
    //    return false;
    //}

    //bool ControlHeight(float height)
    //{
    //    if (height > minHeight && height < maxHeight)
    //    {
    //        return true;
    //    }
    //    return false;
    //}
    //private void OnCollisionEnter(Collision col)
    //{
    //    if (col.gameObject.tag == "wall") 
    //    {
    //        transform.position = leftDist;

    //    }
    //}

    // ÂÐÀÙÅÍÈÅ ÂÎÊÐÓÃ ÖÅÍÒÐÀËÜÍÎÉ ÒÎ×ÊÈ ÓÑÒÀÍÎÂÊÈ Ñ ÇÀÆÀÒÎÉ ÏÐÀÂÎÉ ÊËÀÂÈØÅÉ ÌÛØÈ 
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.RotateAround(targetPos.position, Vector3.up, Input.GetAxis("Mouse X") * sensivity);
        }
        // ÄÂÈÆÅÍÈß ÊÀÌÅÐÛ Â ÑÒÎÐÎÍÛ ÊËÀÂÈØÀÌÈ 

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        if ((x != 0 || y != 0))
        {
            transform.position = new Vector3( Mathf.Clamp(transform.position.x, -20, 25), Mathf.Clamp(transform.position.y, 2, 18), Mathf.Clamp(transform.localPosition.z, -24, 22));
            transform.position += (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / sensivity;
            //Vector3 newPos = (transform.TransformDirection(new Vector3(x, 0, 0)) + Vector3.up * y) / sensivity;
            //if (ControlDistance(Vector3.Distance(newPos, targetPos.position)))
            //{
            //    transform.position = newPos;
            //    //transform.LookAt(targetPos);
            //}
        }

        // ÏÐÈÁËÈÆÅÍÈÅ È ÓÄÀËÅÍÈÅ ÊÀÌÅÐÛ ÎÒ ÓÑÒÀÍÎÂÊÈ ÏÐÎÊÐÓÒÊÎÉ ÊÎËÅÑÀ ÌÛØÈ 
        if (Input.GetAxis("Mouse ScrollWheel") != 0)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.localPosition.z, -24, 22));
            transform.position += transform.TransformDirection(Vector3.forward * Input.GetAxis("Mouse ScrollWheel") * scrollSpeed);

        }
      

    }
    public void OnPointerClick(PointerEventData eventData)
    {
        float red = Random.Range(.0f, 1.0f);
        float green = Random.Range(.0f, 1.0f);
        float blue = Random.Range(.0f, 1.0f);
        Color coll = new Color(red, green, blue);
        gameObject.GetComponent<Renderer>().material.color = coll;
    }
    private Camera cam1;
    // Start is called before the first frame update
    void Start()
    {
        cam1 = GetComponent<Camera>();
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

	// Update is called once per frame
	bool move = false;
	Vector3 startPosition;
	Vector3 needPosition;
	float speed = 0.01f;
	float offset = 0;
	
	public void MoveCPU()
	{
		if (!move)
		{
			move = true;
			startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-0.7082976f, 4.678321f, -11.9729f);
            needRotaton = Quaternion.Euler(11.005f, -21.938f, 0f);

        }

    }

	public void MoveWood()
	{
		if (!move)
		{
            move = true;
			startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-6.115545f, 9.504325f, -11.84044f);
            needRotaton = Quaternion.Euler(19.32f, -65.268f, 0.039f);

        }

    }
    public void MoveDerzh()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(3.393205f, 7.074697f, -13.84659f);
            needRotaton = Quaternion.Euler(17.532f, -10.829f, 0f);
        }

    }
    public void MoveKorpus()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(14.4669f, 7.346045f, -5.239557f);
            needRotaton = Quaternion.Euler(17.017f, -39.534f, 0f);
        }

    }
    public void MoveOsn()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(1.105244f, 6.229789f, -10.520632f);
            needRotaton = Quaternion.Euler(22.345f, 1.204f, 0f);
        }

    }
    public void MoveMainCamera()
	{
		
		if (!move)
		{
			move = true;
			startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(7.08f, 9.87f, -20.52f);
            needRotaton = Quaternion.Euler(11.005f, -21.938f, 0f);


        }


    }
    public void MoveToScreenCPU()
    {
        if (!move)
        {
            move = true;
            startPosition = transform.position;
            startRotation = transform.rotation;
            needPosition = new Vector3(-2.80785f, 3.576043f, -10.88145f);
            needRotaton = Quaternion.Euler(4.057f, -35.787f, 0f);

        }

    }

    void FixedUpdate()
	{

		if (move)
		{
			offset += speed;
			transform.position = Vector3.Lerp(startPosition, needPosition, offset);
            transform.rotation = Quaternion.Slerp(startRotation, needRotaton, offset);


            if (offset >= 1)
			{
				move = false;
				offset = 0;

			}

		}
	}
}