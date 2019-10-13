using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private GameObject hook;

    Rigidbody2D rb;
    GameObject player;
    Vector2 hookPos;
    Vector2 playerPos;

    int speed = 50;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        PlayerControl();
    }
    
    private void PlayerControl()
    {
        /* if (Input.GetMouseButton(0))
        {
            HookFire();
        }
        */
        float moveHorizontal = Input.GetAxis("Horizontal");
       // float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb.AddForce(movement * speed) ;
    }
    
    private void HookFire()
    {   
           // int hookSpeed = 5;
            hook = Instantiate(hook); //Создаем
            playerPos = player.transform.position; // координаты игрока
            hook.transform.position = playerPos; //Начальные кординаты хука
            hookPos = Camera.main.ScreenToWorldPoint(Input.mousePosition); //Куда лететь
            hook.GetComponent<TargetJoint2D>().target = hookPos;
           // hook.target = hookPos;
    }
    
}
