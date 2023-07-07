using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DamageScript : MonoBehaviour
{
    public int damageAmount = 20;
    public GameObject destructBox;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Box")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("Box"));
        
        }
        if (other.tag == "Box2")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("Box2"));
        
        }
         if (other.tag == "Box3")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("Box3"));
        
        }
        if (other.tag == "Box4")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("Box4"));
        
        }
         if (other.tag == "Box5")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("Box5"));
        
        }
        if (other.tag == "Box6")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("Box6"));
        
        }
        if (other.tag == "7")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("7"));
        
        }
        if (other.tag == "8")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("8"));
        
        }
        if (other.tag == "9")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("9"));
        
        }
         if (other.tag == "10")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("10"));
        
        }
        if (other.tag == "11")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("11"));
        
        }
         if (other.tag == "12")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("12"));
        
        }
        if (other.tag == "13")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("13"));
        
        }
        if (other.tag == "14")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("14"));
        
        }
        if (other.tag == "15")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("15"));
        
        }
        if (other.tag == "16")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("16"));
        
        }
        if (other.tag == "17")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("17"));
        
        }
         if (other.tag == "18")
        {
            Instantiate(destructBox, transform.position, transform.rotation);
            Destroy(GameObject.FindWithTag("18"));
        
        }
    }
}
