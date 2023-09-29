using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ObjectSpawnScript : MonoBehaviour
{
    [SerializeField]
    GameObject spawnObject;

    [SerializeField]
    float cooldown = 1;

    float currentTime = 0;

    [SerializeField]
    float Speed;

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (currentTime > cooldown){
            currentTime = 0;
            var RedBall = Instantiate(spawnObject,transform.position,quaternion.identity) as GameObject ;
            RedBall.GetComponent<Rigidbody>().AddForce(transform.forward*Speed, ForceMode.Impulse);
        }
        
    }
}
