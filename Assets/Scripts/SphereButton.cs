using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereButton : MonoBehaviour
{
    public GameObject Sphere_Obj;
    public GameObject Left_Obj;
    public GameObject Right_Obj;
    // Start is called before the first frame update
    void Start()
    {
        //Sphere_Obj = GameObject.FindGameObjectWithTag("Sphere");
        //Left_Obj = GameObject.FindGameObjectWithTag("Left");
        //Right_Obj = GameObject.FindGameObjectWithTag("Right");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        var pos_l = Left_Obj.transform.position;
        var rot_l = Left_Obj.transform.rotation;
        var pos_r = Right_Obj.transform.position;
        var rot_r = Right_Obj.transform.rotation;

        GameObject obj2 = Instantiate(Sphere_Obj, pos_l, rot_l);

        GameObject obj3 = Instantiate(Sphere_Obj, pos_r, rot_r);
    }

}
