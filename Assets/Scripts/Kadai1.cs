using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kadai1 : MonoBehaviour
{



   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit");
        //GetComponent<AudioSource>().volume = (collision.gameObject.tag == "unityChan") ? 0 : 1;
        if (collision.gameObject.tag == "ground")
        {
            //GetComponent<AudioSource>().volume = 1;
            GetComponent<AudioSource>().Play();
            Debug.Log("Ground");
        }
        else if(collision.gameObject.tag == "box")
        {
            GetComponent<AudioSource>().Play();
     
        }
        
    }

}
