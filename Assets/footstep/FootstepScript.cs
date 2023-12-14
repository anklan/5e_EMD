using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepScript : MonoBehaviour
{
    public GameObject footstepGround;  // Audio pour les pas sur le sol actuel
    public GameObject footstepOtherMesh;  // Audio pour les pas sur un autre mesh

    private int keyCount = 0;
    private bool isJumping = false;
    private bool isOnGround = true;
    private bool isOnSand = false;

    StarterAssets.FirstPersonController firstPersonController;

    // LayerMask pour détecter le Layer "OtherMesh"
    public LayerMask otherMeshLayer;

    // Start is called before the first frame update
    void Start()
    {
        footstepGround.SetActive(false);
        footstepOtherMesh.SetActive(false);

        firstPersonController = GetComponent<StarterAssets.FirstPersonController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (firstPersonController)
        {
            if(firstPersonController._speed > 0 && firstPersonController.Grounded)
            {
                PlayFootsteps();
            }
            else
            {
                StopFootsteps();
            }
        }
        //print(GetComponent)
        //if (Input.GetKeyDown("w") || Input.GetKeyDown("a") || Input.GetKeyDown("s") || Input.GetKeyDown("d"))
        //{
        //    keyCount++;
        //    PlayFootsteps();
        //}

        //if (Input.GetKeyUp("w") || Input.GetKeyUp("a") || Input.GetKeyUp("s") || Input.GetKeyUp("d"))
        //{
        //    keyCount--;
        //    if (keyCount <= 0 && !isJumping)
        //    {
        //        StopFootsteps();
        //    }
        //}

        if (Input.GetKeyDown("space"))
        {
            isJumping = true;
            StopFootsteps();
        }

        if (isJumping && IsGrounded())
        {
            isJumping = false;
            if (keyCount > 0)
            {
                PlayFootsteps();
            }
        }
    }

    /// <summary>
    /// play foot step
    /// </summary>
    /// <param name="value">blabla</param>
    void PlayFootsteps()
    {
        print("PlayFootsteps");
        if (!isOnSand)
        {
            footstepGround.SetActive(true);
            footstepOtherMesh.SetActive(false);
        }
        else
        {
            footstepGround.SetActive(false);
            footstepOtherMesh.SetActive(true);
        }
    }

    void StopFootsteps()
    {
        footstepGround.SetActive(false);
        footstepOtherMesh.SetActive(false);
        keyCount = 0;
    }

    bool IsGrounded()
    {
        // Utilisez un Raycast pour détecter si le joueur est sur le sol ou sur un autre mesh
        RaycastHit hit;
        if (Physics.Raycast(transform.position, Vector3.down, out hit, 0.1f, otherMeshLayer))
        {
            isOnGround = true;
            return true;
        }
        else
        {
            isOnGround = false;
            return false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        print("OnTriggerEnter");
        if (other.name == "sand")
        {
            isOnSand = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        print("OnTriggerExit");
        if (other.name == "sand")
        {
            isOnSand = false;
        }
    }
}
