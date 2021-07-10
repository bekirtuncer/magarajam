using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainpoint : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {//;Input.mousePosition

        


        transform.rotation = Quaternion.LookRotation(Vector3.forward, Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition[0], Input.mousePosition[1], 0f)) - transform.position);

    }
}
