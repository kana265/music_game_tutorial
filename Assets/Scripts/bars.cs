using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bars : MonoBehaviour
{
    [SerializeField] private float Speed = 3;//透明度が減少する速度

    [SerializeField] private int num = 0;//どのキーを押したか

    private Renderer rend;//Rendererコンポーネントを参照する変数。マテリアルの色を変更する

    private float alfa = 0; //マテリアルの色の透明度。0が完全に透明,1が完全に不透明
    
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();//Rendererコンポーネントを取得してrendに保存
    }

    // Update is called once per frame
    void Update()
    {
        if (!(rend.material.color.a <= 0 ))//オブジェクトが完全に透明でないならば
        {
            rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, alfa);
        }
        if (num == 1)//４レーン分
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                colorChange();
            }
        }
        if (num == 2)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                colorChange();
            }
        }
        if (num == 3)
        {
            if (Input.GetKeyDown(KeyCode.J))
            {
                colorChange();
            }
        }
        if (num == 4)
        {
            if (Input.GetKeyDown(KeyCode.K))
            {
                colorChange();
            }
        }

        alfa -= Speed * Time.deltaTime;
    }

    void colorChange()
    {
        //マテリアルで設定されている色はそのままに透明度だけを変更する、(RGB値はそのまま)
        alfa = 0.3f;
        rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, alfa);
        
    }
}
