using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{
    private Slider slider;
    public float fillSpeed;
    private PlayerScript PS;
    public GameObject player;
    public int counter;
    
    
    // Start is called before the first frame update
    void Start()
    {
        slider = gameObject.GetComponent<Slider>();
        PS = player.GetComponent<PlayerScript>();
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {      
        {
            if (PS.playerDeath6 == false)
            {
                slider.value -= fillSpeed * Time.deltaTime;
            }
            if(PS.playerDeath6 == true)
            {
                slider.value -= fillSpeed / 2 * Time.deltaTime;
            }
            if(slider.value <= 0)
            {
                PS.Death = true;
                PS.playerDeath5 = true;
                counter = counter + 1;
                slider.value = 1;
                if(counter == 2)
                {
                    PS.playerDeath6 = true;
                }

            }
            
        }
    }
}
