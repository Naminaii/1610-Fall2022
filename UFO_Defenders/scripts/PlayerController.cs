using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float horizontalImput;
    public float speed = 25;
    public float xRange = 30;

    public Transform blaster;
    public GameObject lazerBolt;
    public AudioSource playerAudio;
    
    void Start()
    {
        playerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        horizontalImput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalImput * Time.deltaTime);

        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(lazerBolt, transform.position, lazerBolt.transform.rotation);
            playerAudio.PlayOneShot(pewPew, 1.0f);
        }
    }
    //destroys any object that collides with the player.
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
