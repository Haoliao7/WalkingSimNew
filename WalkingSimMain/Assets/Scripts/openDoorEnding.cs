using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoorEnding : MonoBehaviour
{

    public GameObject endingWhite;
    public GameObject player;
    public GameObject gamecamera;
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
            player.GetComponent<MouseLook>().enabled = false;
            gamecamera.GetComponent<MouseLook>().enabled = false;
            endingWhite.SetActive(true);
            //endingtext.SetActive(true);
        }
    }
}
