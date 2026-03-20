using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField] AudioSource buttonsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restart()
    {
        buttonsound.Play();
        SceneManager.LoadScene(1);
    }
    public void home()
    {
        buttonsound.Play();
        SceneManager.LoadScene(0);
    }
}
