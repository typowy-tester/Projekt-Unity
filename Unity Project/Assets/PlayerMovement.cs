using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float predkosc;
    public GameObject gameManagerObject;
    private GameManager gm;
    private int points;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        gm = gameManagerObject.GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Punkty: " + points.ToString();
    }

    private void FixedUpdate()
    {
        Vector3 przesuniecie = new Vector3(Input.GetAxisRaw("Horizontal"), 0, 0);
        przesuniecie *= Time.fixedDeltaTime;
        przesuniecie *= predkosc = 30;
        transform.position += przesuniecie;
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("Uruchomiono OnCollisionEnter");
        //Debug.Log(collision.gameObject.ToString());
        if (collision.gameObject.CompareTag("Teren"))
        {
            //wpadliśmy na ścianę
            Debug.Log("Koniec gry");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if (collision.gameObject.CompareTag("KillSphere"))
        {
            Debug.Log("Koniec gry");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (collision.gameObject.CompareTag("PointSphere"))
        {
            //Zdobycie punktu
            points++;
            //Debug.Log("Punkty");
            Destroy(collision.gameObject);
        }
    }
}
