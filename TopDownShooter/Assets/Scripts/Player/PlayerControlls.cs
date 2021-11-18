using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControlls : MonoBehaviour
{
    [Header("Controll settings")]
    public float speed;

    private Vector2 direction;

    private void Start()
    {
        OnStart();
    }

    private void Update()
    {
        float _xMov = Input.GetAxis("Horizontal");
        float _yMov = Input.GetAxis("Vertical");

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePos - (Vector2)transform.position).normalized;
        transform.up = direction;

        Vector3 velocity = new Vector3(_xMov, _yMov, 0f);

        transform.position += velocity * speed * Time.deltaTime;

        OnUpdate();
    }

    protected virtual void OnStart() 
    {

    }

    protected virtual void OnUpdate() 
    {
       
    }

    public Vector2 GetDirection()
    {
        return direction;
    }
}
