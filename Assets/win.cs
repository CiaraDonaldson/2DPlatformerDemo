using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class win : MonoBehaviour
{
    public TextMeshProUGUI winner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("you win");
            winner.gameObject.SetActive(true);
            winner.enabled = true;
            ResetGame();
        }
    }
    public void ResetGame()
    {
        Invoke("ResetGameDelay", 3f);

    }

    public void ResetGameDelay()
    {
        SceneManager.LoadScene("SampleScene");

    }
}
