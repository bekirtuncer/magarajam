using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class deneme1 : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {//oldu
        
    }

    // Update is called once per frame
    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "Level 1")
        {

        }
        
    }

    public void changeScene(string scenename)
    {
        SceneManager.LoadScene(scenename);

    }



}
