using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rb;
    bool iscrashHappend = false;

    void Start() 
    {
  
    }
    void Update()
    {
        if(!iscrashHappend)
        {
            rb.AddForce(Vector3.forward * 8, ForceMode.Force);
        }
        else if (iscrashHappend)
        {
            rb.velocity = Vector3.zero;
        }
        
        if(Input.GetKey(KeyCode.D))
        {
            rb.AddForce(8, 0, 0, ForceMode.Force);
        }

        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-8, 0, 0, ForceMode.Force);
        }
    }
         
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.collider.tag == "obstackle")   
        {
            Invoke("Restart", 1f);
            iscrashHappend = true;
        }
    }
    
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        iscrashHappend = false;
    }
}
