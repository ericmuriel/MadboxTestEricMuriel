using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject Player;
    public Transform PlayerTransform;
    public GameObject Camara;
    private Vector3 _cameraOffset;


    // Start is called before the first frame update
    void Start()
    {  
    _cameraOffset=new Vector3(6.43f,5.29f,-4.87f);
    Player=GameObject.FindWithTag("Player");
    Camara =GameObject.FindWithTag("MainCamera");
    }

    // Update is called once per frame
    void Update()
    {
     if(Player.transform.position.z >0.66){
        //Camara.transform.position= new Vector3 (3.23f,0.89f,2f);
        transform.eulerAngles = new Vector3(17.688f,-40.595f,0);

        Camara.transform.position = Player.transform.position + _cameraOffset;
        /*Vector3 newPos= PlayerTransform.position+_cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);*/
     }   
    }
}
