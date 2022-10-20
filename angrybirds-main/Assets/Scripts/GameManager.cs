using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public Transform EnemyContainer;
    public static int nextScene;
    public GameObject winmenu;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void CheckForEnemys()
    {
        int childcounter = 0;
        foreach (Transform child in EnemyContainer)
        {
            childcounter += 1;
        }
        if (childcounter == 1)
        {


            winmenu.SetActive(true);
            //nextScene += 1;
            Debug.Log("bam");
            // Async = Loads game in bg
            //SceneManager.LoadSceneAsync("Level1");
        }
        Debug.Log(childcounter);
    }
}
