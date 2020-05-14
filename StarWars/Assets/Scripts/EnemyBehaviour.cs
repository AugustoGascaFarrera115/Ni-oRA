using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehaviour : MonoBehaviour
{

    GameObject ship;

    // Start is called before the first frame update
    void Start()
    {
        ship = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        Destroy(ship);
        Invoke("changeOtherScene", 2.0f);
    }


    void changeOtherScene()
    {
        SceneManager.LoadScene("LoserScene");
    }


}
