using UnityEngine;

public class TestScripts : MonoBehaviour
{

    [Header("������� ������������")]
    [SerializeField] private float a = 3f;
    [SerializeField] private float b = 3f;
    [SerializeField] private float c = 5f;
    private float perimetr = 0f;

    [Header("����� ����")]
    [SerializeField] private float a1 = 3f;
    private float volume  = 0f;

    void Start()
    {
        //����� �� �������

        perimetr = (a + b + c );
        print("�������  " + perimetr);

        Debug.Log("Debug.Log");
        Debug.LogError("Debug.LogError");
        print("print");

        print(Mathf.Pow(a1, 3f));
        print("����� ����" + volume);



    }

    
    void Update()
    {
        
    }
}
