using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waitForTimetoMoveCamera : MonoBehaviour
{

    public GameObject player;
    public GameObject gamecamera;
    public int waitSeconds;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Wait());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Wait() {
        yield return new WaitForSeconds(waitSeconds);
        player.GetComponent<MouseLook>().enabled = true;
        gamecamera.GetComponent<MouseLook>().enabled = true;

    }

}
