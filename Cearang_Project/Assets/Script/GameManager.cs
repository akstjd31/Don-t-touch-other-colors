using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int stage = 0;
    public int Coin = 0;
    public Text StageText;
    public Text CoinText;

    void NextStage()
    {
        stage++;

        StageText.text = stage + " Stage";
        
    }
       
    void GetCoin()
    {
        Coin++;

        CoinText.text = Coin + " Coin";
    }
    
    void GameStart()
    {
        StageText.text = stage + " Stage";
        CoinText.text = Coin + " Coin";
    }

    void Restart()
    {
        Application.LoadLevel("SampleScene");
    }

    void Death()
    {
        GameObject Player, camera, Bullet;
        Player = GameObject.Find("FreeCar");
        camera = GameObject.Find("Main Camera");
        Bullet = GameObject.Find("Bullets");
        Destroy(Player);
        Destroy(camera);
        Destroy(Bullet);
    }

    // Start is called before the first frame update
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
