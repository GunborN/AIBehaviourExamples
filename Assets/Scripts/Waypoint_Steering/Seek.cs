using UnityEngine;
using System.Collections;

public class Seek : MonoBehaviour
{
    private GameObject player;
    private Vector3 targetPosition;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        targetPosition = Vector3.zero;
    }

    void Update()
    {
        targetPosition = player.transform.position;
        Vector3 newPosition = Vector3.MoveTowards(transform.position, player.transform.position, 3f * Time.deltaTime);
        transform.position = newPosition;
    }
}
