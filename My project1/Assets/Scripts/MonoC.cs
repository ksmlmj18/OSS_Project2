using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoC : MonoBehaviour
{

    public Transform target;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * speed);
        transform.position = new Vector3(target.position.x, target.position.y, -10f);
    }


}
