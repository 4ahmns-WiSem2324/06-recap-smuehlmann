using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public float timeRemaining;
    public float newTime;
    public float minusTime;
    public bool timerIsRunning = false;
    [SerializeField]
    int randomNumber;
    [SerializeField]
    Text randomText;
    [SerializeField]
    int zahl;
    [SerializeField]  
    bool start = true;
    bool running;
    [SerializeField]
    int versuche;
    private void Start()

    {
        
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                //DisplayTime(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                //Lost();
            }
        }

        if (timeRemaining <= 0)
        {
            Lost();
        }

        

        if (Input.GetKeyDown("1") && !start)
        {
            zahl = 1;
        }
        if (Input.GetKeyDown("1") && start)
        {
            StartGame();
            start = false;
            versuche -= 1;
            Debug.Log("Kekw");
        }
        if (Input.GetKeyDown("2"))
        {
            zahl = 2;
        }
        if (Input.GetKeyDown("3"))
        {
            zahl = 3;
        }
        if (Input.GetKeyDown("4"))
        {
            zahl = 4;
        }
        if (Input.GetKeyDown("5"))
        {
            zahl = 5;
        }
        if (Input.GetKeyDown("6"))
        {
            zahl = 6;
        }

        if (start == false)
        {
            if (zahl == randomNumber && zahl != 0)
            {
                StartGame();
                Debug.Log("ja");
                //zahl = 0;
            }
            else if (zahl != randomNumber && zahl != 0)
            {
                Lost();
                Debug.Log("JaJa");
            }
            
        }



        
    }               
    /*void DisplayTime(float timeToDisplay) 
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }*/

    public void StartGame()
    {
        randomNumber = Random.Range(1, 7);
        randomText.text = randomNumber.ToString();
        versuche += 1;
        timeRemaining = newTime -= minusTime;
        newTime = newTime -= minusTime;
        //zahl = 0;
        Debug.Log("GameStarted");
    }

    public void NextNumber()
    {
        StartGame();
        Debug.Log("NextNumber");
    }

    public void Lost()
    {
        //zahl = 0;
        randomText.text = versuche.ToString();
        Debug.Log("I Lost");
        //versucheText.enabled = true;
        //randomText.enabled = false;
    }
}

