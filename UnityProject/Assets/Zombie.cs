using UnityEngine;

public class Zombie : MonoBehaviour
{
    [Header("血量")]
    public float hp = 50;
    [Header("攻擊力")]
    public float atk;
    [Header("玩家")]
    public Player player;
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
        if (Input.GetKeyDown(KeyCode.B))
        {
            aud.PlayOneShot(soundAtk, 1);
            atk = Random.Range(30f, 50f);
            player.Damage(atk);
        }
    }

    public void Damage(float dam)
    {
        hp -= dam;
        print("<color=red>殭屍受到傷害：" + dam + "</color>");
        print("<color=red>殭屍剩下血量：" + hp + "</color>");

        if (hp <= 0) Dead();
    }

    private void Dead()
    {
        print("<color=red>殭屍死亡</color>");
    }
}
