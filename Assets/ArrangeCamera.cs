using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrangeCamera : MonoBehaviour
{
    public Transform target;
    public Transform left, right, up, down;

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Mathf.Abs(left.position.x - target.position.x) < 2f)
        {
            transform.position = Vector3.Slerp(transform.position, transform.position - new Vector3(5f, 0), 1f * Time.deltaTime);
        }
        if (Mathf.Abs(right.position.x - target.position.x) < 2f)
        {
            transform.position = Vector3.Slerp(transform.position, transform.position + new Vector3(5f, 0), 1f * Time.deltaTime);
        }
        if (Mathf.Abs(up.position.y - target.position.y) < 2f)
        {
            transform.position = Vector3.Slerp(transform.position, transform.position + new Vector3(0, 5f), 1f * Time.deltaTime);
        }
        if (Mathf.Abs(down.position.y - target.position.y) < 2f)
        {
            transform.position = Vector3.Slerp(transform.position, transform.position - new Vector3(0, 5f), 1f * Time.deltaTime);
        }
    }
}
