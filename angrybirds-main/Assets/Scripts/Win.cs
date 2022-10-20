using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public int enemyscore = 3;
    private GameManager gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();
        enemyscore = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Debug.Log("player Win");
            //enemyscore -= 1;
            gamemanager.CheckForEnemys();
        }
        //if (enemyscore <= 0)
        //{
        //    Debug.Log("player Win");
        //}
    }
  
}
