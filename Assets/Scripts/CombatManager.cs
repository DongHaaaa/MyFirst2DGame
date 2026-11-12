using UnityEngine;
public class Character
{
    public string name;
    public int hp;
    public int attack;
    public Character(string charName, int charHp, int charAttack)
    {
        name = charName;
        hp = charHp;
        attack = charAttack;
    }
    //virtual là cho phép ghi đè
    public virtual void TakeDmg(int damage)
    {
        hp -= damage;
    }
    public bool IsAlive()
    {
        return hp > 0;
    }
}

public class Player : Character
{
    public Player(string playerName, int playerHp, int playerAttack) :base(playerName, playerHp, playerAttack)
    {
    }
    public override void TakeDmg(int damage)
    {
        hp -= damage;
        Debug.Log("Player is taking damage...");
    }

}
public class Enemy : Character
{
    public Enemy(string enemyName, int enemyHp, int enemyAttack) :base(enemyName, enemyHp, enemyAttack)
    {
    }
    public override void TakeDmg(int damage)
    {
        hp -= damage;
        Debug.Log("Enemy is taking damage...");
    }
}
public class CombatManager : MonoBehaviour
{
    public Character player = new Player("Player", 100, 10);
    public Character enemy = new Enemy("Enemy", 50, 20);
    void Start()
    {
        for(int i = 0; i < 10; i++)
        {
            player.TakeDmg(enemy.attack);
        }

        Debug.Log("Player HP: " + player.hp);
        Debug.Log("Enemy HP: " + enemy.hp);

        bool isplayerAlive = player.IsAlive();
        if(isplayerAlive) Debug.Log("Player is alive");
        else Debug.Log("Player is dead");
    }
}
//về coi lại cái protected virtual
