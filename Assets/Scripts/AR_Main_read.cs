using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime;

public class AR_Main_read : MonoBehaviour
{
    // Start is called before the first frame update
    /*public Vector3 pos_start = new Vector3(0.99f, 1.5f, -2.49f);
    public Vector3 pos_end = new Vector3(0f, 1.5f, -1.5f);
    public Vector3[] spheres = new Vector3[10];
    public Vector3[] Cylinders = new Vector3[10];
    public Vector3[] Cubes = new Vector3[4];*/

    public GameObject[] spheres;
    public GameObject[] cubes;
    public GameObject[] cylinders;
    public GameObject Start;
    public GameObject End;
    public GameObject cube_obj;
    public GameObject Cylin_obj;
    public GameObject sphere_obj;
    public GameObject MazeObj;
    public GameObject StartObj;
    public GameObject EndObj;
    public GameObject player_obj;
    public GameObject StructObj;

    void Awake()
    {
        //Vector3 side = new Vector3(0f, 0f, 0.3f);
        //Instantiate(EndObj, StartObj.transform.position + side, StartObj.transform.rotation);
        //Instantiate(EndObj, pos_end, EndObj.transform.rotation);

        GameObject obj1,obj_s,obj_e;
        var pos = Start.transform.position;
        Destroy(Start);
        obj_s =Instantiate(player_obj, pos, player_obj.transform.rotation);
        obj_s.transform.SetParent(StructObj.transform);
        obj_s.transform.gameObject.tag = "Playeryes";

        pos = End.transform.position;
        Destroy(End);
        obj_e = Instantiate(EndObj, pos, EndObj.transform.rotation);
        obj_e.transform.SetParent(MazeObj.transform);

        /*spheres[0] = new Vector3(0.44f, 1.61f, -2.49f);
        spheres[1] = new Vector3(0.22f, 1.2f, -2.49f);
        spheres[2] = new Vector3(0f, 1.5f, -2.49f);
        spheres[3] = new Vector3(0f, 1.61f, -2.49f);
        spheres[4] = new Vector3(0f, 1.72f, -2.49f);
        spheres[5] = new Vector3(0.11f, 1.61f, -2.49f);
        spheres[6] = new Vector3(0.33f, 1.5f, -2.05f);
        spheres[7] = new Vector3(0.44f, 1.5f, -1.94f);
        spheres[8] = new Vector3(0.33f, 1.5f, -2.27f);
        spheres[9] = new Vector3(0.11f, 1.5f, -1.61f);

        Cylinders[0] = new Vector3(0f, 1.5f, -2.05f);
        Cylinders[1] = new Vector3(0f, 1.5f, -2.16f);
        Cylinders[2] = new Vector3(0f, 1.61f, -1.72f);
        Cylinders[3] = new Vector3(0.99f, 1.5f, -1.5f);
        Cylinders[4] = new Vector3(0.77f, 1.5f, -1.94f);
        Cylinders[5] = new Vector3(0.11f, 1.5f, -2.05f);
        Cylinders[6] = new Vector3(0.77f, 1.5f, -2.27f);
        Cylinders[7] = new Vector3(0.22f, 1.72f, -2.05f);
        Cylinders[8] = new Vector3(0.66f, 1.72f, -1.72f);
        Cylinders[9] = new Vector3(0.22f, 1.72f, -2.27f);

        Cubes[0] = new Vector3(0.11f, 1.72f, -1.72f);
        Cubes[1] = new Vector3(0f, 1.72f, -2.16f);
        Cubes[2] = new Vector3(0.88f, 1.72f, -2.05f);
        Cubes[3] = new Vector3(0.66f, 1.72f, -1.61f);*/
        /*Cubes[4] = new Vector3(0.99f, 1.5f, -2.49f);
        Cubes[5] = new Vector3(0.99f, 1.5f, -2.49f);
        Cubes[6] = new Vector3(0.99f, 1.5f, -2.49f);
        Cubes[7] = new Vector3(0.99f, 1.5f, -2.49f);
        Cubes[8] = new Vector3(0.99f, 1.5f, -2.49f);
        Cubes[9] = new Vector3(0.99f, 1.5f, -2.49f);*/


        //cube_obj = GameObject.FindGameObjectWithTag("Cube");
        //Cylin_obj = GameObject.FindGameObjectWithTag("Cylinder");
        //sphere_obj = GameObject.FindGameObjectWithTag("Sphere");
        //MazeObj = GameObject.FindGameObjectWithTag("Maze");


        for (var i = 0; i < cubes.Length; i++) {
            //Instantiate(cube_obj, (Cubes[i] - ARSessionO.transform.position), cube_obj.transform.rotation);
            //obj1.transform.SetParent(MazeObj.transform);
            pos = cubes[i].transform.position;
            Destroy(cubes[i]);
            obj1 = Instantiate(cube_obj, pos, cube_obj.transform.rotation);
            obj1.transform.SetParent(MazeObj.transform);

        }

        for (var i = 0; i < cylinders.Length; i++)
        {
            //Instantiate(cube_obj, (Cubes[i] - ARSessionO.transform.position), cube_obj.transform.rotation);
            //obj1.transform.SetParent(MazeObj.transform);
            pos = cylinders[i].transform.position;
            Destroy(cylinders[i]);
            obj1 = Instantiate(Cylin_obj, pos, Cylin_obj.transform.rotation);
            obj1.transform.SetParent(MazeObj.transform);
        }

        for (var i = 0; i < spheres.Length; i++)
        {
            //Instantiate(cube_obj, (Cubes[i] - ARSessionO.transform.position), cube_obj.transform.rotation);
            //obj1.transform.SetParent(MazeObj.transform);
            pos = spheres[i].transform.position;
            Destroy(spheres[i]);
            obj1 = Instantiate(sphere_obj, pos, sphere_obj.transform.rotation);
            obj1.transform.SetParent(MazeObj.transform);
        }

        /*for (var i = 0; i < 10; i++)
        {
            Instantiate(Cylin_obj, (Cylinders[i] - ARSessionO.transform.position), Cylin_obj.transform.rotation);
            //obj2.transform.SetParent(MazeObj.transform);
            Instantiate(sphere_obj, (spheres[i] - ARSessionO.transform.position), sphere_obj.transform.rotation);
            //obj3.transform.SetParent(MazeObj.transform);

        }*/

        Transform[] g_objs = MazeObj.GetComponentsInChildren<Transform>();

        for (int i = 0; i < g_objs.Length; i++) {
            if (g_objs[i].gameObject.tag == "Cell22")
            {
                Destroy(g_objs[i].gameObject);
            }

            if (g_objs[i].gameObject.tag == "Start") {
                pos = g_objs[i].position;
                var rot = g_objs[i].rotation;
                Destroy(g_objs[i].gameObject);

                obj1 = Instantiate(player_obj, pos, rot);
                obj1.transform.SetParent(StructObj.transform);
                
            }

        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
