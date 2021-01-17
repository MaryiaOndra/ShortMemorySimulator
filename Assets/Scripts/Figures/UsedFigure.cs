using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Rigidbody))]
public class UsedFigure : MonoBehaviour
{
    public Color color { get; set; }
    public GameObject prefab { get; set; }
    public float rotation { get; set; }

    private Rigidbody rigidbody;
    private float speed = 100f; 

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Debug.Log("UpdateRB" + rigidbody.position.x);

        if(rigidbody.position.x > 0)
        {
            rigidbody.AddForce(Vector3.left * Time.deltaTime * speed, ForceMode.Force);
        }
        
        if (rigidbody.position.y < -5)
        {
            Deactivate();
            ResetPosition();
        }
    }

    private void MoveToMiddlePoint() 
    {
        if (rigidbody.position.x >= 0)
        {
            rigidbody.AddForce(Vector3.left * Time.deltaTime * speed, ForceMode.Force);
            Debug.Log(rigidbody.position);
        }
    }

    public void Activate() 
    {
        gameObject.SetActive(true);
        Debug.Log("Activate" + rigidbody.position);
    }

    public void DropDown() 
    {
        rigidbody.isKinematic = false;
        rigidbody.useGravity = true;
    }

    public void Deactivate()
    {
        gameObject.SetActive(false);
    }


    public void ResetPosition() 
    {
        transform.position = transform.parent.position;
    }
}
