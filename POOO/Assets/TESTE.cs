using UnityEngine;

public class teste : MonoBehaviour
{
    carro fusca = new carro();
    carro gol = new carro();
    
    caminhao caminhao = new caminhao();
    
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
       
        if (fusca.ComparePreco(caminhao))
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + "é mais caro do que o carro " + caminhao.NomeDoCarro());
        }
        else
        {
            Debug.Log("O carro " + fusca.NomeDoCarro() + "é mais barato do que o carro " + caminhao.NomeDoCarro());
        }


        
    }
    

    
    

    
    void Update()
    {
        
    }
}