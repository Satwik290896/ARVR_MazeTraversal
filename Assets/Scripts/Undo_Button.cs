using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Undo_Button : MonoBehaviour
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

    public void onclick_undo()
    {
        if (UndoRedo.curr_static_pointer > 0)
        {
            var pos = MazeObj.transform.position;
            var rot = MazeObj.transform.rotation;
            Destroy(MazeObj);
            UndoRedo.curr_pointer = (UndoRedo.curr_pointer - 1) % 10;
            if (UndoRedo.curr_static_pointer > 0)
                UndoRedo.curr_static_pointer = UndoRedo.curr_static_pointer - 1;

            UndoRedo.redo_gobj[UndoRedo.curr_pointer_redo] = MazeObj;
            if (UndoRedo.curr_static_pointer_redo > 0)
                UndoRedo.curr_static_pointer_redo = UndoRedo.curr_static_pointer_redo + 1;
            UndoRedo.curr_pointer_redo = (UndoRedo.curr_pointer_redo + 1) % 10;

            Instantiate(UndoRedo.ur_gobj[UndoRedo.curr_pointer_redo], pos, rot);
        }
    }
}
