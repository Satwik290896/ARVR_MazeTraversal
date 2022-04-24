using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRot : MonoBehaviour
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

    public void on_click_rightrotate()
    {
        MazeObj.transform.eulerAngles -= new Vector3(0, 20, 0);
    }
}
