using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    private int score;
    
    // Start is called before the first frame update

    public void gameOver()
    {
        
        FindObjectOfType<paulAnimator>().gameOver = true;
        FindObjectOfType<Spawner>().gameObject.SetActive(false);
        Time.timeScale = 0;

    }

    public void addscore()
    {  
        
        score++;
        Debug.Log(score);
        
    }
}
