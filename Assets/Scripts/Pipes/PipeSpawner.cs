using System.Collections;
using UnityEngine;

namespace FlappyBird.Pipes
{
    public class PipeSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _pipePrefab;
        [SerializeField] private float _spawnRate = 2f;
        [SerializeField] private float _heightOffset = 2f;

        private bool _isPausable = true;

        private void Start()
        {
            StartCoroutine(PipeSpawn());
        }

        private IEnumerator PipeSpawn()
        {
            while (_isPausable)
            {
                float randomY = Random.Range(-_heightOffset, _heightOffset);

                Vector3 spawnPosition = new Vector3(transform.position.x, randomY, transform.position.z);

                Instantiate(_pipePrefab, spawnPosition, Quaternion.identity);

                yield return new WaitForSeconds(_spawnRate);
            }
        }
    }
}

