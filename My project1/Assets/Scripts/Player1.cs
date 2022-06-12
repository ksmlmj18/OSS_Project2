using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    private Rigidbody2D rigid2D;
    public GameObject G1;
    public GameObject G2;
    public GameObject G3;
    public GameObject G4;
    public GameObject G5;


    GameObject scanObject;
    public string[] sentences;
    public string[] sentence;

    bool ischange;

    private void Start()
    {
        G1.gameObject.SetActive(true);
        G3.gameObject.SetActive(true);
        G4.gameObject.SetActive(true);
        G5.gameObject.SetActive(true);

    }

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;

   


    }

  

    public void SetMoveSpeed(float speed)
    {
       moveSpeed = speed;
    }


    private void OnTriggerEnter2D(Collider2D colision)
    {
        if (colision.gameObject.tag == "Item")
        {
            Destroy(colision.gameObject);
        }

        else if (colision.tag == "Box")
        {
            G1.gameObject.SetActive(false);   
        }
        else if (colision.tag == "Box1")
        {
            G3.gameObject.SetActive(false);
        }
        else if (colision.tag == "Box2")
        {
            G4.gameObject.SetActive(false);
        }
        else if (colision.tag == "Box3")
        {
            G5.gameObject.SetActive(false);
        }

        else if (colision.tag == "Enemy")
        {
            G2.gameObject.SetActive(true);
        }

    }


}
