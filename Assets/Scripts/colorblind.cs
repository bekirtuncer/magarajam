using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorblind : MonoBehaviour
{

    public GameObject sibiling;


    // Start is called before the first frame update
    private void Start()
    {


        
    }

    // Update is called once per frame
    private void Update()
    {

        if(Input.GetKeyDown(KeyCode.K))
        {
            colorblind_on();

        }
        else if(Input.GetKeyDown(KeyCode.L))
        {
            colorblind_off();

        }


        
    }


    //colorblind modunu aktif eder
    public void colorblind_on()
    {
        sibiling.GetComponent<SpriteRenderer>().color = new Color(255,255,255);
        


    }



    //colorblind modunu kapatir
    public void colorblind_off()
    {
        if(gameObject.tag=="Enemy")
            { 
        
                sibiling.GetComponent<SpriteRenderer>().color = new Color(255, 0, 0);
                
            }
        else if (gameObject.tag == "Innocent")
        {
            sibiling.GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
        }


    }




}
