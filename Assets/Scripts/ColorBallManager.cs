using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorBallManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D coll){
        if(coll.gameObject.tag == "OutArea"){
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<GameManager> ().GameOver();
        }
    }

    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "ClearArea"){
            GameObject gameManager = GameObject.Find("GameManager");
            gameManager.GetComponent<GameManager>().StageClear();
        }
    }
}
