using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 using UnityEngine.SceneManagement;
public class CharacterController : MonoBehaviour
{
    public bool controller;
    public Rigidbody PlayerRb;
    public Button move;
    public GameObject youWin;
    public Animator playerAnim;
    // Start is called before the first frame update
    void Start()
    {
    controller=true;
    PlayerRb = GetComponent<Rigidbody>();
    move = GetComponent<Button>();  
    youWin.SetActive(false);  
    playerAnim=GetComponent<Animator>();
    }
    //Now im going to make a collision to evaluate if player collision with trap objects, if he collision, it will die
    void OnCollisionEnter(Collision col) {
        if(col.gameObject.tag=="die"){
            SceneManager.LoadScene("MainScene");
        }
    }
    void OnTriggerEnter(Collider col) {
        if(col.gameObject.tag=="end"){
            youWin.SetActive(true);
            PlayerRb.velocity= new Vector3(0,0,0);
            playerAnim.SetBool("run",false);
            controller=false;
        }
        
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        if(controller==true){
        //I evaluate if screen is touched or not
        if(Input.touches.Length<=0){
        //If screen is not touched, velocity is 0
        PlayerRb.velocity= new Vector3(0,0,0);
        playerAnim.SetBool("run",false);

    }  
    else
    {
        //If screen is touched veocity incremented in Z axis
        Debug.Log("You touched me");
        PlayerRb.velocity= new Vector3(0,0,6);
        playerAnim.SetBool("run",true);
    }
    }
}
}
