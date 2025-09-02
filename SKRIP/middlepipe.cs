using UnityEngine;

public class middlepipe : MonoBehaviour
{
    private ScoreSystem scoreSystem;

    void Start()
    {
        // cari ScoreManager
        scoreSystem = GameObject.FindGameObjectWithTag("ScoreManager").GetComponent<ScoreSystem>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Triggered by: " + collision.name);

        if (collision.CompareTag("Player"))
        {
            scoreSystem.AddScore();
            Debug.Log("Score Added!");
        }
    }
}
