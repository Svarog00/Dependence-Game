using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    private Text text;
    void Start()
    {
        text = GetComponent<Text>();
        Score.Instance.OnScoreChanged += Instance_OnScoreChanged;
    }

    private void Instance_OnScoreChanged(object sender, Score.OnScoreChangedEventArgs e)
    {
        text.text = e.score.ToString();
    }
}
