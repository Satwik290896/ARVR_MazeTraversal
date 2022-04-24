using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yellow : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool m_yellow;
    void Start()
    {
        m_yellow = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void on_click_yellow()
    {
        m_yellow = true;
    }
}
