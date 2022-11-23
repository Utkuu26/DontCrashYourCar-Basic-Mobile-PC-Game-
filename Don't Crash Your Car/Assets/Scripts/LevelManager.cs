using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public Rigidbody carRb;
    public List<GameObject> levelList = new List<GameObject>();
    private int currentlvl;
    public GameObject car; 
    private GameObject previousLvl;

    void Start()
    {
        currentlvl = 0;
        previousLvl = Instantiate(levelList[currentlvl], transform.position, Quaternion.identity);
        currentlvl++;
    }

    private void OnTriggerEnter(Collider other) 
    {
        Invoke("NextLevel", 0.3f);
    }

    private void NextLevel()
    {
        carRb.velocity = Vector3.zero;
        levelList.RemoveAt(currentlvl-1);
        Destroy(previousLvl);
        previousLvl = Instantiate(levelList[currentlvl-1], transform.position, Quaternion.identity);
        car.transform.position = new Vector3(0,0,0);
    }
}
