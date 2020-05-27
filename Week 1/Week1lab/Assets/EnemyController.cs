using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private PlayerController playerScript;
    private GameObject player;

    [Range(1f, 5f)] [SerializeField] private float moveSpeed = 2;
    private float step;

    private float distance;

    [Range(1f, 7f)] [SerializeField] private float stoppingDistance = 5f;
    
    public bool killedPlayer;

    private void Awake()
    {
        player = GameObject.Find("Player");
        playerScript = player.GetComponent<PlayerController>();
    }

    protected void Update()
    {
        FollowPlayer();
    }

    private void FollowPlayer()
    {
        transform.LookAt(player.transform);
        distance = Vector3.Distance(transform.position, player.transform.position);
        step = moveSpeed * Time.deltaTime;

        if (distance >= stoppingDistance)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.transform.position, step);
        }
        else
        {
            //function kill
            playerScript.killPlayer();
        }
    }
}
