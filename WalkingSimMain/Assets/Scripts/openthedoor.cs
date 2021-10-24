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
    public GameObject openDoorEnding;
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
            anime.SetActive(true);
            animetext.SetActive(true);

            player.GetComponent<CharacterController>().enabled = false;
            openDoorEnding.SetActive(true);

        }

    }


    

}
