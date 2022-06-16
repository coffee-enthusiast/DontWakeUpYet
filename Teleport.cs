using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class Teleport : MonoBehaviour
{

    public Transform teleportPosition;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Teleport Pos: " + teleportPosition.position);
        Debug.Log("My Pos: " + transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {

            Debug.Log("Teleport!" +other.gameObject.name + " pos: " + other.gameObject.transform.position);
            CharacterController c = other.gameObject.GetComponent<CharacterController>();
            StarterAssets.FirstPersonController f = other.gameObject.GetComponent<StarterAssets.FirstPersonController>();
            c.enabled = false;
            f.enabled = false;
            other.gameObject.transform.position = teleportPosition.position + new Vector3(1,0,0);
            c.enabled = true;
            f.enabled = true;
            Debug.Log("Teleport after! Player pos: " + other.gameObject.transform.position);
        }
    }
}
