using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class GameScore : MonoBehaviour
{
    //Score�ϐ�
    public int Score;
    //Score�̕\��
    private Text ScoreText;

    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
       ScoreText.text = string.Format("{0}", Score);

    }
}
