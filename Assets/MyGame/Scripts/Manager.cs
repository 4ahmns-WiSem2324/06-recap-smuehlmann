using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    [SerializeField] int randomNumber;
    [SerializeField] int Zahl;
    [SerializeField] TextMeshProUGUI Nummer;
    [SerializeField] float lastTime;
    [SerializeField] float currentTime;
    [SerializeField] int versuche;
    bool running = true;
    bool started;
    bool ended = false;
    public GameObject lostText;

    private void Start()
    {
        lostText.SetActive(false);
    }
    void Update()
    {

        if (running)
        {

            currentTime -= Time.deltaTime;
        }


        if (currentTime <= 0 && running)
        {
            Lost();
        }


        if (Input.GetKeyDown("1") && running)
        {
            Zahl = 1;
        }

        if (Input.GetKeyDown("1") && !started)
        {

            started = true;
        }

        if (Input.GetKeyDown("1") && ended)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown("2"))
        {
            Zahl = 2;
        }

        if (Input.GetKeyDown("3"))
        {
            Zahl = 3;
        }

        if (Input.GetKeyDown("4"))
        {
            Zahl = 4;
        }

        if (Input.GetKeyDown("5"))
        {
            Zahl = 5;
        }

        if (Input.GetKeyDown("6"))
        {
            Zahl = 6;
        }





        if (running)
        {
            if (Zahl == randomNumber)
            {
                StartGame();
            }
            else if (Zahl != randomNumber && Zahl != 0)
            {
                Lost();
            }
        }


    }

    public void StartGame()
    {
        running = true;
        randomNumber = Random.Range(1, 7);
        Nummer.text = randomNumber.ToString();

        currentTime = 3;
        versuche += 1;
        
        Zahl = 0;
        lastTime -= 0.05f;
        currentTime = lastTime;

    }


    public void Lost()
    {
        ended = true;
        Zahl = 0;
        running = false;
        Nummer.text = versuche.ToString();
        Debug.Log("I Lost");
        lostText.SetActive(true);
    }


}

