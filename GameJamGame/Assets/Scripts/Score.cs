using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Score : MonoBehaviour
{
    public static Score Instance;

    public event EventHandler<OnScoreChangedEventArgs> OnScoreChanged;

    public class OnScoreChangedEventArgs
    {
        public int score;
    }

    private int _currentScore;

    private void Start()
    {
        Instance = this;
    }

    public void AddPoints(int points)
    {
        _currentScore += points;
        OnScoreChanged?.Invoke(this, new OnScoreChangedEventArgs { score = _currentScore });
    }

}
