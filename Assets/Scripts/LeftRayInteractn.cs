using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class LeftRayInteractn : XRRayInteractor
{
    public XRRayInteractor Leftray;
    public XRBaseInteractable LeftBaseInteract;
    public Object obj;
    public static bool it = false;
    // Start is called before the first frame update
    /*void Start()
    {
        Debug.Log("Hello.....");
        //var Args = obj.BaseInteractionEventArgs.SelectEnterEventArgs;
        //XRInteractorEvent event = Leftray.onSelectEnter;
    }*/

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        IXRInteractable interactable = args.interactableObject;
        IXRSelectInteractor selectInteract = args.interactorObject;

        List<IXRSelectInteractable> interactablesSelected = selectInteract.interactablesSelected;

        Debug.Log(interactablesSelected);

        //GameObject obj = interact.customReticle;

        //obj.GetComponent<MeshRenderer>().material.color = Color.red;
        it = true;

    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {

        IXRInteractable interactable = args.interactableObject;
        IXRSelectInteractor selectInteract = args.interactorObject;

        List<IXRSelectInteractable> interactablesSelected = selectInteract.interactablesSelected;

        Debug.Log(interactablesSelected);

        //obj.GetComponent<MeshRenderer>().material.color = Color.white;
        it = false;
    }

    /*protected override void OnSelectEntering(SelectEnterEventArgs args)
    {
        XRBaseInteractable interact = args.interactable; 
        GameObject obj = interact.customReticle; 

        obj.GetComponent<MeshRenderer>().material.color = Color.red;
        it = true;
    }*/
    
    /*protected override void OnSelectExiting(SelectEnterEventArgs args)
    {
        XRBaseInteractable interact = args.interactable; 
        GameObject obj = interact.customReticle; 

        obj.GetComponent<MeshRenderer>().material.color = Color.white;
        it = 0;
    }*/

    // Update is called once per frame
    void Update()
    {
        /*if (OVRInput.GetDown(OVRInput.Button.PrimaryHandTrigger))
        {
          
          }*/
    }

}
