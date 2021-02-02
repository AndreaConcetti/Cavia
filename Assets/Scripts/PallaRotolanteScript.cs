using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PallaRotolanteScript : MonoBehaviour
{
    public PlayerScript PS;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(speed, 0f, 0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            PS.Death = true;
            PS.playerDeath5 = true;
        }
    }
}
