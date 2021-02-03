using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttivaNuotoScript : MonoBehaviour
{
    public Rigidbody2D RG;
    
   
    public GameObject sliderD;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            RG.gravityScale = 1;
            sliderD.SetActive(true);
            

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            RG.gravityScale = 3;
            sliderD.SetActive(false);
        }
    }
}
