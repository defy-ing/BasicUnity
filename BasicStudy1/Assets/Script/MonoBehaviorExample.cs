using UnityEngine;

public class MonoBehaviorExample : MonoBehaviour
{
    
    void Start()
    {
        Debug.Log("게임이 시작될 때 호출됩니다");

    }

   
    void Update()
    {
        Debug.Log("Update: 프레임마다 호출됩니다.");

    }


    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate: 물리 연산에 사용됩니다");
    }

  
    //컨트롤 쉬트프 m -> 원하는 함수 찾을 때 좋음




}
