using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room : MonoBehaviour
{
    public GameObject wall;
    public Material wallMat;
    // Start is called before the first frame update
    void Start()
    {
        wall.GetComponent<MeshRenderer>().material = wallMat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
