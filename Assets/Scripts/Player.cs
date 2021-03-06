using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject playersib;


    public GameObject dynamicArmNeeded;
    public float dynamicdistance2move=0.2f;
    private float dynamic2back=0f;

    public GameObject venom;

    public GameObject needleexample;

    public float speed;

    public GameObject needlePrefab;

    public int positiveScore;
    public int negativeScore;


    public int needleCounter = 10;

    public float clock4fireRate =0.0f ;
    public float time4fireRate = 0.2f;


    private Vector2 moveVelocity;


    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //Player movement
        movementPlayer();


        throwNeedle();




    }


    public void scoreUp()
    {
        positiveScore += 1;

    }

    public void scoreDown()
    {
        negativeScore -= 1;

    }


    public void needleCountUp()
    {
        needleCounter += 1;

    }

    //needle sayisi azaliyor sahip olunan
    public  void needleCountDown()
    {
        needleCounter -= 1;
    }

    //Player Movement Up down right left
    public void movementPlayer()
    {
        Vector2 playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 moveVelocity = playerInput * speed; //* Time.deltaTime  //oyunu bozabilir baska pcde o yuzden kaldirdim
                // Time.deltaTime eklenmese de olur amaa eklendigi zaman faydalari var gibi hissettim bunu arastiracagim
        
        GetComponent<Rigidbody2D>().velocity = moveVelocity;
        animationUponMovement();

        //transform.Translate(moveVelocity);


    }


    public void animationUponMovement()
    {
        playersib.GetComponent<Animator>().SetInteger("DA", (int)Input.GetAxisRaw("Horizontal"));//setfloat ile animatordaki DA degerini belirliyorum 
        //moveVelocity[0];
        if((int)Input.GetAxisRaw("Horizontal") < 0)
        {
            playersib.GetComponent<SpriteRenderer>().flipX = true;
            

        }
        else if ((int)Input.GetAxisRaw("Horizontal") > 0)
            {
            playersib.GetComponent<SpriteRenderer>().flipX = false;

        }


        playersib.GetComponent<Animator>().SetInteger("WS", (int)Input.GetAxisRaw("Vertical"));

    }

    public void throwNeedle()
    {
        if (needleCount() & timeProcess4needlerate() )
        {


            HamKnock();

        }
    }

    public bool timeProcess4needlerate()
    {
        clock4fireRate += Time.deltaTime;
        if(clock4fireRate > time4fireRate)
        {

            dynamic2whole(-dynamic2back);


            return true; 

        }
        else { return false; }
        

    }


    public bool needleCount()
    {
        if(needleCounter>0)
        {
            
            return true;
             
        }
        else
        {
            return false;
        }

    }


    // asi atiyor ucabilecek
    public void HamKnock()
    {



        if(Input.GetMouseButtonDown(0))
        {


            GameObject go = GameObject.Instantiate(needlePrefab);
            go.transform.rotation = needleexample.transform.rotation;
            go.transform.position = needleexample.transform.position;
            //go.gameObject.GetComponent<Needle>().cikisNoktasi = go.transform.position;// sekme icin gerekliydi gerke kalmadi 
            go.gameObject.GetComponent<Needle>().directionDetermine();


            clock4fireRate = 0f;// ates ettikten sonra sifirlaniyor rate i

            needleCountDown();


            //buraya ates edince his gelmesi eklenecek 

            effectrecoil();

        }



    }








    // atistan sonraki efektler
    public void effectrecoil()
    {
        //particle system ile zehir dagiliyor biraz
        venom.GetComponent<ParticleSystem>().Play();


        //ileri gidecek dynamicArmNeedeed (example needle ve kollar)
        dynamic2whole(dynamicdistance2move);
        //!!!!!!!!!




    }



    public void dynamic2whole(float distance)
    {
        
        dynamicArmNeeded.transform.Translate(Vector3.up * distance);
       
        if (distance<0)
        {
            dynamic2back = 0;

        }
        else { dynamic2back = distance; }
        
    }









}
