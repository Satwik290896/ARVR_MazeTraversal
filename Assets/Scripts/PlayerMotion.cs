using System.Collections;
using System.Collections.Generic;
using UnityEngine;using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class PlayerMotion : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    ARRaycastManager m_RaycastManager;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();

    public GameObject obj;
    public GameObject cam;
    public GameObject block_obj;
    public GameObject realplayer;
    public GameObject MazeObj;
    public GameObject MazeObj2;

    private Touch touch;
    private float speedModifier;

    void Start()
    {
        speedModifier = 0.001f;
        realplayer = GameObject.FindGameObjectWithTag("Playeryes");

        //realplayer.transform.GetComponent<Rigidbody>().AddForce(new Vector3(0, -9.81f, 0), ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        //var rayCastPoint = Camera.main.;
        if (TouchScreenInputWrapper.touches.Length > 0)
        {
            Ray rayCastPoint = Camera.main.ScreenPointToRay(TouchScreenInputWrapper.touches[0].position);
            //Debug.DrawRay(rayCastPoint.origin, rayCastPoint.direction * 10, Color.yellow);
            RaycastHit hit;
            //obj.transform.position = rayCastPoint.origin;
            float Force = 0.1f;
            if (TouchScreenInputWrapper.touches[0].phase == TouchPhase.Began)
            {
                if (Physics.Raycast(rayCastPoint, out hit))
                {
                    obj.transform.position = hit.point;
                    //var hitPose = hits[0].pose;
                    if (hit.transform.gameObject.tag == "Playeryes")
                    {
                        Vector3 offSet = hit.transform.position - cam.transform.position;
                        hit.transform.GetComponent<Rigidbody>().AddForce(offSet.normalized * Force, ForceMode.VelocityChange);

                    }
                    /*else if (hit.transform.gameObject.tag == "Maze")
                    {
                        hit.transform.gameObject.transform.GetChild(0).gameObject.transform.position = hit.point;
                    }
                    else if (hit.transform.parent.gameObject.tag == "Maze")
                    {
                        hit.transform.parent.gameObject.transform.GetChild(0).gameObject.transform.position = hit.point;
                    }*/
                    else if (hit.transform.gameObject.tag == "Pos") {
                        MazeObj.transform.localScale = MazeObj.transform.localScale * 1.1f;

                    }
                    else if (hit.transform.gameObject.tag == "Neg")
                    {
                        MazeObj.transform.localScale = MazeObj.transform.localScale * 0.9f;

                    }
                    else if (hit.transform.gameObject.tag == "Slide_Pos")
                    {
                        MazeObj2.transform.position += new Vector3(0.1f,0,0);

                    }
                    else if (hit.transform.gameObject.tag == "Slide_Neg")
                    {
                        MazeObj2.transform.position -= new Vector3(0.1f, 0, 0);

                    }
                    else if (hit.transform.gameObject.tag == "Slide_Up")
                    {
                        MazeObj2.transform.position -= new Vector3(0, 0, 0.1f);

                    }
                    else if (hit.transform.gameObject.tag == "Slide_Down")
                    {
                        MazeObj2.transform.position += new Vector3(0, 0, 0.1f);

                    }
                    else if (hit.transform.gameObject.tag == "Slide_LR")
                    {
                        MazeObj2.transform.eulerAngles += new Vector3(0, 10f,0);

                    }
                    else if (hit.transform.gameObject.tag == "Slide_RR")
                    {
                        MazeObj2.transform.eulerAngles -= new Vector3(0, 10f, 0);

                    }
                    else
                    {

                        Instantiate(block_obj, hit.point, block_obj.transform.rotation);

                    }

                }
            }

           
        }
        /*if (TouchScreenInputWrapper.touches.Length > 0)
        {
            var ray = Camera.main.ScreenPointToRay(TouchScreenInputWrapper.touches[0].position);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = hit.point;

                /*if (hit.transform.GetComponent<Rigidbody>() != null)
                {
                    Vector3 offSet = hit.transform.position - cam.transform.position;
                    hit.transform.GetComponent<Rigidbody>().AddForce(offSet.normalized * Force, ForceMode.VelocityChange);

                }*/
            }



    //Debug.DrawLine(Vector3.zero, ray, Color.red, 5);
    //}

    /*if (TouchScreenInputWrapper.touches.Length > 0)
    {
        Debug.Log("Here111111: ");
    }
    else {
        //Debug.Log(Input.simulateMouseWithTouches);
        Debug.Log("NonReorderableAttribute Touch Input");
    }*/
    /*transform.position += new Vector3(0.01f, 0f, 0.01f) * Time.deltaTime;
    if (TouchScreenInputWrapper.touches.Length > 0) {
        //touch = TouchScreenInputWrapper.touches[0];

        //if (touch.phase == TouchPhase.Moved) {

            //transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedModifier, transform.position.y, transform.position.z * touch.deltaPosition.y * speedModifier);
        //}
    }*/
    //}

}
