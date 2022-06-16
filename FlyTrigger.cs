using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    bool triggerEnabled = true;
    StarterAssets.FirstPersonController f;
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player" && triggerEnabled)
        {
            triggerEnabled = false;
            Debug.Log("Flyyy!!!" + other.gameObject.name);
            f = other.GetComponent<StarterAssets.FirstPersonController>();

            StartCoroutine(PauseGravity());

        }
    }

    IEnumerator PauseGravity()
    {
        float secs = 2f;
        Debug.Log("Start");
        f.Gravity = -.5f;
        yield return new WaitForSeconds(secs);
        Debug.Log("Finish");
        f.Gravity = -15f;
    }
}
