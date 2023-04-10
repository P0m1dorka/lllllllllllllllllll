using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Pipes;
    void Start()
    {
        StartCoroutine(PipesSpawner());
    }

    // Update is called once per frame
    IEnumerator PipesSpawner()
    {
        while(true)
        {
            yield return new WaitForSeconds(2);
            float rand = Random.Range(5.39f, -1.75f);
            GameObject newPipes = Instantiate(Pipes, new Vector2(4,rand), Quaternion.identity);
            Destroy(newPipes,3);
        }
    }
}
