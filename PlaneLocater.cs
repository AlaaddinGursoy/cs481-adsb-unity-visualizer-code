using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;
using TMPro;
using UnityEditor.Rendering;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class PlaneLocater : MonoBehaviour
{

    public float _enlem, _boylam;

    float speed = 1f;

    System.Random random = new System.Random();


    float counter = 0;



    private void Start()
    {
        _enlem = gameObject.transform.position.y / 3f * 90;
        _boylam = gameObject.transform.position.x / 6f * 180;
    }


    private void Update()
    {



        /*float pX = _boylam * 6f / 180;
        float pY = _enlem * 3f / 90;


        transform.position = new Vector3(pX, pY, 0);*/

        counter += Time.deltaTime;

        if (counter > 1)
        {
            //Instantiate(_plane, Vector3.zero, Quaternion.identity);
            UpdateLocation();
            counter = 0;
        }

        



    }

    /*private void TimerCallback(object state)
    {

        //speed is m/s

        _boylam -= speed/111000;



    }*/

    public void UpdateLocation()
    {


        
        _boylam += speed  * random.Next(-1,2);
        _enlem += speed  * random.Next(-1,2);



        float pX = _boylam * 6f / 180;
        float pY = _enlem * 3f / 90;


        transform.position = new UnityEngine.Vector3(pX, pY, 0);
    }

    

    


}
