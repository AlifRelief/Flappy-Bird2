using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    [SerializeField] private float _maxTime = 2.5f; // Waktu antar pipe yang lebih normal
    [SerializeField] private float _heightRange = 0.45f;
    [SerializeField] private GameObject _pipe;
    private float _timer;
    
    // Start is called before the first frame update
    private void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (_timer > _maxTime)
        {
            SpawnPipe();
            _timer = 0;
        }
        _timer += Time.deltaTime;
    }
    
    private void SpawnPipe()
    {
        Debug.Log("Pipe Spawn");
        Vector3 spawnPos = transform.position + new Vector3(0, Random.Range(-_heightRange, _heightRange));
        GameObject pipe = Instantiate(_pipe, spawnPos, Quaternion.identity);
        Destroy(pipe, 10f);
    }
}
