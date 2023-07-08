using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointScript : MonoBehaviour
{
    public GameObject Box;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GameObject boxClone = Instantiate(Box) as GameObject;

            boxClone.transform.position = transform.position;
        }
    }
}
