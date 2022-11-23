using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public Text score;
    int points = 0;

    void Start()
    {
        
    }
    
    void Update()
    {
        score.text = points.ToString();
    }

    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == "coin")
        {
            points++;
            Destroy(collision.gameObject);
        }

        if (collision.collider.tag == "cone")
        {
            points--;
            Destroy(collision.gameObject);
        }
    }
}
