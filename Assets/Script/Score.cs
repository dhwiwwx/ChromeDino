using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI ScoreText;

    private float score = 0;
    

    void Update()
    {
        score += Time.deltaTime;
        ScoreText.text = ((int)score).ToString();
    }
}
