using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Redo_Button : MonoBehaviour
{
    public GameObject MazeObj;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onclick_redo()
    {
        if (UndoRedo.curr_static_pointer_redo > 0)
        {
            var pos = MazeObj.transform.position;
            var rot = MazeObj.transform.rotation;
            Destroy(MazeObj);
            UndoRedo.curr_pointer_redo = (UndoRedo.curr_pointer_redo - 1) % 10;
            if (UndoRedo.curr_static_pointer_redo > 0)
                UndoRedo.curr_static_pointer_redo = UndoRedo.curr_static_pointer_redo - 1;

            UndoRedo.ur_gobj[UndoRedo.curr_pointer] = MazeObj;
            if (UndoRedo.curr_static_pointer < 10)
                UndoRedo.curr_static_pointer = UndoRedo.curr_static_pointer + 1;
            UndoRedo.curr_pointer = (UndoRedo.curr_pointer + 1) % 10;

            Instantiate(UndoRedo.ur_gobj[UndoRedo.curr_pointer_redo], pos, rot);
        }
    }
}
