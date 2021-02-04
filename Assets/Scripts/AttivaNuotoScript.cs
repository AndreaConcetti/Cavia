using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AttivaNuotoScript : MonoBehaviour
{
    public Rigidbody2D RG;
    public GameObject player;
    private PlayerScript PS;
    public GameObject sliderD;
    private PlatformerCharacter2D PC;
    public Slider slider;
    

    // Start is called before the first frame update
    void Start()
    {
        PS = player.GetComponent<PlayerScript>();
        PC = player.GetComponent<PlatformerCharacter2D>();
        slider = sliderD.GetComponent<Slider>();
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
            if(PS.playerDeath5 == true)
            {
                PC.m_MaxSpeed = 20;
            }
            

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            RG.gravityScale = 3;
            sliderD.SetActive(false);
            PC.m_MaxSpeed = 10;
            slider.value = 1;
        }
    }
}
