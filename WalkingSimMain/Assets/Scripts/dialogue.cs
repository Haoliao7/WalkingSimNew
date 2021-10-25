using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogue : MonoBehaviour
{

    public GameObject anime;
    public GameObject animetext;
    public GameObject animetext02;
    public GameObject animetext03;
    public GameObject animetext04;
    public GameObject player;
    public GameObject gamecamera;
    public GameObject lockCamera;
    // Start is called before the first frame update
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
            anime.SetActive(true);
            animetext.SetActive(true);
            animetext02.SetActive(true);
            animetext03.SetActive(true);
            animetext04.SetActive(true);
            lockCamera.SetActive(true);
            GameObject.Destroy(gameObject);
        }

    }

}
