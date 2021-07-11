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
    

    //RaycastHit hit;
    //private Vector3 closestDat; //en yakin noktayi verir
    //private Vector3 cikisAcisi;
    //private Vector3 aimPoint;
    //public Vector3 cikisNoktasi;
    //private Vector3 asda;

    public Vector3 direction;
    // var diye baslatttiklari sey var onu da ogren 

    // Start is called before the first frame update
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //GetComponent<Rigidbody2D>().velocity = transform.TransformVector(Vector3.up * speed);
        //GetComponent<Rigidbody2D>().
        //Debug.Log(transform.rotation.eulerAngles);


        //sekme icin gerekliydi gerek kalmadi 
        //cikisAcisi = transform.rotation.eulerAngles;
        //cikisNoktasi = transform.position;

        //aimPointDetermine();
        // sekme icin gerekliydi gerek kalmadi son 


    }

    // Update is called once per frame
    private void Update()
    {
        //bu buglu bunu daha sonra incele 
        //  transform.Translate(transform.up * speed * Time.deltaTime);


        //bunu da kullaniyordum tam sektirme icin degisiklige gidiyorum
        transform.Translate( Vector3.up * speed * Time.deltaTime );

        //GetComponent<Rigidbody2D>().velocity = Vector3.up * speed ;//* Time.deltaTime

        //GetComponent<Rigidbody2D>().velocity = transform.TransformVector(Vector3.up * speed );
        //transform.LookAt(new Vector2(transform.position[0], transform.position[1]) + GetComponent<Rigidbody2D>().velocity);

        //GetComponent<Rigidbody2D>().velocity = transform.TransformVector(Vector3.up * speed);

        acces2Destroy();


        



    }

    public void directionDetermine()
    {
        direction = transform.TransformVector(Vector3.up);
    }


    public void aimPointDetermine()
    {//ikinci parametere olarak transform.up idi ama ben Vector3.up yapiyorum
        /*
        if (Physics.Raycast(transform.position, Vector3.up, out hit, Mathf.Infinity))
        {
            aimPoint = hit.point;
            
            //Debug.Log(hit.normal.ToString());
        }
        */


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


    //suspended
    public  void sekme()
    {/*
        asda = transform.position - closestDat;
       // asda = aimPoint - closestDat;
        

       // if(asda[0]!=)

        if (asda[1]>0f)
        {
            //Quaternion.setLookRotation()
            // transform.rotation.SetLookRotation(-cikisNoktasi - 2 *( cikisNoktasi.x - aimPoint.x) * Vector3.right + transform.position);

            //  transform.rotation= Quaternion.LookRotation(Vector3.forward, cikisNoktasi - 2 * (cikisNoktasi.x - aimPoint.x) * transform.right - transform.position );
            transform.rotation = Quaternion.LookRotation(Vector3.forward, (cikisNoktasi - 2 * (cikisNoktasi.x - aimPoint.x) * Vector3.right) - aimPoint);
        }
        
        if (asda[1] < 0f)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, Vector3.Normalize( cikisNoktasi - 2 * (cikisNoktasi.x - aimPoint.x) * new Vector3(1,0,0) - aimPoint));

            //transform.rotation = Quaternion.LookRotation((cikisNoktasi - 2 * (cikisNoktasi.x - aimPoint.x) * Vector3.right) - transform.position, Vector3.up);
            // transform.rotation = Quaternion.LookRotation(Vector3.forward, (cikisNoktasi -  2*(cikisNoktasi.x - aimPoint.x) * Vector3.right)-transform.position );

        }

        //GetComponent<Rigidbody2D>().velocity = asda;
        print(asda);
        if(asda[0]>0f)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, cikisNoktasi - 2 * (cikisNoktasi.y - aimPoint.y) * Vector3.up - transform.position);

            //transform.LookAt(cikisNoktasi + 2*(cikisNoktasi.y - transform.position.y)* Vector3.up  , transform.up);

        }

         if (asda[0] <0f)
        {
            transform.rotation = Quaternion.LookRotation(Vector3.forward, (cikisNoktasi - 2 * (cikisNoktasi.y - aimPoint.y) * Vector3.up)-transform.position);

            //transform.LookAt(cikisNoktasi + 2*(cikisNoktasi.y - transform.position.y)* Vector3.up  , transform.up);

        }
        




        print("sss");

*/
    }


    public void OnCollisionEnter2D(Collision2D collision)
    {
        /*
                Debug.Log(GetComponent<Rigidbody2D>().velocity);
                //GetComponent<Rigidbody2D>().velocity = new Vector3(-collision.relativeVelocity.x, -collision.relativeVelocity.y);// *speed;
                Debug.Log(GetComponent<Rigidbody2D>().velocity); 
                Debug.Log(collision.relativeVelocity.x);
                Debug.Log(collision.relativeVelocity.y);

                //GetComponent<Rigidbody2D>().velocity *= 20;// transform.TransformVector(Vector3.up * speed);

                //Bounds.

                //GetComponent<Rigidbody2D>().AddRelativeForce(collision.relativeVelocity/20);
                //GetComponent<Rigidbody2D>().AddForce();
                //GetComponent<Rigidbody2D>().AddForceAtPosition()
        */

        //Debug.Log(transform.rotation.eulerAngles);

        //closestDat= collision.gameObject.GetComponent<BoxCollider2D>().bounds.ClosestPoint(transform.position);
        //Debug.Log(transform.position-closestDat);

        //aimPoint;
        //transform.position =;(transform.position - closestDat)

        //sekme();
        //cikisNoktasi = closestDat;  //transform.position;



        // Vector3.Reflect bize sekme sagladýktan sonraki direction umuzu veriyor.
        // // parametre 1: su anki yonumuzu belirten vector3 ifadesini istiyor biz normalized diyerek degerleri 0 ile 1 arasina cektirk
        // // parametre 2 : merminin carptigi surface ile i normalolarak veriyoruz // unity notlar kismina ekliyorum bunun ile ilgili kaynaklari 
        direction = Vector3.Reflect(direction.normalized, collision.contacts[0].normal);

        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);



        if (collision.gameObject.tag == "Enemy")
        {
            collision.gameObject.GetComponent<colorblind>().changeSide();
            //collision.gameObject.tag = "Innocent";//tagi innocent oldu yani masum 
            collision.gameObject.GetComponent<colorblind>().tag2InnocentfromEnemy();
            

            player.GetComponent<Player>().scoreUp();
            Destroy(gameObject);
        }



        else if (collision.gameObject.tag == "Innocent") 
        {
            

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
