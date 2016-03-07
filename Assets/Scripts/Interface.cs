using System;
using UnityEngine;


// Vector 3 


// interface that holds my "Inhearted Functions"
public interface IStats
{
    int health
    {
        get;
        set;
    }
}
public interface IAbilities
{
    void Stealth();
    void Health(int m_healthbar);
    void Movement(Vector3 s_move);

}

public class Ninja : MonoBehaviour, IAbilities, IStats
{
    private int m_health;
    public void Stealth()
    {
        Console.WriteLine(".... Shhhhhhh");
        return;
    }
    public void Health(int m_healthbar)
    {
        m_health = m_healthbar;
    }

    public void Movement(Vector3 s_move)
    {
        
    }

    public int health
    {
        get { return m_health; }
        set { m_health = value; }
    }
    
}
public class Duck : MonoBehaviour, IAbilities
{
    public void Stealth()
    {
        Console.WriteLine(".... Quack");
        return;
    }
}