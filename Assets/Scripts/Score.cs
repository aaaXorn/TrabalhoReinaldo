using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score Instance { get; private set; }
    
    private int scr;

    private Text txt;

    private void Awake()
    {
        //setta a referência global desse script
        if (Instance == null) Instance = this;
        //garante que só tem um dele na cena
        else Destroy(gameObject);
    }

    private void Start()
    {
        txt = GetComponent<Text>();
    }

    public void ChangeScore(int pts)
    {
        scr += pts;

        txt.text = "SCORE: " + scr;
    }
}
