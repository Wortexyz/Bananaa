using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public FixedJoystick joyStick;
    [SerializeField] GameObject winpannel;
    [SerializeField] float Movespeed,hInput,vInput;
    [SerializeField] TextMeshProUGUI scoretext , BalanceBanana;
    int score = 0 , toatalBanana = 10 ,balance;
    bool notfinished = true;

    void Start()
    {
        winpannel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (toatalBanana==score)
        {
            notfinished = false;
            winpannel.SetActive(true);
        }
    }

    private void FixedUpdate()
    {
        hInput = joyStick.Horizontal * Movespeed * Time.deltaTime;
        vInput = joyStick.Vertical * Movespeed * Time.deltaTime;
        movePlayer(hInput,vInput);

        
    }
    private void movePlayer(float x,float y)
    {
        if (notfinished == true)
        {
            transform.Translate(x, y, 0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
       if( collision.gameObject.tag == "Banana" )
        {
            Destroy(collision.gameObject);
            score++;
            balance = toatalBanana - score;
            scoretext.text = "Score :" + score.ToString();
            BalanceBanana.text = "Balance Banana :" + balance.ToString();
        }
    }

}
