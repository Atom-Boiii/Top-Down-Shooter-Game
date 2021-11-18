using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [Header("Enemy Movement Settings")]
    public Transform target;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;

        OnStart();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = target.position - transform.position;

        transform.Translate(direction.normalized * speed * Time.deltaTime);

        OnUpdate();
    }

    protected virtual void OnStart() 
    { 
    
    }
    protected virtual void OnUpdate() 
    {

        
    }
}
