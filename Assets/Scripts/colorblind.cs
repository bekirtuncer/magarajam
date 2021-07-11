using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorblind : MonoBehaviour
{

    public GameObject sibiling;

    public Sprite spritemain;
    public Sprite spriteBlind;

    public Sprite spriteAgainst;

    // Start is called before the first frame update
    private void Start()
    {

        sibiling =GetComponentInChildren<SpriteRenderer>().gameObject;


        colorblind_off();

        Invoke("colorblind_on", 2.0f);
        // 2 . parametrede girdigimiz degersure kadar sonra 1. parameterede girdigim metodu calistiracak
        //1. parametredeki tirnak arasina yaziliyor evet

    }

    // Update is called once per frame
    private void Update()
    {


        /*
        if(Input.GetKeyDown(KeyCode.K))
        {
            colorblind_on();

        }
        else if(Input.GetKeyDown(KeyCode.L))
        {
            colorblind_off();

        }
        */

        
    }


    //colorblind modunu aktif eder
    public void colorblind_on()
    {

        //sibiling.GetComponent<SpriteRenderer>().sprite = spriteBlind;
        //
        //
        sibiling.GetComponent<SpriteRenderer>().color = new Color(255,255,255);



    }

    public void changeSide()
    {
        sibiling.GetComponent<SpriteRenderer>().sprite = spriteAgainst;
        spritemain = spriteAgainst;

    }

    public void tag2InnocentfromEnemy()
    {
        gameObject.tag = "Innocent";

    }

    public void tag2EnemyfromInnocent()
    {
        gameObject.tag = "Enemy";
    }
    public void tagchance()
    {
        if(gameObject.tag=="Enemy")
        { tag2InnocentfromEnemy(); }

        else
        {
            tag2EnemyfromInnocent();
        }
    }


    //colorblind modunu kapatir
    public void colorblind_off()
    {
        
        /*
        sibiling.GetComponent<SpriteRenderer>().sprite = spritemain;
            */

        
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
