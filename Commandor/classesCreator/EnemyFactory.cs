using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;

public class EnemyFactory
{
    List<Enemy> enemies = new List<Enemy>();

    string[] arabNames = new string[]
        {
            "Ahmad", "Mohammed", "Ali", "Omar", "Yusuf", "Hassan", "Hussein", "Ibrahim", "Abdullah", "Khaled",
            "Saif", "Faisal", "Tariq", "Salim", "Nasser", "Zayd", "Amir", "Walid", "Samir", "Nabil",
            "Adel", "Karim", "Rami", "Anas", "Majed", "Mustafa", "Sami", "Rashid", "Bilal", "Farid",
            "Ziad", "Jamal", "Imad", "Basel", "Khalil", "Fadi", "Hamza", "Mahmoud", "Qasim", "Salah",
            "Ayman", "Aziz", "Hatem", "Laith", "Amer", "Raed", "Bakr", "Ghassan", "Marwan", "Yahya",
            "Alaa", "Munir", "Talal", "Sharif", "Nizar", "Bassam", "Habib", "Zuhair", "Kareem", "Naim",
            "Nader", "Rashad", "Tamer", "Hisham", "Fouad", "Kamal", "Ayham", "Othman", "Amin", "Fathi",
            "Jaber", "Mazin", "Sufyan", "Abed", "Issam", "Ilyas", "Abbas", "Safwan", "Ghazi", "Harith",
            "Obaida", "Yazid", "Younes", "Hani", "Samer", "Loai", "Najib", "Zaki", "Mazhar", "Ashraf",
            "Ehab", "Qutaibah", "Abdelrahman", "Rauf", "Shadi", "Tawfiq", "Qais", "Murad", "Tarik", "Rifat"
        };
        
    Random rand = new Random();
    public EnemyFactory()
    {
        Enemy e1 = new Enemy("mohamad");
        enemies.Add(e1);
        
        for (int i = 0; i< 10; i++)
        {
            enemies.Add(new Enemy(arabNames[rand.Next(0, arabNames.Length)]));
        }
    }


}