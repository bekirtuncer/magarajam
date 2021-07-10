using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public GameObject hamknocksib;

    public float speed;


    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        //Player movement
        movementPlayer();







    }


    //Player Movement Up down right left
    public void movementPlayer()
    {
        Vector2 playerInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 moveVelocity = playerInput * Time.deltaTime * speed; 
                // Time.deltaTime eklenmese de olur amaa eklendigi zaman faydalari var gibi hissettim bunu arastiracagim
        
        GetComponent<Rigidbody2D>().velocity = moveVelocity;

        //transform.Translate(moveVelocity);


    }



    public void HamKnock()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
            Input.mousePosition()

        }



    }






















}
