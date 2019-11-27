using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weather : MonoBehaviour
{
    public GameObject Player;
    public GameObject Clouds;
    public GameObject Sun;
    private Light SunLight;

    public float RotationSunSpeed = 1f;
    public float CloudsSpeed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        SunLight = Sun.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Clouds.transform.position.z < -1000)
        {
            Clouds.transform.position = new Vector3(Clouds.transform.position.x, Clouds.transform.position.y, 1000);
        }
        Clouds.transform.position = new Vector3(Clouds.transform.position.x, Clouds.transform.position.y, Clouds.transform.position.z - CloudsSpeed * Time.deltaTime);

        SunLight.transform.Rotate(Vector3.right * RotationSunSpeed * Time.deltaTime);

        if(Player.transform.position.y < -20)
        {
            Player.transform.position = new Vector3(482.9173f, 1.427047f, 207.8161f);
        }
    }
}
