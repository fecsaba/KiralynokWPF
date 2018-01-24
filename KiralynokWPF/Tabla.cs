using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace KiralynokWPF
{
    class Tábla
    {
        
        char[,] T;
        char ÜresCella;
        int R;
        int C;
        Random rnd = new Random();
        
        public Tábla (char üresCella, int r, int c)
        {
            T = new char[r, c];
            ÜresCella = üresCella;
            R = r;
            C = c;
            for (int sor = 0; sor < T.GetLength(0); sor++)
            {
                for (int oszlop = 0; oszlop < T.GetLength(1); oszlop++)
                {
                    T[sor, oszlop] = üresCella;
                }
            }
        }
       
        public void Elhelyez(int num, GraphSurface gs)
        {
            
            for (int i = 0; i < num;)
            {
                
                int sor = rnd.Next(0, R);
                int oszl = rnd.Next(0, C);
                if (T[sor, oszl] == ÜresCella)
                {
                    T[sor, oszl] = 'K';
                    gs.Lb[sor, oszl].Content = 'K';
                    i++;
                }
            }
            
        }
        bool UresOszlop(int sorAzon)
        {
            
            for (int i = 0; i < R; i++)
            {
                
                if (T[i, sorAzon] == 'K')
                {
                    return false;
                    
                }

            }
            return true;
        }
        bool UresSor(int sorAzon)
        {
            
            for (int oszl = 0; oszl < C; oszl++)
            {

                if (T[sorAzon, oszl] == 'K')
                {
                    return false;
                    
                }

            }
            return true;
        }
        public int UresSorokSzama
        {
            get
            {
                int uresDb = 0;
                for (int sor = 0; sor < R; sor++)
                {

                    if (UresSor(sor))
                    {
                        uresDb++;
                    }
                }
                return uresDb;
            }
        }
        public int UresOszlopokSzama
        {
            get
            {
                int uresDb = 0;
                for (int oszlop = 0; oszlop < C; oszlop++)
                {
                    if (UresOszlop(oszlop))
                    {
                        uresDb++;
                    }
                }
                return uresDb;
            }
        }
        public void FajlbaIr(StreamWriter sw)
        {
            for (int sor = 0; sor < T.GetLength(0); sor++) // 3c. fa.
            {
                for (int oszlop = 0; oszlop < T.GetLength(1); oszlop++) // Tab!!!
                {

                    
                    sw.Write($"{T[sor, oszlop]}");
                    

                }
                sw.WriteLine();
            }
            sw.WriteLine();
        }

    }
}
