using UnityEngine;

public class Zombie : MonoBehaviour
{


    [Header("血量")]
    public float HP = 50;
    [Header("攻擊力")]
    public float Atk = 10f;
    [Header("喇叭")]
    public AudioSource Aud;
    [Header("音效")]
    public AudioClip Sound_Atk;
    [Header("玩家")]
    public GameObject PLAYER;


    private void attack()
    {
       
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            print("殭屍攻擊");
            print(PLAYER);
            print("殭屍攻擊力:" + Random.Range(0f, Atk));
        }


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
