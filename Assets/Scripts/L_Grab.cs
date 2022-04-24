using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class L_Grab : MonoBehaviour
{
    // Start is called before the first frame update
    //public GameObject obj;
    void Start()
    {
        //XRDirectInteractor interactor = obj.GetComponent<XRDirectInteractor>();
        //isSelectActive
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (Delete_Button.m_is_delete) {
            Destroy(other.gameObject);
            Delete_Button.m_is_delete = false;
        }

        if (Red.m_red == true)
        {
            var renderer_t = other.gameObject.GetComponent<Renderer>();

            Red.m_red = false;
            renderer_t.material.SetColor("_Color", Color.red);
        }

        if (Black.m_black == true)
        {
            var renderer_t = other.gameObject.GetComponent<Renderer>();

            Black.m_black = false;
            renderer_t.material.SetColor("_Color", Color.black);
        }

        if (Yellow.m_yellow == true)
        {
            var renderer_t = other.gameObject.GetComponent<Renderer>();

            Yellow.m_yellow = false;
            renderer_t.material.SetColor("_Color", Color.yellow);
        }

    }

    void OnTriggerStay(Collider other)
    {
        if (Delete_Button.m_is_delete)
        {
            Destroy(other.gameObject);
            Delete_Button.m_is_delete = false;
        }

        
        if (Red.m_red == true)
        {
            var renderer_t = other.gameObject.GetComponent<Renderer>();
            
            Red.m_red = false;
            renderer_t.material.SetColor("_Color", Color.red);
        }

        if (Black.m_black == true)
        {
            var renderer_t = other.gameObject.GetComponent<Renderer>();

            Black.m_black = false;
            renderer_t.material.SetColor("_Color", Color.black);
        }

        if (Yellow.m_yellow == true)
        {
            var renderer_t = other.gameObject.GetComponent<Renderer>();

            Yellow.m_yellow = false;
            renderer_t.material.SetColor("_Color", Color.yellow);
        }

    }

}
