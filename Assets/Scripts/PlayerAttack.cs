using System.Runtime.CompilerServices;
using UnityEngine;



public class PlayerAttack : MonoBehaviour
{
    
    [SerializeField] private float attackCooldown;
    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;
    private BoxCollider2D regHitbox;
    private BoxCollider2D heavyHitbox;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
        regHitbox = transform.Find("RegHitbox").GetComponent<BoxCollider2D>();
        heavyHitbox = transform.Find("HeavyHitbox").GetComponent <BoxCollider2D>();
    }

    private void Update()
    {
        if (Input.GetMouseButton(0) && cooldownTimer > attackCooldown && playerMovement.canAttack())
        {
            Attack();
            Invoke("ActivateHitbox", 0.2f);
            Invoke("DeactivateHitbox", 0.4f);
        }

        if (Input.GetMouseButton(1) && cooldownTimer > attackCooldown)
        {
            HeavyAttack();
            Invoke("ActivateHeavHitbox", 0.3f);
            Invoke("DeactivateHeavHitbox", 0.6f);
        }

        cooldownTimer += Time.deltaTime;
    }
            
    private void Attack()
    {
        anim.SetTrigger("attack");
        cooldownTimer = 0;
    }


    private void HeavyAttack()
    {
        anim.SetTrigger("heavyattack");
        cooldownTimer = 0;
    }

    void ActivateHitbox()
    {
        regHitbox.gameObject.SetActive(true);
    }

    void DeactivateHitbox()
    {
        regHitbox.gameObject.SetActive(false);
    }

    void ActivateHeavHitbox()
    {
        heavyHitbox.gameObject.SetActive(true);
    }

    void DeactivateHeavHitbox()
    {
        heavyHitbox.gameObject.SetActive(false);
    }
}


