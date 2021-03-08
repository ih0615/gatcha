using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gatcha
{
    class Draw
    {
        public static Item DrawOne(int count)
        {
            Item drawedItem = new Item();
            Random rand = new Random();
            
            //10 draw one 4
            if (count != 0 && count % 10 == 0)
            {
                double firstDivision = rand.NextDouble() * 100;
                //4성 무기
                if (0 <= firstDivision && firstDivision <= 4.958)
                {
                    //4성 무기 중 로테 무기
                    int secondDivision = rand.Next(0, 1001);
                    if (secondDivision <= 505)
                    {
                        drawedItem = ItemManager.pickUpEquip;
                    }
                    //4성 무기 중 비로테 무기
                    else
                    {
                        drawedItem = ItemManager.equip[rand.Next(0, 6)];
                    }
                }
                //4성 성흔
                else if (firstDivision <= 12.395)
                {
                    bool secondDivision = rand.Next(0, 2) == 0 ? true : false;
                    //4성 성흔 중 로테 성흔
                    if (secondDivision)
                    {
                        drawedItem = ItemManager.pickUpStigma[rand.Next(0, 3)];
                    }
                    //4성 성흔 중 비로테 성흔
                    else
                    {
                        drawedItem = ItemManager.stigma[rand.Next(0, 12)];
                    }
                }
                else
                {
                    drawedItem.name = "잡템";
                    drawedItem.rare = 3;
                }
            }
            else
            {
                double firstDivision = rand.NextDouble() * 100;
                //4성 무기
                if (firstDivision <= 40)
                {
                    //4성 무기 중 로테 무기
                    int secondDivision = rand.Next(0, 1001);
                    if (secondDivision <= 505)
                    {
                        drawedItem = ItemManager.pickUpEquip;
                    }
                    //4성 무기 중 비로테 무기
                    else
                    {
                        drawedItem = ItemManager.equip[rand.Next(0, 6)];
                    }
                }
                //4성 성흔
                else
                {
                    bool secondDivision = rand.Next(0, 2) == 0 ? true : false;
                    //4성 성흔 중 로테 성흔
                    if (secondDivision)
                    {
                        drawedItem = ItemManager.pickUpStigma[rand.Next(0, 3)];
                    }
                    //4성 성흔 중 비로테 성흔
                    else
                    {
                        drawedItem = ItemManager.stigma[rand.Next(0, 12)];
                    }
                }
            }
            return drawedItem;
        }
    }
}
