using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScroll : MonoBehaviour
{
    public float speed = 0f;
    public float rotationAngle = 1f;
    Vector3 maxPos = new Vector3();

    private void Awake()
    {
        maxPos = new Vector3(GetComponent<SpriteRenderer>().bounds.size.x / 2, GetComponent<SpriteRenderer>().bounds.size.x / 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = new Vector3(Time.deltaTime * speed, Time.deltaTime * speed, 0);
        this.gameObject.transform.position += offset;
        this.gameObject.transform.Rotate(new Vector3(0f,0f,rotationAngle*Time.deltaTime));
        if (Vector3.Distance(this.transform.position, maxPos) < 5f)
        {
            this.gameObject.transform.position = new Vector3(-17.5f, -5.5f, 0);
        }
    } 
}
