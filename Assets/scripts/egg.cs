using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class egg : MonoBehaviour
{
    public GameObject EggBroken;
    public GameObject Egg;
    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name.Equals("platform"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this,0.1f);
        }

        if (col.gameObject.name.Equals("box"))
        {
            Destroy(gameObject, 0.1f);
            Destroy(this);
        }
        if (col.gameObject.name.Equals("farmer"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
        if (col.gameObject.name.Equals("Egg"))
        {
            Instantiate(EggBroken, transform.position, Quaternion.identity);
            Destroy(gameObject, 0.1f);
            Destroy(this, 0.1f);
        }
    }
}
