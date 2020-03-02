using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

    string PlayerOneName;
    string PlayerTwoName;

    public int Win1;
    public int Win2;



    public bool activeGame = true;

    public bool Player1 = true;
    public bool Player2 = false;

    public int whoWin;

    public int one;
    public int two;
    public int three;
    public int four;
    public int five;
    public int six;
    public int seven;
    public int eight;
    public int nine;

    public GameObject UI;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        SetUp();
        WinCondition();

        if (whoWin == 1)
        {
            UI.transform.GetChild(2).gameObject.SetActive(true);
        }
        if (whoWin == 2)
        {
            UI.transform.GetChild(3).gameObject.SetActive(true);
            Debug.Log("Player2 win");
        }
    }

    void Reset
    {

    }

  

    void SetUp()
    {
        one = this.transform.Find("Play Area 1").gameObject.GetComponent<Box>().Check;
        two = this.transform.Find("Play Area 2").gameObject.GetComponent<Box>().Check;
        three = this.transform.Find("Play Area 3").gameObject.GetComponent<Box>().Check;
        four = this.transform.Find("Play Area 4").gameObject.GetComponent<Box>().Check;
        five = this.transform.Find("Play Area 5").gameObject.GetComponent<Box>().Check;
        six = this.transform.Find("Play Area 6").gameObject.GetComponent<Box>().Check;
        seven = this.transform.Find("Play Area 7").gameObject.GetComponent<Box>().Check;
        eight = this.transform.Find("Play Area 8").gameObject.GetComponent<Box>().Check;
        nine = this.transform.Find("Play Area 9").gameObject.GetComponent<Box>().Check;
        UI = GameObject.Find("Canvas");
    }
    void WinCondition()
    {
        if( one == 1 && two == 1 && three == 1)
        {
            activeGame = false;
            whoWin = 1;
            Win1++;

        }
        if( four == 1 && five == 1 && six == 1)
        { 
            activeGame = false; 
            whoWin = 1;
            Win1++;

        }
        if( seven == 1 && eight == 1 && nine == 1)
        { 
            activeGame = false;
            whoWin = 1;
            Win1++;

        }
        if( one == 1 && four == 1 && seven == 1)
        { 
            activeGame = false;
            whoWin = 1;
            Win1++;

        }
        if( two == 1 && five == 1 && eight == 1)
        {
            whoWin = 1;
            activeGame = false;
            Win1++;


        }
        if( three == 1 && six == 1 && nine == 1)
        {
            whoWin = 1;
            activeGame = false;
            Win1++;
        }
        if( one == 1 && five == 1 && nine == 1)
        {
            whoWin = 1;
            activeGame = false;
            Win1++;


        }
        if( seven == 1 && five == 1 && three == 1)
        {
            whoWin = 1;
            activeGame = false;
            Win1++;

        }
 //---------------------------------------------------------------------
        if (one == 2 && two == 2 && three == 2)
        {
            whoWin = 2;
            activeGame = false;
            Win2++;

        }
        if (four == 2 && five == 2 && six == 2)
        {
            whoWin = 2;
            activeGame = false;
            Win2++;

        }
        if (seven == 2 && eight == 2 && nine == 2)
        {
            whoWin = 2;
            activeGame = false;
            Win2++;

        }
        if (one == 2 && four == 2 && seven == 2)
        {
            whoWin = 2;
            activeGame = false;
            Win2++;

        }
        if (two == 2 && five == 2 && eight == 2)
        {
            whoWin = 2;
            activeGame = false;
            Win2++;

        }
        if (three == 2 && six == 2 && nine == 2)
        {
            whoWin = 2;
            activeGame = false;
            Win2++;

        }
        if (one == 2 && five == 2 && nine == 2)
        {
            whoWin = 2;
            activeGame = false;
            Win2++;

        }
        if (seven == 2 && five == 2 && three == 2)
        {
            whoWin = 2;
            activeGame = false;
            Win2++;

        }
    }

 

}
