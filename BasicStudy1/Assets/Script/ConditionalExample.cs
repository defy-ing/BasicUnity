using UnityEngine;

public class ConditionalExample : MonoBehaviour
{
    //�����ڿ� ���ǹ�

    public int health = 100;
   
    
    void Update()
    {
        health = -1;//ü�� ���� 

        Debug.Log("Health: " + health);

        //���ǹ�
        if(health<0)
        {
            Debug.Log("Game Over!");
        }
    }
}
