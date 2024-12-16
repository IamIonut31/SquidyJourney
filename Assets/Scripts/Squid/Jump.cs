using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Jump : MonoBehaviour
{
    private Rigidbody2D rb;
    public float JumpForce = 0;
    public Animator anim;
    [SerializeField] private AudioSource SquidJump;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.anim.GetCurrentAnimatorStateInfo(0).IsName("Idle"))
        {
            rb.gravityScale = 0.05f;
        }
        if(Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (!this.anim.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
            {
                if(!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    anim.SetTrigger("Jump");
                    SquidJump.Play();
                    rb.gravityScale = 0.5f;
                    rb.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Force);
                }
            }
        }
    }
}
