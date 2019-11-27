using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMouvement : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    public GameObject camera; 
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float translationVertical = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float translationHorizontal = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        transform.Translate(translationHorizontal, 0, translationVertical);

        float rotation = Input.GetAxis("Horizontal_R") * rotationSpeed * Time.deltaTime;
        transform.Rotate(0, rotation, 0);
    }
}
