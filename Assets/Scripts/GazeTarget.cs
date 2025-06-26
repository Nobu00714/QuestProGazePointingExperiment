using UnityEngine;

public class GazeTarget : MonoBehaviour
{
    private Material material;
    private Color originalColor;

    // ハイライト時の色
    [SerializeField]
    private Color highlightColor = Color.yellow;

    void Start()
    {
        // オブジェクトのマテリアルを取得し、元の色を保存
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            material = renderer.material;
            originalColor = material.color;
        }
    }

    // 視線がオブジェクトに入ったときに呼び出されるメソッド
    public void OnGazeEnter()
    {
        if (material != null)
        {
            material.color = highlightColor;
        }
    }

    // 視線がオブジェクトから外れたときに呼び出されるメソッド
    public void OnGazeExit()
    {
        if (material != null)
        {
            material.color = originalColor;
        }
    }
}