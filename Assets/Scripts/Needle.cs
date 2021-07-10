using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Needle : MonoBehaviour
{

    public bool acces4Destroy=false;
    public float clock4Destory = 0f;
    public float time4Destory = 2f;


    private GameObject player;

    public float speed =10f;
    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
    }

    // Update is called once per frame
    private void Update()
    {
        //bu buglu bunu daha sonra incele 
       //  transform.Translate(transform.up * speed * Time.deltaTime);



        transform.Translate( Vector3.up * speed * Time.deltaTime );


        acces2Destroy();




    }

    public void acces2Destroy()
    {
        if(acces4Destroy)
        {
            clock4Destory += Time.deltaTime;
            if (clock4Destory > time4Destory)
            {
                Destroy(gameObject);
            }
        }

    }


    public void OnCollisionEnter2D(Collision2D collision)
    {

       if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("enemy");
            player.GetComponent<Player>().scoreUp();
            Destroy(gameObject);
        }



        else if (collision.gameObject.tag == "Innocent") 
        {
            Debug.Log("innocent");

            player.GetComponent<Player>().scoreDown();
            Destroy(gameObject);

        }
       else if(collision.gameObject.tag=="Player")
        {

        }
        else
        {
            acces4Destroy = true;
            //Destroy(gameObject);
           
        }


    }




}
