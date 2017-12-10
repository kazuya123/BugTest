using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    //private Animator animator;
    private Rigidbody rigid;
    public float jumpFoce;

	// Use this for initialization
	void Start () {
        this.rigid = GetComponent<Rigidbody>();
       // this.animator = GetComponent<Animator>();
       // this.animator.SetFloat("FW", 1);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(0.005f, 0, 0);
            transform.localScale = new Vector3(-1, 1, 1);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(-0.005f, 0, 0);
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            this.rigid.AddForce(transform.up * this.jumpFoce);
        }
    }
}
