using UnityEngine;

public class LoopExample : MonoBehaviour
{
    
    void Start()
    {
        //for�� : 1���� 10���� ���

        /* for (int i=1; i<=10; i++)
         {
             Debug.Log("Count" + i);
         }*/

        int Counter = 0;
        while (Counter<5)
        {
            Debug.Log("While Count: " + Counter);
            Counter++;
        }


    }

    
    
}
