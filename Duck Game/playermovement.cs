using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour
{
    public float movespeed=5f;
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sp;
    private enum movementstate{player,running}
    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        anim=GetComponent<Animator>();
        sp=GetComponent<SpriteRenderer>();
    }
   
    public void update()
    {
        float movex =SimpleInput.GetAxis("Horizontal");
        {
            rb.velocity=new Vector2(movex*movespeed,rb.velocity.y);
        }

       
    }
    public void left()
    {
        rb.velocity=new Vector2(-movespeed,rb.velocity.y);
      updateanimstate();  
    }
     
    public void right()
    {
        rb.velocity=new Vector2(movespeed,rb.velocity.y);
        updateanimstate();
    }
    public void idle(){
        rb.velocity=new Vector2(rb.velocity.x,rb.velocity.y);
        updateanimstate();
    }
   public void  updateanimstate()
   {
         movementstate state;
         if(rb.velocity.x>2f)
         {
            
            state=movementstate.running;
            sp.flipX=true;
         }else if(rb.velocity.x<-2f)
         {
           
            state=movementstate.running;
             sp.flipX=false;
         }
         else{
            state=movementstate.player;
         }
         anim.SetInteger("state",(int)state);
   }
   private void OnCollisionEnter2D(Collision2D collision)
   {
    if(collision.gameObject.tag =="enemy")
    {
      Invoke ("restartlevel",0.5f);
   }
   }
   private void restartlevel()
   { 
       SceneManager.LoadScene("Game");
   }
}
