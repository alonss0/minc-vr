using System.Collections;
using UnityEngine;
using UnityEngine.AI;
public class AgentController : MonoBehaviour
{
    public Transform target1;
    public Transform target2;
    public Transform target3;
    public Animator dogAnimator;

    private bool movingTo1;
    private bool movingTo2;
    private bool movingTo3;
    private NavMeshAgent dogAgent;
    // Start is called before the first frame update
    void Start()
    {
        dogAgent = GetComponent<NavMeshAgent>();
        movingTo1 = false;
        movingTo2 = false;
        movingTo3 = false;
    }

    // Update is called once per frame
    void Update()
    {
        // Perrito en Idle
        dogAnimator.SetBool("move", false);
        if (movingTo1)
        {
            moveToTarget1(target1);
        }
        if (movingTo2)
        {
            moveToTarget2(target2);
        }
        if (movingTo3)
        {
            moveToTarget3(target3);
        }
    }

    public void moveToTarget1(Transform target)
    {
        movingTo1 = true;
        if (ReferenceEquals(target, target1))
        {
            dogAnimator.SetBool("move", true);
            dogAgent.SetDestination(target.position);
        }
    }

    public void moveToTarget2(Transform target)
    {
        movingTo2 = true;
        if (ReferenceEquals(target, target2))
        {
            dogAnimator.SetBool("move", true);
            dogAgent.SetDestination(target.position);
        }
    }

    public void moveToTarget3(Transform target)
    {
        movingTo3 = true;
        if (ReferenceEquals(target, target3))
        {
            dogAnimator.SetBool("move", true);
            dogAgent.SetDestination(target.position);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("mTarget1"))
        {
            dogAnimator.SetBool("move", false);
            movingTo1 = false;
            dogAnimator.SetBool("girar", true);
        }
        if (other.gameObject.CompareTag("mTarget2"))
        {
            dogAnimator.SetBool("move", false);
            movingTo2 = false;
        }
        if (other.gameObject.CompareTag("mTarget3"))
        {
            dogAnimator.SetBool("move", false);
            movingTo3 = false;
        }
    }
}
