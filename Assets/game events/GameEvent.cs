using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Game Event", menuName = "Game Events/New Game Event")]
public class GameEvent : ScriptableObject
{
    public List<IGameListener> gameEventListeners = new List<IGameListener>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Fire()
    {
        for (int i = 0; i < gameEventListeners.Count; i++)
        {
            gameEventListeners[i].Notify();
        }
    }
    public void RegisterListener(IGameListener gameEventListener)
    {
        if (gameEventListener == null)
            return;
        if (gameEventListeners.Contains(gameEventListener))
            return;
        gameEventListeners.Add(gameEventListener);
    }
    public void UnregisterListener(IGameListener gameEventListener)
    {
        if (gameEventListener == null)
            return;
        if (gameEventListeners.Contains(gameEventListener) == false)
            return;

        gameEventListeners.Remove(gameEventListener);
    }
}
