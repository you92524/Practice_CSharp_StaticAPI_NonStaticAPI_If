using UnityEngine.UI;
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
    [Header("攻擊")]
    public float y ;



    private void attack()
    {
       
        
        if (Input.GetKeyDown(KeyCode.B))
        {
            y = Random.Range(0f, Atk);
            print("殭屍攻擊");
            print("殭屍攻擊力:" + y);
        }


    }
    public void ZBhurt()
    { 
        //HP=HP-
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
