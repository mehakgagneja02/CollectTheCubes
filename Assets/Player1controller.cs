using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player1controller : MonoBehaviour
{
    public KeyCode A = KeyCode.A;
    public KeyCode D = KeyCode.D;
    public KeyCode W = KeyCode.W;
    public KeyCode S = KeyCode.S;
    public int speed;
    public Rigidbody rb;
    public int count;
    public Text Count;
    public Text WinText;
    private void Start()
    {
        count = 0;
       WinText.text = "";


    }
    private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(A))
            rb.AddForce(Vector3.left * speed);
        if (Input.GetKey(D))
            rb.AddForce(Vector3.right * speed);
        if (Input.GetKey(W))
            rb.AddForce(Vector3.forward * speed);
        if (Input.GetKey(S))
            rb.AddForce(Vector3.back*speed);

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collect"))
        {
            other.gameObject.SetActive(false);
            count =count + 1;
            SetCount();
        }
    }
    void SetCount()
    {
        Count.text = "Player 1: " + count.ToString();
        if (count >= 6)
        {
            WinText.text = "Player 1 Wins";
        }
        
    }
}
