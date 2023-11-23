using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightonoff : MonoBehaviour
{

    private bool PlayerInZone;

    public GameObject lightorobj;

    // Start is called before the first frame update
    private void Start()
    {
        PlayerInZone = false;
    }

    // Update is called once per frame
    private void Update()
    {

        if (PlayerInZone && Input.GetKeyDown(KeyCode.Mouse0))
        {
            lightorobj.SetActive(!lightorobj.activeSelf);
            gameObject.GetComponent<AudioSource>().Play();
            gameObject.GetComponent<Animator>().Play("switch");
            //gameObject.GetComponent<Animator>().SetTrigger("Clicked");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player")
        {
            PlayerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
      if(other.gameObject.tag == "Player")
        {
            PlayerInZone = false;

        }
    }


}
