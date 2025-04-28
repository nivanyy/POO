using UnityEngine;

public class inimigodoper : personagem
{

    private string armadura;
    private string arma;


    public void AtribuirArmadura(string armadura)
    {
        this.armadura = armadura;
    }
    
    
    public string Armadura()
    {
        return  this.armadura;
    }
    
    
    
    public void AtribuirArma(string arma)
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
            case "ESPADA":
                dano = Forca_Ataque() + 10;
                break;

            case "MACHADO":
                dano = Forca_Ataque() + 18;
                break;
            
            case "ADAGA":
                dano = Forca_Ataque() + 5;
                break;
        }

        return dano;
    }
}
