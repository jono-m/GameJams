using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnSpawn : MonoBehaviour
{
    public UnityEvent OnSpawnEvent;

    // Start is called before the first frame update
    void Start()
    {
        OnSpawnEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
