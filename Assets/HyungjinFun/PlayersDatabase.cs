using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class PlayersDatabase
{
    [SerializeField]
    private List<Player> m_activePlayers = new();
    [SerializeField]
    private List<Player> m_inactivePlayers = new();
    
    public List<Player> GetActivePlayers()
    {
        JsonUtility.ToJson(this);
        return m_activePlayers;
    }

    public List<Player> GetInactivePlayers()
    {
        return m_inactivePlayers;
    }
}

[Serializable]
public class Player
{
    public string GUID;
    public string Name;
    public PlayerStats Stats;
}

[Serializable]
public class PlayerStats
{
    public int Strength;
    public int Intelligence;
    public int Dexterity;

}