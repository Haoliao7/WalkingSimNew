using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button5 : MonoBehaviour
{
    public GameObject entrance;
    public GameObject doorend;
    public GameObject invisiblewall;
    public GameObject NPC;
    public GameObject thisButton;

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
                    NPC.SetActive(true);
                    Destroy(thisButton);
                }
                entrance.SetActive(true);
                doorend.SetActive(true);
                invisiblewall.SetActive(false);
            }

        }

    }


}
