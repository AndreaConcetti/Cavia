using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NemiciScriptPadre : MonoBehaviour
{
    public float speed;
    private PlayerScript PS;
    public GameObject player;
    public Vector3 spawnnemico;
    

    // Start is called before the first frame update
    void Start()
    {
        PS = player.GetComponent<PlayerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(-speed * Time.deltaTime, 0f, 0f);
        if (PS.Death == true)
        {
            this.gameObject.SetActive(true);
            speed = 0;
            
            transform.position = spawnnemico;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {       
       if (other.tag == "Player")
       {
          if (PS.playerDeath3 == true)
          {
                this.gameObject.SetActive(false);
          }
       }
       if (other.tag == "Palla")
        {
            this.gameObject.SetActive(false);
        }
        
    }
}
