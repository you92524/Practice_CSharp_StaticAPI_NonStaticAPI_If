using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("血量")]
    public float hp = 100;
    [Header("攻擊力")]
    public float atk;
    [Header("殭屍")]
    public Zombie zb;
    [Header("喇叭")]
    public AudioSource aud;
    [Header("音效")]
    public AudioClip soundAtk;

    private void Update()
    {
        Attack();
    }

    private void Attack()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            aud.PlayOneShot(soundAtk, 1);
            atk = Random.Range(10f, 30f);
            zb.Damage(atk);
        }
    }

    public void Damage(float dam)
    {
        hp -= dam;
        print("<color=blue>玩家受到傷害：" + dam + "</color>");
        print("<color=blue>玩家剩下血量：" + hp + "</color>");

        if (hp <= 0) Dead();
    }

    private void Dead()
    {
        print("<color=blue>玩家死亡</color>");
    }
}
