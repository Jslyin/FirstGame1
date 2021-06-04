using UnityEngine;

public class TestScripts : MonoBehaviour
{

    [Header("Стороны Треугольника")]
    [SerializeField] private float a = 3f;
    [SerializeField] private float b = 3f;
    [SerializeField] private float c = 5f;
    private float perimetr = 0f;

    [Header("Обьем куба")]
    [SerializeField] private float a1 = 3f;
    private float volume  = 0f;

    void Start()
    {
        //вывод на консоль

        perimetr = (a + b + c );
        print("Стороны  " + perimetr);

        Debug.Log("Debug.Log");
        Debug.LogError("Debug.LogError");
        print("print");

        print(Mathf.Pow(a1, 3f));
        print("Обьем куба" + volume);



    }

    
    void Update()
    {
        
    }
}
