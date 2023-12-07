using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightonoff : MonoBehaviour
{

    private bool playerInZone;

    public GameObject lightorobj;
    public GameObject lightorobj2;
    public GameObject lightorobj3;
    public GameObject lightorobj4;
    public GameObject lightorobj5;
    public GameObject lightorobj6;

    // Start is called before the first frame update
    private void Start()
    {
        playerInZone = false;
    }

    // Update is called once per frame
    private void Update()
    {

        if (playerInZone && Input.GetKeyDown(KeyCode.Mouse0))
        {

            ToggleLight(); // Créez une fonction séparée pour rendre le code plus lisible.

            //lightorobj.SetActive(!lightorobj.activeSelf);
            //gameObject.GetComponent<AudioSource>().Play();
            // gameObject.GetComponent<Animator>().Play("switch");


            //gameObject.GetComponent<Animator>().SetTrigger("Clicked");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.gameObject.tag == "Player")
        {
            playerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
      if(other.gameObject.tag == "Player")
        {
            playerInZone = false;

        }
    }
    private void ToggleLight()
    {
        // Vérifiez si l'objet lumineux n'est pas null avant de tenter de l'activer/désactiver.
        if (lightorobj != null)
        {
            lightorobj.SetActive(!lightorobj.activeSelf);
            // Assurez-vous que le composant AudioSource et le composant Animator existent avant de les utiliser.
            if (gameObject.TryGetComponent<AudioSource>(out AudioSource audioSource))
            {
                audioSource.Play();
            }

            if (gameObject.TryGetComponent<Animator>(out Animator animator))
            {
                animator.Play("switch");
            }
        }
        else
        {
            Debug.LogError("Light GameObject is null. Assign a valid GameObject to 'lightorobj'.");
        }


        // Vérifiez si l'objet lumineux n'est pas null avant de tenter de l'activer/désactiver.
        if (lightorobj2 != null)
        {
            lightorobj2.SetActive(!lightorobj2.activeSelf);
            // Assurez-vous que le composant AudioSource et le composant Animator existent avant de les utiliser.
            if (gameObject.TryGetComponent<AudioSource>(out AudioSource audioSource))
            {
                audioSource.Play();
            }

            if (gameObject.TryGetComponent<Animator>(out Animator animator))
            {
                animator.Play("switch");
            }
        }
        else
        {
            Debug.LogError("Light GameObject is null. Assign a valid GameObject to 'lightorobj2'.");
        }
        // Vérifiez si l'objet lumineux n'est pas null avant de tenter de l'activer/désactiver.
        if (lightorobj3 != null)
        {
            lightorobj3.SetActive(!lightorobj3.activeSelf);
            // Assurez-vous que le composant AudioSource et le composant Animator existent avant de les utiliser.
            if (gameObject.TryGetComponent<AudioSource>(out AudioSource audioSource))
            {
                audioSource.Play();
            }

            if (gameObject.TryGetComponent<Animator>(out Animator animator))
            {
                animator.Play("switch");
            }
        }
        else
        {
            Debug.LogError("Light GameObject is null. Assign a valid GameObject to 'lightorobj3'.");
        }

        // Vérifiez si l'objet lumineux n'est pas null avant de tenter de l'activer/désactiver.
        if (lightorobj4 != null)
        {
            lightorobj4.SetActive(!lightorobj4.activeSelf);
            // Assurez-vous que le composant AudioSource et le composant Animator existent avant de les utiliser.
            if (gameObject.TryGetComponent<AudioSource>(out AudioSource audioSource))
            {
                audioSource.Play();
            }

            if (gameObject.TryGetComponent<Animator>(out Animator animator))
            {
                animator.Play("switch");
            }
        }
        else
        {
            Debug.LogError("Light GameObject is null. Assign a valid GameObject to 'lightorobj4'.");
        }

        // Vérifiez si l'objet lumineux n'est pas null avant de tenter de l'activer/désactiver.
        if (lightorobj5 != null)
        {
            lightorobj5.SetActive(!lightorobj5.activeSelf);
            // Assurez-vous que le composant AudioSource et le composant Animator existent avant de les utiliser.
            if (gameObject.TryGetComponent<AudioSource>(out AudioSource audioSource))
            {
                audioSource.Play();
            }

            if (gameObject.TryGetComponent<Animator>(out Animator animator))
            {
                animator.Play("switch");
            }
        }
        else
        {
            Debug.LogError("Light GameObject is null. Assign a valid GameObject to 'lightorobj5'.");
        }

        // Vérifiez si l'objet lumineux n'est pas null avant de tenter de l'activer/désactiver.
        if (lightorobj6 != null)
        {
            lightorobj6.SetActive(!lightorobj6.activeSelf);
            // Assurez-vous que le composant AudioSource et le composant Animator existent avant de les utiliser.
            if (gameObject.TryGetComponent<AudioSource>(out AudioSource audioSource))
            {
                audioSource.Play();
            }

            if (gameObject.TryGetComponent<Animator>(out Animator animator))
            {
                animator.Play("switch");
            }
        }
        else
        {
            Debug.LogError("Light GameObject is null. Assign a valid GameObject to 'lightorobj6'.");
        }
    }
}


