using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levitation : MonoBehaviour
{
    public float amplitude = 1f; // Valeur par défaut de l'amplitude
    public float speed = 1f; // Valeur par défaut de la vitesse

    private float startPosY;

    // Start is called before the first frame update
    void Start()
    {
        startPosY = transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position;
        newPos.y = startPosY + amplitude * Mathf.Sin(speed * Time.time);
        transform.position = newPos;
    }
}
