using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class WinOnCollission : MonoBehaviour
{
    public string[] winMessage;

    private void OnTriggerEnter2D(Collider2D trig)
    {
        if (!GameMNGR.instance.GetHasKey())
        {
            return;
        }
        
        if (trig.gameObject.CompareTag("Player"))
        {
            GameMNGR.instance.EnableWinScreen(winMessage[Random.Range(0, winMessage.Length)]);
            Time.timeScale = 0;
        }
    }

}
