using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HidButton : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
        canvasGroup.alpha = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        /*if( (LeftRayInteractn.it == true) || (RightRayInteractn.it == true) )
        {
            canvasGroup.alpha = 1f;
        }
        else{
            canvasGroup.alpha = 0f;
        }*/
    }
}
