

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    public Rigidbody a;
    public bool b;
    public bool c;
    public Transform d;
    public bool e;
    public Text t;
    public Text t2;
    int A;

    void Start()
    {
        t2.text = "find the key."&&"you can go outside with the key.";
        t.text = "I don't have key";
        b = true;
        c = true;
        e = true;
        A = 0;
        
    }

       void Update()
    {   
        if(A==0){ 
                       if (Input.GetKey(KeyCode.W)) { transform.Translate(0f, 0f, 0.025f); }
                       if (Input.GetKey(KeyCode.S)) { transform.Translate(0f, 0f, -0.025f); }
                       if (Input.GetKey(KeyCode.A)) { transform.Translate(-0.025f, 0f, 0f); }
                       if (Input.GetKey(KeyCode.D)) { transform.Translate(0.025f, 0f, 0f); }
                       }
        if(A==1){ 
                       if (Input.GetKey(KeyCode.W)) { transform.Translate(0f, 0f, 0.025f); }
                       if (Input.GetKey(KeyCode.S)) { transform.Translate(0f, 0f, -0.025f); }
                       if (Input.GetKey(KeyCode.A)) { transform.Translate(-0.025f, 0f, 0f); }
                       if (Input.GetKey(KeyCode.D)) { transform.Translate(0.025f, 0f, 0f); }
                       }
        if(Input.GetKey(KeyCood.space)){Instance(C,transform.position=A,transform.Rotate(0f,0f,0f));}
        if (Input.GetKey(KeyCode.W)) { transform.Translate(0f, 0f, 0.025f); }
        if (Input.GetKey(KeyCode.S)) { transform.Translate(0f, 0f, -0.025f); }
        if (Input.GetKey(KeyCode.A)) { transform.Translate(-0.025f, 0f, 0f); }
        if (Input.GetKey(KeyCode.D)) { transform.Translate(0.025f, 0f, 0f); }
        if (Input.GetKey(KeyCode.UpArrow)) { transform.Translate(0f, 0f, 0.025f); }
        if (Input.GetKey(KeyCode.DownArrow)) { transform.Translate(0f, 0f, -0.025f); }
        if (Input.GetKey(KeyCode.RightArrow)) { transform.Translate(-0.025f, 0f, 0f); }
        if (Input.GetKey(KeyCode.LehtArrow)) { transform.Translate(0.025f, 0f, 0f); }
        if (Input.GetKey(KeyCode.L)) { transform.Rotate(0f, 0.5f, 0f); }
        if (Input.GetKey(KeyCode.J)) { transform.Rotate(0f, -0.5f, 0f); }
        if (Input.GetKeyDown(KeyCode.Space) && b == true) { a.AddForce(0f, 2000f, 0f);b = false; }
        if (c == false) { t.text = "I have key"; }
        if (Input.GetKey(KeyCode.K) && c == false&&e== false) { d.position = new Vector3(5f, 3f, 11f); }
       
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "a") { b = true; }
        if (collision.gameObject.name == "Key") { c = false; }
        if (collision.gameObject.name == "Door") { e = false; }
        if (collision.gameObject.name == "Key") { c = false; }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.name == "Door") { e = true; }
    }
}
