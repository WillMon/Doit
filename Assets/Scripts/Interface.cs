using System;
using UnityEngine;
using System.Collections.Generic;


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
    int Health(int m_healthbar);
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
    public int Health(int m_healthbar)
    {
        health = m_healthbar;
        return health;
    }

    public void  Movement(Vector3 s_move)
    {
        Vector3 MovementTracker = new Vector3();
        Vector3 Collision = new Vector3();

        MovementTracker.x = s_move.x - Time.deltaTime;
        MovementTracker.y = s_move.y - Time.deltaTime;
        MovementTracker.z = s_move.z - Time.deltaTime;
        if (MovementTracker == Collision)
        {
            Console.WriteLine("They Have Collided");
        }
    }

    public int health
    {
        get { return m_health; }
        set { m_health = value; }
    }
    
    
}

//public class Duck : MonoBehaviour, IAbilities, IStats
//{
 
//    public int health
//    {
//        get{ return health; }
//        set{ health = value; }
//    }

//    public void Health(int m_healthbar)
//    {
        
//    }

//    public void Movement(Vector3 s_move)
//    {
      
//    }

//    public void Stealth()
//    {
//        Console.WriteLine(".... Quack");
//        return;

//    }

//    int IAbilities.Health(int m_healthbar)
//    {
//        throw new NotImplementedException();
//    }
//}

namespace MyMain
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Ninja Player1 = new Ninja();
            Ninja Player2 = new Ninja();



            Console.WriteLine(Player1.Health(Convert.ToInt32 (Console.ReadLine())) - Player2.Health(Convert.ToInt32 ( Console.ReadLine())));
            Console.ReadKey();
        }
    }
}