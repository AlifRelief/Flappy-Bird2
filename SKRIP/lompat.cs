using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

[DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
public class Lompat : MonoBehaviour
{
    [SerializeField] private float _velocity = 1.5f;
    [SerializeField] private float _rotationSpeed = 10f;

    private Rigidbody2D _rb;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        Hide();
        IsAlive = true;

        // Awal game di-pause sampai Start ditekan
        Time.timeScale = 0;
        gamePlayMenu.SetActive(true);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0))
        {
            _rb.linearVelocity = Vector2.up * _velocity;
        }
    }

    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, _rb.linearVelocity.y * _rotationSpeed);
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }

    public bool IsAlive = true;
    public GameObject gameOverMenu;
    public GameObject gamePlayMenu;

    public void Show()
    {
        gameOverMenu.SetActive(true);
    }

    public void Hide()
    {
        gameOverMenu.SetActive(false);
    }

    public void hideMainMenu()
    {
        gamePlayMenu.SetActive(false);
        Time.timeScale = 0;
    }

    public void StartGame()
    {
        gamePlayMenu.SetActive(false);
        Time.timeScale = 1;            
    }

    public void OnCollisionEnter2D(Collision2D collider)
    {
        IsAlive = false;
        Time.timeScale = 0;
        Show();
    }
    
}
