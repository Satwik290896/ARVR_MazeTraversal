using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject MazeObj;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void on_click_left()
    {
        MazeObj.transform.position -= new Vector3(0.1f, 0, 0);
    }
}
