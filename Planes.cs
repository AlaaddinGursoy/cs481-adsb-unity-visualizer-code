using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planes : MonoBehaviour
{
    float counter=0;

    System.Random rand = new System.Random();

    public GameObject _plane;
    List<GameObject> _planes;

    void Start()
    {
        //Instantiate(_plane,Vector3.zero,Quaternion.identity);
        _planes = new List<GameObject>();
        _planes.Add(Instantiate(_plane, new Vector3(rand.Next(-6, 7), rand.Next(-3, 4), 0), Quaternion.identity));
        
    }


    private void Update()
    {
        counter+=1*Time.deltaTime;

        if (counter > 10)
        {
            //Instantiate(_plane, Vector3.zero, Quaternion.identity);
            _planes.Add(Instantiate(_plane, new Vector3(rand.Next(-6, 7), rand.Next(-3, 4), 0), Quaternion.identity));

            counter = 0;
            Debug.Log("List Eleman Sayisi:"+_planes.Count);
        }
    }


}
