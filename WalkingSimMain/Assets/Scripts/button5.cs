using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button5 : MonoBehaviour
{
    public GameObject entrance;
    public GameObject doorend;
    public GameObject invisiblewall;
    public GameObject NPC;
    public GameObject someoneElse;
    public GameObject thisButton;
    public GameObject anime;
    public GameObject animetext;
    public GameObject player;
    public GameObject gamecamera;
    public GameObject lockCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    void OnTriggerStay(Collider other)
    {
        

        if (other.gameObject.tag == "Player")
        {

            if (Input.GetMouseButtonDown(0))
            {
                if (!doorend.activeSelf) {
                    player.GetComponent<MouseLook>().enabled = false;
                    gamecamera.GetComponent<MouseLook>().enabled = false;
                    NPC.SetActive(true);
                    anime.SetActive(true);
                    animetext.SetActive(true);
                    someoneElse.SetActive(true);
                    lockCamera.SetActive(true);
                    Destroy(thisButton);
                }
                entrance.SetActive(true);
                doorend.SetActive(true);
                invisiblewall.SetActive(false);
            }

        }

    }


}
