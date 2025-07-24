using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class DeathOnCollission : MonoBehaviour
{
    public string[] deathMessages;
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            GameMNGR.instance.EnableLoseScreen(deathMessages[Random.Range(0, deathMessages.Length)]);
            Time.timeScale = 0;
        }
    }
}
