using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.SceneManagement;


public class buttonsTransitions : MonoBehaviour
{
    public void Playagain(){
        SceneManager.LoadScene("MainScene");
    }
}
