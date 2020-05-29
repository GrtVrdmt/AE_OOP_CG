using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;

namespace Assets.Ressources
{

    public class Player
    {
        private int maxHp;
        private int hp;
        private int mana;
        private const int maxMana = 10;
        public Player(int maxHp, int mana)
        {
            
            SetMaxHp(maxHp);
            SetHp(GetMaxHp());
            SetMana(mana);
        }

        public int GetMaxHp()
        {
            return maxHp;
        }

        public void SetMaxHp(int value)
        {
            maxHp = value;
            if (GetHp() > maxHp)
                SetHp(maxHp);
        }

        public int GetHp()
        {
            return hp;
        }

        public void SetHp(int value)
        {
            hp = value;
            if (hp > maxHp)
                hp = maxHp;
        }

        public void updateHP(int amount)
        {
            hp += amount;
            if (hp > maxHp)
                hp = maxHp;
            if (hp <= 0)
                //Game Lost
                return;
        }

        public int GetMana()
        {
            return mana;
        }

        public void SetMana(int value)
        {
            mana = value;
        }

        public void updateMana(int amount)
        {
            mana += amount;
            if (mana > maxMana)
                mana = maxMana;
        }

    }
}