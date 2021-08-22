using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyTargets : MonoBehaviour
{
    public GameObject[] enemyList;
    public static EnemyTargets instance;
    public int randEnemy;
    public string EnemyName;
    public Text targetText;

    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        randEnemy = Random.Range(0, enemyList.Length);
        enemyList[randEnemy].tag = "Enemy";
        EnemyName = enemyList[randEnemy].name;
        
        print(EnemyName);

        if (EnemyName == "Enemy1")
        {
            print("Target: Grey Hair Girl with yellow and grey drees color");
            targetText.text = "Target: Grey Hair Girl with yellow and grey drees color";
        }
        else if (EnemyName == "Enemy2")
        {
            print("Target: Grey Hair Boy with yellow and grey drees color");
            targetText.text = "Target: Grey Hair Boy with yellow and grey drees color";
        }
        else if (EnemyName == "Enemy3")
        {
            print("Target: Black Hair Boy with Green and grey drees color");
            targetText.text = "Target: Black Hair Boy with Green and grey drees color";
        }
        else if (EnemyName == "Enemy4")
        {
            print("Target: Black Hair Girl with yellow and grey drees color");
            targetText.text = "Target: Black Hair Girl with yellow and grey drees color";
        }
        else if (EnemyName == "Enemy5")
        {
            print("Target: Black Hair Girl with Green and grey drees color");
            targetText.text = "Target: Black Hair Girl with Green and grey drees color";
        }
        else if (EnemyName == "Enemy6")
        {
            print("Target: white Hair Boy with yellow and grey drees color");
            targetText.text = "Target: white Hair Boy with yellow and grey drees color";
        }
        else if (EnemyName == "Enemy7")
        {
            print("Target: White Hair Boy with Green and grey drees color");
            targetText.text = "Target: White Hair Boy with Green and grey drees color";
        }
        else if (EnemyName == "Enemy8")
        {
            print("Target: White Hair Boy with Green and grey drees color");
            targetText.text = "Target: White Hair Boy with Green and grey drees color";
        }
        else if (EnemyName == "Enemy9")
        {
            print("Target: Grey Hair Girl with yellow and grey drees color");
            targetText.text = "Target: Grey Hair Girl with yellow and grey drees color";
        }

    }

    // Update is called once per frame
    void Update()
    {

      

    }

    
        
}
