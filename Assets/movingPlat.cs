using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingPlat : MonoBehaviour
{
    [SerializeField] GameObject[] MovingPlat;
    int currentMovingPlatIndex = 0;

    [SerializeField] float speed = 1f;

    void Update()
    {
        if (Vector3.Distance(transform.position, MovingPlat[currentMovingPlatIndex].transform.position) < 0.1f)
        {
            currentMovingPlatIndex++;
            if (currentMovingPlatIndex >= MovingPlat.Length)
            {
                currentMovingPlatIndex = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, MovingPlat[currentMovingPlatIndex].transform.position, speed * Time.deltaTime);

    }
}