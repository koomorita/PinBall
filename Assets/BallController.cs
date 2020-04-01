using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BallController : MonoBehaviour
{

    private int scorepoints;
    

    //ボールが見える可能性のあるz軸の最大値
    private float visiblePosZ = -6.5f;

    //ゲームオーバーとスコアと得点を表示するテキスト
    private GameObject gameoverText;
    private GameObject scoremozi;
    private GameObject scorepoint;
   


    // Use this for initialization
    void Start()
    {

        

        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        this.scoremozi = GameObject.Find("Scoremozi");
        this.scorepoint = GameObject.Find("Scorepoint");






    }
    //＠＠＠＠＠ポイント加算の判定。＠＠＠＠＠
    void OnCollisionEnter(Collision collision) {


        if (collision.gameObject.tag == "SmallCloudTag")
        {
         　//ちっちゃい雲　ポイント加算
            scorepoints += 10;
            
        }

        if (collision.gameObject.tag == "LargeStarTag")
        {
           //おっきい星　ポイント加算
            scorepoints += 100;

        }

        if (collision.gameObject.tag == "SmallStarTag")
        {
            //ちっちゃい星　ポイント加算
            scorepoints += 15;

        }

        if (collision.gameObject.tag == "LargeCloudTag")
        {
            //おっきい雲　ポイント加算
            scorepoints += 100;

        }










    }
    //＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠＠

        // Update is called once per frame
        void Update()
    {

        this.scorepoint.GetComponent<Text>().text = "" + scorepoints ;


        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePosZ) { 
            

            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "END";
        }
        Debug.Log(scorepoints);
    }       
}