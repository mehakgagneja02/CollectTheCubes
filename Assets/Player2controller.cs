using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Player2controller : MonoBehaviour
{
    public KeyCode left = KeyCode.LeftArrow;
    public KeyCode right = KeyCode.RightArrow;
    public KeyCode forward = KeyCode.UpArrow;
    public KeyCode back = KeyCode.DownArrow;
    public int speed;
    public Rigidbody rb;
    public int count1;
    public Text Count1;
    public Text WinText1;
    private void Start()
    {
        count1 = 0;
         WinText1.text = "";
    }
    private void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(left))
            rb.AddForce(Vector3.left * speed);
        if (Input.GetKey(right))
            rb.AddForce(Vector3.right * speed);
        if (Input.GetKey(forward))
            rb.AddForce(Vector3.forward * speed);
        if (Input.GetKey(back))
            rb.AddForce(Vector3.back * speed);

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Collect"))
        {
            other.gameObject.SetActive(false);
            count1 = count1 + 1;
            SetCount1();
        }
    }
    void SetCount1()
    {
        Count1.text = "Player 2: " + count1.ToString();
        if (count1 >= 6)
        {
            WinText1.text = "Player 2 Wins";
        }
        
    }
}
