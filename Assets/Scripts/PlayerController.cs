using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{

    private Rigidbody2D meuRB;
    [SerializeField] float velocidade = 5f;
    // Start is called before the first frame update
    void Start()
    {
        meuRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Pegando o input horizontal
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        Vector2 minhaVelocidade = new Vector2(horizontal, vertical);
        minhaVelocidade.Normalize();
        //Passando minha velocidade para o meu RB
        meuRB.velocity = minhaVelocidade * velocidade;
    }
}
