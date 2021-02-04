using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelenoScript : MonoBehaviour
{
    private PlayerScript PS;
    public GameObject player;
    public int counter;
    // Start is called before the first frame update
    void Start()
    {
        PS = player.GetComponent<PlayerScript>();
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (PS.playerDeath9 != true)
        {
            if (other.tag == "Player")
            {
                PS.Death = true;
                PS.playerDeath9 = true;
                counter = counter + 1;
                if (counter == 2)
                {
                    PS.playerDeath10 = true;
                }


            }
        }
    }
}
