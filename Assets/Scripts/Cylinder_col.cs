using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Cylinder_col : MonoBehaviour
{
    
    // Start is called before the first frame update
    public GameObject Curr_Obj;
    public GameObject obj;
    public GameObject cube_obj;
    public GameObject Cylin_obj;
    
    public GameObject MazeObj;


    void Start()
    {
        Debug.Log("Hello!!");
        obj = GameObject.FindGameObjectWithTag("test");
        cube_obj = GameObject.FindGameObjectWithTag("Cube");
        Cylin_obj = GameObject.FindGameObjectWithTag("Cylinder");
        MazeObj = GameObject.FindGameObjectWithTag("Maze");
        XRGrabInteractable sc = Curr_Obj.AddComponent<XRGrabInteractable>() as XRGrabInteractable;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other) {

        GameObject oth_obj = other.gameObject;

        if (oth_obj.tag == "Cell") {
            GameObject obj2 = Instantiate(Curr_Obj, oth_obj.transform.position, oth_obj.transform.rotation);
            obj2.transform.SetParent(MazeObj.transform);
        }

        if (oth_obj.tag == "Cell22") {
            var pos = oth_obj.transform.position;
            var rot = oth_obj.transform.rotation;
            UndoRedo.ur_gobj[UndoRedo.curr_pointer] = MazeObj;
            UndoRedo.curr_pointer = (UndoRedo.curr_pointer + 1)%10;
            if (UndoRedo.curr_static_pointer < 10)
                UndoRedo.curr_static_pointer = UndoRedo.curr_static_pointer + 1;

            Destroy(oth_obj);
            GameObject obj2 = Instantiate(Curr_Obj, pos, rot);
            obj2.transform.SetParent(MazeObj.transform);
        }

    }
}
