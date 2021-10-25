using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openthedoor : MonoBehaviour
{

    public GameObject endingWhite;
    //public GameObject endingtext;
    public GameObject player;
    public GameObject anime;
    public GameObject animetext;
    public GameObject animetext02;
    public GameObject openDoorEnding;
    public GameObject gamecamera;
    public GameObject lockCamera;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.GetComponent<MouseLook>().enabled = false;
            gamecamera.GetComponent<MouseLook>().enabled = false;
            lockCamera.SetActive(true);
            anime.SetActive(true);
            animetext.SetActive(true);
            animetext02.SetActive(true);

            player.GetComponent<CharacterController>().enabled = false;
            openDoorEnding.SetActive(true);

        }

    }


    

}
