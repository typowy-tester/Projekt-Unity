using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gracz;
    public GameObject KillSphere;
    public GameObject PointSphere;

    public float spawnkillsphere = 5;
    public float spawnpointsphere = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        spawnkillsphere -= Time.fixedDeltaTime;
        if (spawnkillsphere <= 0)
        {
            Instantiate(KillSphere, new Vector3(Random.Range(-10, 10), 0, 20), Quaternion.identity);
            spawnkillsphere = 5;
        }

        spawnpointsphere -= Time.fixedDeltaTime;
        if (spawnpointsphere <= 0)
        {
            Instantiate(PointSphere, new Vector3(Random.Range(-10, 10), 0, 20), Quaternion.identity);
            spawnpointsphere = 2;
        }
    }
}
