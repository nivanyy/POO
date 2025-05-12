using UnityEngine;

public class Movimentodoinimigo : MonoBehaviour
{
    private GameObject _player;
    
    private Rigidbody _rigidBody;
    private float velocidade;

    public float realDivisao = 3;
    void Start()
    {
        velocidade = gameObject.GetComponent<inimigodoper>().Velocidade();
        _rigidBody = gameObject.GetComponent<Rigidbody>();
        
        
        _player = GameObject.FindWithTag("Player");
    }




    void Update()
    {
        if (Vector3.Distance(transform.position, _player.transform.position) < realDivisao)

        {
            transform.LookAt(_player.transform.position);
            transform.position = Vector3.MoveTowards(transform.position, _player.transform.position, velocidade * Time.deltaTime);
        }
    }
}
