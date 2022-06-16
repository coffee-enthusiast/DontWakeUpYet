using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWall : MonoBehaviour
{
    public GameObject wallToEnding2;
    public GameObject extraObjectToHide;
    public bool active;
    // Start is called before the first frame update

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            wallToEnding2.SetActive(active);
            if(extraObjectToHide)
            extraObjectToHide.SetActive(false);

        }
    }
}
