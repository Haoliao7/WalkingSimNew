using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorend : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject someoneElse;
    void Start()
    {
        
    }

    // Update is called once per frame
   void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "vision" && !someoneElse.activeSelf)
        {
            gameObject.SetActive(false);

        }
    }
}
