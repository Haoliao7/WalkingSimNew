using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoorEnding : MonoBehaviour
{

    public GameObject endingWhite;
    //public GameObject endingtext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("999999999999999");
            endingWhite.SetActive(true);
            //endingtext.SetActive(true);
        }
    }
}
