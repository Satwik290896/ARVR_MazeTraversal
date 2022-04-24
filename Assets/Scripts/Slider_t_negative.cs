using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_t_negative : MonoBehaviour
{
    //public Slider slider;
    public Image slide_image;
    public GameObject obj;
    public float val;
    // Start is called before the first frame update
    void Start()
    {
        val = 0.9f;
    }

    // Update is called once per frame


    private bool IsInRect(RectTransform rect, Vector2 screenPoint)
    {
        return RectTransformUtility.RectangleContainsScreenPoint(rect, screenPoint);
    }

    void Update()
    {
        //float value = slider.value;
        foreach (Touch _touch in TouchScreenInputWrapper.touches)
        {
            if (_touch.phase == TouchPhase.Began)
            {
                if (IsInRect(slide_image.rectTransform, _touch.position))
                {
                    //Jump button pressed

                    GetComponent<Image>().color = Color.yellow;

                    obj.transform.localScale = obj.transform.localScale * val;

                }
            }

            else if (_touch.phase == TouchPhase.Stationary)
            {
                if (IsInRect(slide_image.rectTransform, _touch.position))
                {
                    //Jump button pressed
                    GetComponent<Image>().color = Color.yellow;
                    obj.transform.localScale = obj.transform.localScale * val;

                }
            }
        }



    }

    public void OnSliderButton()
    {

    }
}
