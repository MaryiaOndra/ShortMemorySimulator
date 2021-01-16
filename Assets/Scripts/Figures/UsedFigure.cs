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
    private float speed = 0.02f;

    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        do
        {
            rigidbody.AddForce(Vector3.left * Time.deltaTime);
        }
        while (transform.position.x != 0);        
    }

    private void Update()
    {
        //if (transform.position.x != 0)
        //{
        //    rigidbody.AddForce(Vector3.left * speed * Time.deltaTime);
        //}

        if (transform.position.y < -5)
        {
            Deactivate();
            ResetPosition();
        }
    }

    public void Activate() 
    {
        gameObject.SetActive(true);
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
