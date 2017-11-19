using System;
using System.Collections.Generic;

namespace democlasslib
{
    public class MoneyChanger
    {
        int[] bankValues = { 1000, 500, 100, 50, 20, 10, 5, 1 };
        public int[,] ChangeMoney(int amount, int pay) {
            var change = CalcMoneyToChange(amount, pay);
            var changes = new List<KeyValuePair<int, int>>();

            foreach (var v in bankValues)
            {
                if (change >= v)
                {
                    var cnt = change / v;
                    change = change % v;
                    changes.Add(new KeyValuePair<int, int>(v, cnt));
                }
            }
            var changesArray = new int [changes.Count, 2];
            for (int i = 0; i < changes.Count; i++)
            {
                changesArray[i, 0] = changes[i].Key;
                changesArray[i, 1] = changes[i].Value;
            }

            return changesArray;
        }

        public int CalcMoneyToChange(int amount, int pay) {
            return pay - amount;
        }
    }
}