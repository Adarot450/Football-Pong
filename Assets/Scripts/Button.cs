using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{

    public static string Player1= "VVD";
    public static string Player2= "TAA";
    public static int ScoreToBeat = 10;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeScene(string Scene)
    {
        SceneManager.LoadScene(Scene);
    }

    public void QuitGame ()
    {
        Application.Quit();
    }

    public void ChoosePlayer1(string Name)
    {
        Player1 = Name;
    }

    public void ChoosePlayer2(string Name)
    {
        Player2 = Name;
    }

    public void ChangeScoreToBeat (int score)
    {
        ScoreToBeat = score;
    }
}
