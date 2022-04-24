using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UndoRedo : MonoBehaviour
{
    public static GameObject[] ur_gobj = new GameObject[10];
    public static int curr_pointer;
    public static int curr_static_pointer;
    public static GameObject[] redo_gobj = new GameObject[10];
    public static int curr_pointer_redo;
    public static int curr_static_pointer_redo;
    // Start is called before the first frame update
    void Start()
    {
        curr_pointer = 0;
        curr_static_pointer = 0;
        curr_pointer_redo = 0;
        curr_static_pointer_redo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
