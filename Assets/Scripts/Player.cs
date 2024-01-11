using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public FixedJoystick joystick;
    int score;
    public GameObject winText;
    public int winScore; 
    public float moveSpeed;
    float hInput, vInput;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void FixedUpdate(){
        hInput=joystick.Horizontal * moveSpeed;
        vInput=joystick.Vertical*moveSpeed;
        transform.Translate(hInput,vInput,0);
    }
    private void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag=="Apple"){
            score++;
            Destroy(collision.gameObject);
            if (score>=winScore){
                winText.SetActive(true);
            }
        }
    }
}
