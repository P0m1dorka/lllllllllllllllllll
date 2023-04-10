using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class DvizhTrub : MonoBehaviour
{
    [SerializeField] private float speed;
    // Update is called once per frame
    void Update()
    {
        speed = 5f;
        transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
