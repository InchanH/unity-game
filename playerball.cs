using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playerball : MonoBehaviour
{
    Rigidbody rigid;
    public int itemCount;
    public float jumpPower;
    bool isJump;
    AudioSource audio;
    public GameManger manager;
    private void Awake()
    {
        audio = GetComponent<AudioSource>();
        isJump = false;
        rigid = GetComponent<Rigidbody>();       
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump") && !isJump )
        {
            isJump = true;
            rigid.AddForce(new Vector3(0,jumpPower,0),ForceMode.Impulse);

        }
    }
    void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        rigid.AddForce(new Vector3(h, 0, v),ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isJump = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Item")
        {
            
            itemCount++;
            audio.Play();
            other.gameObject.SetActive(false);
            manager.GetItem(itemCount);
        }
    
        else if(other.tag == "Point")
        {

            if(itemCount== manager.TotalItemCount)
            {
                SceneManager.LoadScene(manager.stage+1);
                
            }
            else
            {
                SceneManager.LoadScene(manager.stage); //.¿ÁΩ√¿€
            }
        }
    
    
    
    }
}
