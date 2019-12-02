
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("血量")]
    public float HP = 50;
    [Header("攻擊力")]
    public float Atk = 20f;
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip Sound_Atk;
    [Header("殭屍")]
    public GameObject ZB;

    private void attack()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("玩家攻擊");
            print("玩家攻擊力:" + Random.Range(0f, Atk));
        }
        

    }

    private void Playerhurt()
    {
        

    }




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        attack();
    }
}
