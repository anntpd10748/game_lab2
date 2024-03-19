using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class farmer : MonoBehaviour
{
    private Rigidbody2D rb;
    private float speed = 10f;
    private float facing = 1f;
    public float boundacy = 10f;
    public float time = 60;
    public Text cdText;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Countdown());
        rb = GetComponent<Rigidbody2D>();
    }
    IEnumerator Countdown()
    {
        while (time > 0)
        {
            yield return new WaitForSeconds(1);
            time--;
            cdText.text = "Time: " + time.ToString();
        }
        cdText.text = "......";
        Loadsence();
    }
    // Update is called once per frame
    void Update()
    {
        float moveinput = Input.GetAxis("Horizontal");
        Vector3 moveDirection = new Vector3(moveinput, 0, 0);
        transform.Translate(moveDirection * speed * Time.deltaTime);
        Vector3 currentPosition = transform.position;
        if (currentPosition.x < -boundacy)
        {
            currentPosition.x = -boundacy;
        }
        else if (currentPosition.x > boundacy)
        {
            facing = 1;
            currentPosition.x = boundacy;
        }
        if (Input.GetKey(KeyCode.A))
        {
            facing = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            facing = 1;
        }
        Vector3 newScale = transform.localScale;
        newScale.x = facing;
        transform.localScale = newScale;
        transform.position = currentPosition;
        
    }
    public void Loadsence()
    {
        int currentSenceIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSenceIndex + 1);

    }
}
