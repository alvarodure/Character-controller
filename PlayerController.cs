using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    //todos estos son variables
    public float horizontalMove;
    public float verticalMove;
    public CharacterController Player;
    public float speed;
    private Vector3 playerInput;

    // Start is called before the first frame update
    void Start()
    {
        //obtenemos el charactercontroller, y lo guardamos en player
        Player = GetComponent<CharacterController>();
    }
    //aca van todos los cálculos
    void Update()
    {
        // obtenemos los Axis (predefinidos) y los asignamos a las respectivas variables
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");
        playerInput = new Vector3 (horizontalMove,0,verticalMove);

        // Usamos la funcion Move
        // Player.Move(new Vector3(horizontalMove,0,verticalMove)* speed * Time.deltaTime);
        Player.Move(playerInput * speed * Time.deltaTime);

        Player.transform.LookAt(Player.transform.position+playerInput);

        // Debug.Log(Player.velocity.magnitude);
    }
    //FixedUpdate se usa para las físicas, llamadas a procedimientos
    // private void FixedUpdate() {
        
    // }
}
