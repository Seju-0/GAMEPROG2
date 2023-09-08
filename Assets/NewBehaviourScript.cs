using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public Renderer rend;
    public Color[] colors;
    public Vector3 positon;
    public float speed;
    public Transform pointA, pointB;
    public float radius;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        transform.position = Vector3.forward;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * speed * Time.deltaTime);
        //transform.position = Vector3.Lerp(pointA.position, pointB.position, speed * Time.time);
        //transform.position = Vector3.MoveTowards(pointA.position, pointB.position, speed * Time.time);
        float dist = Vector3.Distance(transform.position, pointA.position);
        Debug.Log(dist);
    }

    private void OnEnable()
    {
        //rend.material.color = colors[Random.Range(0, colors.Length)];
    }

    void OnMouseDown()
    {
        //rend.material.color = colors[Random.Range(0, colors.Length)];
    }
    void OnMouseEnter()
    {
        rend.material.color = colors[Random.Range(0, colors.Length)];
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);

    }
}
