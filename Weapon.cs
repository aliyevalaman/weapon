using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Weapon
    {
        public byte CapacityBullet;
        public byte CurrentBullet;
        public bool FireMode;


        public Weapon(byte CapacityBullet, byte CurrentBullet, bool fireMode)
        {
            this.CapacityBullet = CapacityBullet;
            this.CurrentBullet = CurrentBullet;
            this.FireMode = fireMode;
        }

        public void Shoot()
        {
            if(FireMode = false)
            {
                CurrentBullet= 1;
                Console.WriteLine("Tekli ata bilersiz sadece");
            }

            else
            {
                CapacityBullet = 0;
                Console.WriteLine("Darag boshdur");
            }
        }

        public int GetRemainBulletCount()
        {
            return CapacityBullet - CurrentBullet;
           
        }


        public void Reload()
        {
            CapacityBullet = CurrentBullet;
        }
        
        public void ChangeFireMode()
        {
            FireMode = !FireMode;
            if (FireMode)
            {
                Console.WriteLine("Avtromotik");
            }
            else
            {
                Console.WriteLine("tekdir");
            }
        }

       

    }
}
