using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;   
    }

    // Update is called once per frame
    void Update()
    {
        //Once the player collect all ten coin, Game Over
        if (score >= 5)
        {
            Debug.Log("Exit game!");
            Application.Quit();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // On collion with a object with the tag call "Coin" destory it, and 1 to the score veriable
        if (collision.gameObject.tag == "SpacePart")
        {
            GameObject.Destroy(collision.gameObject);
            score++;
            RemainingSpaceParts.SpaceParts -= 1;
        }

    }
}
