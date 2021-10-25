using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadnextScene : MonoBehaviour
{


void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }

        }

    }


}
