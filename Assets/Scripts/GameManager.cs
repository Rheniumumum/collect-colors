using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int StageNo;

    public bool isBallMoving;

    public GameObject colorBallPrefab;
    public GameObject colorBall;

    public GameObject monochroBallPrefab;
    public GameObject monochroBall;
    public GameObject monochroBallPrefab2;
    public GameObject monochroBall2;
    public GameObject monochroBallPrefab3;
    public GameObject monochroBall3;

    public GameObject startButton;
    public GameObject retryButton;

    public GameObject imageClear;
    public GameObject imageClearMessage;
    public GameObject imageGameover;
    public GameObject buttonGameoverRetry;
    public GameObject buttonGameoverHome;

    // Start is called before the first frame update
    void Start()
    {
        retryButton.SetActive(false);
        isBallMoving = false;
    }

    public void StageClear(){
        if(!imageGameover.activeSelf){
            if(PlayerPrefs.GetInt("CLEAR",0)<StageNo){
                PlayerPrefs.SetInt("CLEAR",StageNo);
                imageClearMessage.SetActive(true);
            }
            imageClear.SetActive(true);
            retryButton.SetActive(false);
            Invoke("GoBackStageSelect", 3.0f);
        }
    }

    void GoBackStageSelect(){
        SceneManager.LoadScene("StageSelectScene");
    }

    public void GameOver(){
        imageGameover.SetActive(true);
        retryButton.SetActive(false);
        buttonGameoverRetry.SetActive(true);
        buttonGameoverHome.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushStartButton(){
        Rigidbody2D crd = colorBall.GetComponent<Rigidbody2D>();
        crd.bodyType = RigidbodyType2D.Dynamic;

        Rigidbody2D mrd = monochroBall.GetComponent<Rigidbody2D>();
        mrd.bodyType = RigidbodyType2D.Dynamic;
        Rigidbody2D mrd2 = monochroBall2.GetComponent<Rigidbody2D>();
        mrd2.bodyType = RigidbodyType2D.Dynamic;
        Rigidbody2D mrd3 = monochroBall3.GetComponent<Rigidbody2D>();
        mrd3.bodyType = RigidbodyType2D.Dynamic;
    
        retryButton.SetActive(true);
        startButton.SetActive(false);
        isBallMoving = true;
    }

    public void PushRetryButton(){
        Destroy(colorBall);
        colorBall = (GameObject)Instantiate (colorBallPrefab);

        Destroy(monochroBall);
        monochroBall = (GameObject)Instantiate (monochroBallPrefab);
        Destroy(monochroBall2);
        monochroBall2 = (GameObject)Instantiate (monochroBallPrefab2);
        Destroy(monochroBall3);
        monochroBall3 = (GameObject)Instantiate (monochroBallPrefab3);

        retryButton.SetActive(false);
        startButton.SetActive(true);
        isBallMoving = false;
    }

    public void PushGameOverRetryButton(){
        imageGameover.SetActive(false);
        buttonGameoverRetry.SetActive(false);
        buttonGameoverHome.SetActive(false);

        Destroy(colorBall);
        colorBall = (GameObject)Instantiate (colorBallPrefab);

        Destroy(monochroBall);
        monochroBall = (GameObject)Instantiate (monochroBallPrefab);
        Destroy(monochroBall2);
        monochroBall2 = (GameObject)Instantiate (monochroBallPrefab2);
        Destroy(monochroBall3);
        monochroBall3 = (GameObject)Instantiate (monochroBallPrefab3);

        startButton.SetActive(true);
        isBallMoving = false;
    }

    public void PushGameOverHomeButton(){
        SceneManager.LoadScene("HomeScene");
    }

}
