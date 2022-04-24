using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Black : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool m_black;
    void Start()
    {
        m_black = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void on_click_black() {
        m_black = true;
    }
}
