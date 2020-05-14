using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vaderBehaviour : MonoBehaviour
{
    //GameObject ship;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
       
            Destroy(this.gameObject);

        changeOtherScene();
    }


    void changeOtherScene()
    {
        SceneManager.LoadScene("WinScene");
    }

}
