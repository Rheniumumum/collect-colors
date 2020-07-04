using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class HowtoManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushPlayGameButton(){
        SceneManager.LoadScene("StageSelectScene");
    }

    public void PushHomeButton(){
        SceneManager.LoadScene("HomeScene");
    }
}
