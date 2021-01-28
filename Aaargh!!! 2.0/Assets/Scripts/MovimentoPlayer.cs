using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoPlayer : MonoBehaviour
{
    public float moveSpeed;

    public Rigidbody2D rb;

    Vector2 direction;

    void Start()
    {
        //falta colocar animação para fazer mudar o lado do personagem
    }

    void Update()
    {
        //Movimentação normal
        VerificaçãodeInputs();
    }

    void FixedUpdate()
    {
        //Calcular a fisica do rb
        Movimentorb();
    }

    void VerificaçãodeInputs()
    {
        float movX = Input.GetAxisRaw("Horizontal");
        float movY = Input.GetAxisRaw("Vertical");

        //Colocar o normalize para que quando movimentar em 
       //diagonal não ser mais rapido que nos vetores
        direction = new Vector2(movX, movY).normalized;
    }

    void Movimentorb()
    {
        rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);
    }
}
