using System;
using UnityEngine;

public class TESTEDODANO : MonoBehaviour
{
    Personagem personagem = new Personagem();
    private void OnCollisionEnter(Collision colisao)
    {
        if (colisao.gameObject.tag == "Inimigo")
        {
            int energia_atual = personagem.Energia() - colisao.gameObject.GetComponent<inimigodoper>().DanoDoInimigo();



            personagem.AtribuirEnergia(energia_atual);
            
            Debug.Log("O personagem " + personagem.getNome()+"tem agora" + personagem.Energia() );
        }
            
    }


    private void Start()
    {
        personagem = GetComponent < Personagem>();
    }
}
