using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PallaRotolanteScript : MonoBehaviour
{
    private PlayerScript PS;
    public float speed;
    public GameObject player;
    public int counter;
    public Vector3 spawnpalla;
    public GameObject palla;
    public Rigidbody2D RD;
    public GameObject collidermorte;
    // Start is called before the first frame update
    void Start()
    {
        PS = player.GetComponent<PlayerScript>();
        counter = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed * Time.deltaTime, 0f, 0f);
        if (PS.Death == true)
        {          
            speed = 0;
            RD.gravityScale = 0;
            transform.position = spawnpalla;
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            PS.Death = true;
            PS.playerDeath7 = true;            
            speed = 0;
            RD.gravityScale = 0;
            counter = counter + 1;                   
            if(counter == 2)
            {
                PS.playerDeath8 = true;
                collidermorte.SetActive(false);
            }
        }
    }
}
