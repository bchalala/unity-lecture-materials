using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float speed;
    public int count;

    public Text countText;
    public Text winText;

    public Rigidbody rb;

    void Start ()
    {
        count = 0;
        rb = GetComponent<Rigidbody>();
        countText.text = "Count: " + count.ToString();
        winText.text = "";
    }

    void FixedUpdate ()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

        rb.AddForce (movement * speed);
    }

    void OnTriggerEnter(Collider other) 
    {
        if (other.gameObject.CompareTag ("Pick Up"))
        {
            other.gameObject.SetActive (false);
            count = count + 1;
            countText.text = "Count: " + count.ToString();

            if (count >= 3) {
                winText.text = "You Win!!!!1!";
            }
        }
    }
}
