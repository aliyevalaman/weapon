namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Weapon gun = new Weapon(10, 5, false);

            int choice = -1;
            while (choice != 5)
            {
                Console.WriteLine("0 - İnformasiya almaq üçün");
                Console.WriteLine("1 - Ateş açmaq üçün");
                Console.WriteLine("2 - GetRemainBulletCount metodu üçün");
                Console.WriteLine("3 - Reload metodu üçün");
                Console.WriteLine("4 - ChangeFireMode metodu üçün");
                Console.WriteLine("5 - Proqramdan dayandırmaq üçün");

                Console.Write("Seçiminizi daxil edin: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("CapacityBullet: " + gun.CapacityBullet);
                        Console.WriteLine("CurrentBullet: " + gun.CurrentBullet);
                        Console.WriteLine("FireMode: " + (gun.FireMode ? "Avtomatik" : "Tekli"));
                        break;
                    case 1:
                        gun.Shoot();
                        break;
                    case 2:
                        int remainBulletCount = gun.GetRemainBulletCount();
                        Console.WriteLine("Qalan güllə sayı: " + remainBulletCount);
                        break;
                    case 3:
                        gun.Reload();
                        break;
                    case 4:
                        gun.ChangeFireMode();
                        break;
                    case 5:
                        Console.WriteLine("Proqram dayandırıldı.");
                        break;
                    default:
                        Console.WriteLine("Yanlış seçim. Yenidən seçim edin.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}