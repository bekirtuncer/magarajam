using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class level1to2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            print("sss");
            if(!GameObject.FindGameObjectWithTag("Enemy"))
            { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
                }
        }
    }


}
