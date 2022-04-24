using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class col_Final : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Playeryes") {
            //Restarting
            //SceneManager.LoadScene(0);
            SceneManager.LoadScene("AR_Mobile", LoadSceneMode.Single);
        }
    }
}
