using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSession : MonoBehaviour
{
    [SerializeField] int score = 0;

    // Start is called before the first frame update
    void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
            FindObjectsOfType<GameSession>()[0].ResetGameSession();
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public void AddScore(int addingScore)
    {
        score += addingScore;
    }

    public int GetScore()
    {
        return score;
    }

    public void ResetGameSession()
    {
        score = 0;
    }
}
