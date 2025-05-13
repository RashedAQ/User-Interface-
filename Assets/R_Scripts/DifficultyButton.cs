using UnityEngine;
using UnityEngine.UI;

public class DifficultyButton : MonoBehaviour
{
     private Button button1;
   public int Difficulty;
    private GameManeger gameManeger;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        button1 = GetComponent<Button>();
        button1.onClick.AddListener(SetDifficulty);
        gameManeger = GameObject.Find("Game Manager").GetComponent<GameManeger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetDifficulty()
    {
        Debug.Log(button1.gameObject.name + "was clicked");
        gameManeger.StartGame(Difficulty);
    }
}
