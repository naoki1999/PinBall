using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class CountScore : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;
   
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score : 0";
    }

    //�{�[�������ꂼ��̃I�u�W�F�N�g�ɏՓ˂����ꍇ
    private void OnCollisionEnter(Collision collision)
    {

        //�{�[����SmallStarPrefab�ɏՓ˂����ꍇ
        if (collision.gameObject.tag == "SmallStarTag")
        {
            score += 10;
        }

        if (collision.gameObject.tag == "LargeStarTag")
        {
            score += 20;
        }

        if (collision.gameObject.tag == "SmallCloudTag")
        {
            score += 30;
        }

        if (collision.gameObject.tag == "LargeCloudTag")
        {
            score += 40;
        }

        SetScore();
    }
        void SetScore() 
        {
            scoreText.text = string.Format("Score{0}", score);
        }
    
    // Update is called once per frame
    void Update()
    {
       
    }
}
