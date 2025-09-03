using UnityEngine;
using UnityEngine.Video;

public class Enemy:MonoBehaviour
{
    public string nome;
    public float vida;
    public float speed;
    public float maxVida;
    public Transform target;

    private void Start()
    {
        vida = maxVida;
        Introduction();
    }

    void Introduction()
    {
        Debug.Log("O Nome � " + nome + 
                  "a vida �" + vida + 
                  "e o m�ximo de vida � " + maxVida);
    }
    
    void Move()
    {
        transform.position = Vector2.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime);
    }
}