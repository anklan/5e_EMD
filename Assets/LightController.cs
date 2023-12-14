using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public GameObject[] mesObjects;

    private void Start()
    {
        for(int index = 0; index < mesObjects.Length; index++)
        {
            print(index);
            mesObjects[index].SetActive(true);
        }
    }
}
