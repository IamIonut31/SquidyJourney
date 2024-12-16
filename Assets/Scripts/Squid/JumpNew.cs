using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class JumpNew : PhysicsObject
{
    private Rigidbody2D rb;
    [SerializeField] private float jumpPower = 10;
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
            gravityModifier = 0f;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (!this.anim.GetCurrentAnimatorStateInfo(0).IsName("Jump"))
            {
                if (!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
                {
                    anim.SetTrigger("Jump");
                    SquidJump.Play();
                    gravityModifier = 0.55f;
                    velocity.y = jumpPower;
                    //rb.AddForce(new Vector2(0f, JumpForce), ForceMode2D.Force);
                }
            }
        }
    }

    public void RespawnJN()
    {
        velocity.y = 0;
        gravityModifier = 0;
    }
}
