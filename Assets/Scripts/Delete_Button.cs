using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delete_Button : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool m_is_delete = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onclick_delete() {
            m_is_delete = true;
    }
}
