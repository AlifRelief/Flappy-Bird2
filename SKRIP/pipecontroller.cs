using UnityEngine;

public class pipecontroller : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    [SerializeField] private float _speed = 2f;
    void Update()
    {
        transform.position += Vector3.left * _speed * Time.deltaTime ;
    }
}
