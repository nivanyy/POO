using UnityEngine;

public class inimigodoper : MonoBehaviour
{

    private string armadura;
    private string arma;


    public void AtribuirArmaura()
    {
        this.armadura = armadura;
    }
    
    
    public string Armadura()
    {
        return armadura;
    }
    
    
    
    public void AtribuirArma()
    {
        this.arma = arma;
    }
    
    
    public string Arma()
    {
        return arma;
    }


    public int DanoDoInimigo()
    {
        int dano = 0;

        switch (arma)
        {
            case "ESPADA"
                dano = Forca_Ataque() + 10;
                break;
            
            casr "MACHADO";
                dano = Forca_Ataque() + 18;
                break;
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
