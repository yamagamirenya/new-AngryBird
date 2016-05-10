using UnityEngine;
using System.Collections;
using System;

public class Spring : MonoBehaviour
{

    private Vector3 currentPosition;
    private Vector3 screenPoint;
    private Vector3 offset;
    public float x_first, y_first;
    public int k;

    GameObject MainCamera;


    public void Start()
    {

        x_first = transform.position.x;
        y_first = transform.position.y;


    }

    void OnMouseDown()
    {
        this.screenPoint = Camera.main.WorldToScreenPoint(transform.position);
        this.offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {

        Vector3 currentScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        Vector3 currentPosition = Camera.main.ScreenToWorldPoint(currentScreenPoint) + this.offset;
        transform.localPosition = currentPosition;
    }

    void OnMouseUp()
    {
        

        float x = this.transform.position.x - x_first;
        float y = this.transform.position.y - y_first;
        Vector3 to = new Vector3(x_first - transform.position.x, y_first - transform.position.y, 0);
        float z = to.magnitude;
        this.GetComponent<Rigidbody>().AddForce(to * z * k);
    }

    public float Norm(float x, float y)
    {
        float N = Mathf.Sqrt(Mathf.Pow(x, 2) + Mathf.Pow(y, 2));
        return N;
    }

}
