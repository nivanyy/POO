using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField]string nome;
    [SerializeField]private int energia;
    [SerializeField]private int forca_ataque;
    [SerializeField] private float forca_do_pulo;
    [SerializeField]private float velocidade;
    [SerializeField]private int numero_de_pes;
    [SerializeField]private int numero_de_maos;
    
    
    
    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }
    
    public string getNome()
    {
        return this.nome;
    }

    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public int Energia()
    {
        return this.energia;
    }
    
    public void AtribuirForca_Ataque(int ataque)
    {
        this.forca_ataque = ataque;
    }

    public int Forca_Ataque()
    {
        return this.forca_ataque;
    }


    public void Atribuirforca_do_pulo(float forca_do_pulo)
    {
        this.forca_do_pulo = forca_do_pulo;
    }

    public void AtribuirVelocidade(float velocidade)
    {
         this.velocidade = velocidade;
    }

public float Velocidade()
 

    {
        
        return this.velocidade;
    }


    public void AtribuirNumero_de_pes(int numero_de_pes)
    {
        this.numero_de_pes = numero_de_pes;
    }


    public void AtribuirNumero_de_maos(int numero_de_maos)
    {
        this.numero_de_maos = numero_de_maos;
    }
    
    
    public int Numero_de_maos()
    {
        return this.numero_de_maos;
    }
    
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
 