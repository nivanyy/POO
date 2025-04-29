using TMPro;
using UnityEngine;

public class teste : MonoBehaviour
{
    carro fusca = new carro();
    carro gol = new carro();
    
    caminhao caminhao = new caminhao();
    private personagem joao = new personagem();
    inimigodoper ork = new  inimigodoper();
    
    void Start()
    {
        fusca. AtribuirNome("Fusca da Ny");
        fusca.AtribuirCor("Verde");
        fusca.AtribuirNumero_de_rodas(4);
        fusca.AtribuirPreco(2050.90f);
        Debug.Log(" 0 " + fusca.NomeDoCarro() + " é " + fusca.CorDoCarro() +  "tem"  + fusca.Numero_de_rodas() +" e custa R$" + fusca.Preco());


        gol. AtribuirNome("Fusca de marie");
        gol.AtribuirCor("rosa");
        gol.AtribuirNumero_de_rodas(4);
        gol.AtribuirPreco(3000.90f);
        
        if (fusca.ComparePreco(fusca))
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + "é mais caro do que o carro " + gol.NomeDoCarro());
        }
        else
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + "é mais barato do que o carro " + gol.NomeDoCarro());
        }
        
        
        caminhao.AtribuirTipoDeCarroceria("Larga");
        caminhao.AtribuirNumero_de_rodas(8);
        caminhao.AtribuirPreco(6000.00f);
        caminhao.AtribuirCor("Azul");
        caminhao.AtribuirNome("Caminhão da nyny");
       
        
        //fusca.AtribuitTipoDeCarroceria("Larga");
        
        if (fusca.ComparePreco(caminhao))
            
            
            
            
            
            
            
            
            
            
            
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + "é mais caro do que o carro " + caminhao.NomeDoCarro());
        }
        else
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + "é mais barato do que o carro " + caminhao.NomeDoCarro());
        }

        
        

//=====================================================================

        joao.AtribuirNome(" João Roberto 11");
     joao.AtribuirEnergia(10); 
     joao.AtribuirForca_Ataque(12);
    joao.Atribuirforca_do_pulo(6);
    joao.AtribuirVelocidade(8);
    joao.AtribuirNumero_de_pes(2);
     joao.AtribuirNumero_de_maos(2);

        
     
     ork.AtribuirNome(" ork gob");
     ork.AtribuirEnergia(23); 
     ork.AtribuirForca_Ataque(15);
     ork.Atribuirforca_do_pulo(8);
     ork.AtribuirVelocidade(6);
     ork.AtribuirNumero_de_pes(2);
     ork.AtribuirNumero_de_maos(4);
     ork.AtribuirArma(inimigodoper.ArmaDoInimigo.MACHADO);
     ork.AtribuirArmadura(inimigodoper.ArmaduraDoInimigo.COURO);

     if (joao.Energia() > ork.Forca_Ataque())
     {
         Debug.Log("o joao sobreviveu ao ataque do ork" + joao.getNome());
     }

     else
     {
         Debug.Log("0" + joao.getNome() +  "aonde tem" + joao.Energia() + "energia");
     }
     
    }
    
    
    
    

    
    void Update()
    {
        
    }
}






