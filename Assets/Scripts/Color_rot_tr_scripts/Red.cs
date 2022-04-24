using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Red : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool m_red;
    void Start()
    {
        m_red = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void on_click_red()
    {
        m_red = true;
    }
}
