using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WhoWon : MonoBehaviour
{

    public TextMeshProUGUI PlayerWonTxt;

    private void Awake()
    {
        if (MoveBall.Player1Won == true)
        {
            PlayerWonTxt.text = Button.Player1 + " Won";
        }
        if(MoveBall.Player2Won == true)
        {
            PlayerWonTxt.text = Button.Player2 + " Won";
        }
    }

}
