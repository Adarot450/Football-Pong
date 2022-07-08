using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    //public string SceneName;

    // Start is called before the first frame update
    void Start()
    {
        //ChangeScene(SceneName);
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

}
