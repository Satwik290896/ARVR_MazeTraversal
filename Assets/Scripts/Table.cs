using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Table : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obj;

    [SerializeField]
    ARRaycastManager m_RaycastManager;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    void Start()
    {
        
        var rayCastPoint = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.1f, 0));
        var rayCastPoint1 = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        var rayCastPoint2 = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.9f, 0));
        var rayCastPoint3 = Camera.main.ViewportPointToRay(new Vector3(0.1f, 0.5f, 0));
        var rayCastPoint4 = Camera.main.ViewportPointToRay(new Vector3(0.9f, 0.5f, 0));
        var rayCastPoint5 = Camera.main.ViewportPointToRay(new Vector3(0.1f, 0.1f, 0));
        var rayCastPoint6 = Camera.main.ViewportPointToRay(new Vector3(0.9f, 0.9f, 0));
        var rayCastPoint7 = Camera.main.ViewportPointToRay(new Vector3(0.1f, 0.9f, 0));
        var rayCastPoint8 = Camera.main.ViewportPointToRay(new Vector3(0.9f, 0.1f, 0));

        RaycastHit hit;

        bool h = Physics.Raycast(rayCastPoint, out hit);
        GameObject obj0 = hit.transform.gameObject;
        bool h1 = Physics.Raycast(rayCastPoint, out hit);
        GameObject obj1 = hit.transform.gameObject;
        bool h2 = Physics.Raycast(rayCastPoint, out hit);
        GameObject obj2 = hit.transform.gameObject;
        bool h3 = Physics.Raycast(rayCastPoint, out hit);
        GameObject obj3 = hit.transform.gameObject;
        bool h4 = Physics.Raycast(rayCastPoint, out hit);
        GameObject obj4 = hit.transform.gameObject;
        bool h5 = Physics.Raycast(rayCastPoint, out hit);
        GameObject obj5 = hit.transform.gameObject;
        bool h6 = Physics.Raycast(rayCastPoint, out hit);
        GameObject obj6 = hit.transform.gameObject;
        bool h7 = Physics.Raycast(rayCastPoint, out hit);
        GameObject obj7 = hit.transform.gameObject;
        bool h8 = Physics.Raycast(rayCastPoint, out hit);
        GameObject obj8 = hit.transform.gameObject;

        if ( h || h1 || h2 || h3 || h4 || h5 || h6 || h7 || h8)
        {

            if (obj0 == null && obj1==null && obj2 == null && obj3 == null
                && obj4 == null && obj5 == null && obj6 == null && obj7 == null
                && obj8 == null)
            {
                //Debug.DrawRay(rayCastPoint.origin, rayCastPoint.direction * 10, Color.yellow);
                if (m_RaycastManager.Raycast(rayCastPoint1, hits))
                {
                    var hitPose = hits[0].pose;
                    obj.transform.position = hitPose.position;

                }
            }
        }
        else {
            if (m_RaycastManager.Raycast(rayCastPoint1, hits))
            {
                var hitPose = hits[0].pose;
                obj.transform.position = hitPose.position;

            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        var rayCastPoint = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        //Debug.DrawRay(rayCastPoint.origin, rayCastPoint.direction * 10, Color.yellow);
        if (m_RaycastManager.Raycast(rayCastPoint, hits))
        {
            var hitPose = hits[0].pose;
            obj.transform.position = hitPose.position;

        }
    }
}
