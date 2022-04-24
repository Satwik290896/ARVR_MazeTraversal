using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

//public GameObject StructObj;
public class Maze_translate : MonoBehaviour
{

    //[SerializeField]
    //ARRaycastManager m_RaycastManager;
    //List<ARRaycastHit> hits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (TouchScreenInputWrapper.touches.Length > 0)
        {
           
            Ray rayCastPoint = Camera.main.ScreenPointToRay(TouchScreenInputWrapper.touches[0].position);
            //Debug.DrawRay(rayCastPoint.origin, rayCastPoint.direction * 10, Color.yellow);
            RaycastHit hit;
            if (Physics.Raycast(rayCastPoint, out hit))
            {
                //var hitPose = hits[0].pose;
                //obj.transform.position = hitPose.position;
                //for (var i = 0; i <= hits.Count; i++) {
                GameObject obj = hit.transform.gameObject;
                if (obj.tag == "Structure" || obj.tag == "Sphere" || obj.tag == "Cylinder" || obj.tag == "Cube" || obj.tag == "End")
                {
                    //var hitPose = hit.pose;
                    obj.transform.position = hit.point;
                    //Vector3 offSet = hits[0].transform.position - cam.transform.position;
                    //hit.transform.GetComponent<Rigidbody>().AddForce(offSet.normalized * Force, ForceMode.VelocityChange);
                }
                //}


            }
        }*/
    }
}
