using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingsAssistant : MonoBehaviour
{
    public List<GameObject> finishList;
    public int index;
    public GameObject currFinish;
    // Start is called before the first frame update
    void Start()
    {
        index = -1;
        NextFinish();
    }

    // Update is called once per frame
    public void NextFinish()
    {
        if (index + 1 < finishList.Count)
        {
            index++;
            currFinish = finishList[index];
            currFinish.SetActive(true);
        }
    }
}
