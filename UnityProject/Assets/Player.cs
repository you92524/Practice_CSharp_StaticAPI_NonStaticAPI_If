using UnityEngine.UI;
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
    [Header("攻擊")]
    public float x ;


    public void attack()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            x = Random.Range(0f, Atk);
            print("玩家攻擊");
            print("玩家攻擊力:" + x);
            
        }
        

    }

    public void Playerhurt()
    {
        if(ZB.a)

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
