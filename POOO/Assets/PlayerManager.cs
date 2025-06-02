using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    private  Movimentodopersonagem movimentoPlayer;
    public float velocidadeDaAnimacao = 1;
    
    void Start()
    {
        movimentoPlayer = GetComponent<Movimentodopersonagem>();
    }
    void Update()
    {
        animator.SetBool("Andando", movimentoPlayer.andando);
        animator.speed = velocidadeDaAnimacao;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Ataque");  
        }
    }
}