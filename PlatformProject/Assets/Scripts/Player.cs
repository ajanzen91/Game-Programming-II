using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int score = 0;
    public int numHits = 0;
    public float timeElapsed = 0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeElapsed += Time.deltaTime;

       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Points")
        {
            score += other.GetComponent<Pickup>().value;
            Destroy(other.gameObject);
            Debug.Log("Score: " + score);
        }

        if(other.gameObject.tag == "Objective")
        {
            //change level# scene manager?
            Destroy(other.gameObject);
            SceneManager.LoadScene(1);
            
        }
    }
}