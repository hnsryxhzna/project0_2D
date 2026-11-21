using UnityEngine;
using UnityEngine.SceneManagement;

public class logic_manager : MonoBehaviour
{

    public int player_score;

    public TextMesh score;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("Increase Score")]
    public void add_score(int score_to_add)
    {
        player_score += score_to_add;
        score.text = player_score.ToString();
    }

    public void restart_game()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
