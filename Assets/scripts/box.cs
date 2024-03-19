using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class box : MonoBehaviour
{
    private Rigidbody2D rb2;
    private float speed2 = 10f;
    private float facing2 = 1f;
    public float boundacy2 = 10f;
    public Text sodiem;
    public int diem = 0;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveinput2 = Input.GetAxis("Horizontal");
        Vector3 moveDirection = new Vector3(moveinput2, 0, 0);
        transform.Translate(moveDirection * speed2 * Time.deltaTime);
        Vector3 currentPosition = transform.position;
        if (currentPosition.x < -boundacy2)
        {
            currentPosition.x = -boundacy2;
        }
        else if (currentPosition.x > boundacy2)
        {
            facing2 = 1;
            currentPosition.x = boundacy2;
        }
        if (Input.GetKey(KeyCode.A))
        {
            facing2 = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            facing2 = 1;
        }
        Vector3 newScale = transform.localScale;
        newScale.x = facing2;
        transform.localScale = newScale;
        transform.position = currentPosition;

    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("egg"))
        {
            diem++;
            sodiem.text = diem.ToString();
        }
    }
}
