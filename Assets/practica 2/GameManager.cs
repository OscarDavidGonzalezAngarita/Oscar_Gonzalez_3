using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameState currentGameState = GameState.Menu;
    static GameManager Gm;

    private void Awake()
    {
        Gm = this;
    }
    public static GameManager GetInstance()
    {
        return Gm;
    }
    public enum GameState
    {
        Menu,
        InGame,
        GameOver,
    }
    public void ChangeGameEstate(GameState NewGameState)
    {
        switch(NewGameState)
        {
            case GameState.Menu:
                //loadMenu
                break;
            case GameState.InGame:
                //loadScene(0)
                break;
            case GameState.GameOver:
                //loadMenu
                break;
            default:
                currentGameState = GameState.Menu;
                break;
        }
    }
    public void StartGame()
    {
        ChangeGameEstate(GameState.InGame);
    }
    public void GameOver()
    {
        ChangeGameEstate(GameState.GameOver);
    }
    public void BackToMainMenu()
    {
        ChangeGameEstate(GameState.Menu);
    }
}
