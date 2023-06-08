using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject gameobject = new GameObject("Pipe", typeof(SpriteRenderer));
        gameobject.GetComponent<SpriteRenderer>().sprite = GameAssets.GetInstance().pipeHead;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
