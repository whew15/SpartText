using System;
using System.Collections.Generic;
namespace 스파르타_던전
{
    public class Program
    {

        static void Main(string[] args)
        {
            int action = 0;
            int action2 = 0;
            string job = "전사";
            int Level = 01;
            int Power = 10;
            int ItemPower = 0;
            int Def = 5;
            int ItemDef = 0;
            int Hp = 100;
            int MaxHP = 100;
            int Gold = 1500;
            List<Item> list = new List<Item>();

            while (true)
            {
                switch (action)
                {
                    case 0:
                        {
                            start();
                            action = int.Parse(Console.ReadLine());
                            Console.Clear();
                            break;
                        }
                    case 1:
                        {
                            playerInfo();
                            action2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            shortcut();
                            break;
                        }
                    case 2:
                        {
                            ShowInventory();
                            action2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            shortcut();
                            break;
                        }
                    case 3:
                        {
                            Shop();
                            action2 = int.Parse(Console.ReadLine());
                            Console.Clear();
                            shortcut();
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("잘못 입력 하였습니다");
                            Console.Write(">>");
                            action = int.Parse(Console.ReadLine());
                            break;
                        }

            }

            void start()
            {
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine("");
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("");
                Console.WriteLine("원하시는 행동을 입력해주세요");
                Console.WriteLine(">>");
            }
            void playerInfo()
            {
                Console.WriteLine("상태 보기");
                Console.WriteLine("캐릭터의 정보가 표시됩니다.");
                Console.WriteLine();
                Console.WriteLine("LV." + Level);
                Console.WriteLine("직업 " + "(" + job + ")");
                Console.WriteLine("공격력 : " + Power + "(" + ItemPower + ")");
                Console.WriteLine("방어력 : " + Def + "(" + ItemDef + ")");
                Console.WriteLine("체 력 : " + Hp);
                Console.WriteLine("Gold : " + Gold + "G");
                Console.WriteLine();
                Console.WriteLine("0. 나가기");
                Console.WriteLine(">>");
            }
            void ShowInventory()
            {
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다");
                Console.WriteLine();
                Console.WriteLine("[아이템 목록]");
                Console.WriteLine("");
                Inventory();
                Console.WriteLine("");
                Console.WriteLine("1. 장착관리");
                Console.WriteLine("0. 나가기");
                Console.WriteLine("원하시는 행동을 입력해주세요");
                Console.WriteLine("");
                Console.WriteLine(">>");
            }                        
            void shortcut()
            {
                    while (true)
                    {
                        if (action == 2 && action2 == 1)
                        {
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            action = 0;
                            Console.Clear();
                            break;
                        }



                    
                        
                }
            }
        }

        void ItemList() //아이템구현
                {
                    new Item(1, "낡은 검    ", "무기", false, "공격력", 2, "쉽게 볼 수 있는 낡은 검 입니다.", 100, true);
                    new Item(2, "청동 도끼  ", "무기", false, "공격력", 5, "쉽게 볼 수 있는 낡은 검 입니다.", 100, false);
                    new Item(3, "스파르타의 창", "무기", true, "공격력", 7, "스파르타의 전사들이 사용했다는 전설의 창입니다.", 3500, true);
                    new Item(4, "수련자 갑옷 ", "장비", false, "방어력", 5, "수련에 도움을 주는 갑옷입니다.", 1000, false);
                    new Item(5, "무쇠갑옷    ", "장비", true, "방어력", 9, "무쇠로 만들어져 튼튼한 갑옷입니다.", 2000, true);
                    new Item(6, "스파르타의 갑옷", "장비", false, "방어력", 15, "스파르타의 전사들이 사용했다는 전설의 갑옷입니다.", 3500, false);
                }
            void Inventory() 
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string isEquipment = list[i].IsEquipment ? "E" : "X"; //true/false >>> "E" / "X"
                    if (list[i].IsBuy == true)
                    {
                        Console.WriteLine($"[{isEquipment}]{list[i].Name} | {list[i].Equipment} | {list[i].Type} +{list[i].ItemValue} | {list[i].Info} ");
                    }
                }
            }

            void Shop()
            {
                string isBuyChack = "";
                while (true)
                {
                    Console.WriteLine("상점");
                    Console.WriteLine("");
                    Console.WriteLine("[보유골드]:" + Gold);
                    Console.WriteLine("");
                    ItemList();
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].IsBuy == true)
                        {
                            isBuyChack = "[구매함]";
                        }
                        else
                        {
                            isBuyChack = list[i].Price.ToString();
                        }
                        Console.WriteLine($"{list[i].Name} | {list[i].Equipment} | {list[i].Type} +{list[i].ItemValue} | {list[i].Info} | = {isBuyChack}");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("1. 구매하기");
                    Console.WriteLine("2. 판매하기");
                    Console.WriteLine("0. 나가기");
                    Console.Write(">>");
                    int ShopTap = int.Parse(Console.ReadLine());
                    if (ShopTap == 0)
                    {
                        action2 = 0;
                        break;
                    }
                    else if (ShopTap == 1)
                    {
                        Console.Clear();
                        ShopBuy();
                    }
                    else if (ShopTap == 2)
                    {
                        Console.Clear();
                        ShopSell();
                    }
                    else { Console.Clear(); Console.WriteLine("잘못 입력 하였습니다"); }
                }
            }
            void ShopBuy()
            {
                int shopPrice = 0;

                while (true)
                {
                    Console.WriteLine("구매하기");
                    Console.WriteLine("");
                    Console.WriteLine("[보유골드]:" + Gold);
                    Console.WriteLine("");
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (!list[i].IsBuy)
                        {
                            list[i].Num = i;
                            shopPrice = list[i].Price;
                            Console.WriteLine($"{list[i].Num + 1} {list[i].Name} | {list[i].Equipment} | {list[i].Type} +{list[i].ItemValue} | {list[i].Info} | = {list[i].Price}");
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("0. 나가기");
                    Console.Write(">>");
                    int shopChoice = int.Parse(Console.ReadLine());
                    if (shopChoice == 0)
                    {
                        Shop();
                        break;
                    }
                    list[shopChoice - 1].IsBuy = !list[shopChoice - 1].IsBuy;
                    Gold = Gold - list[shopChoice - 1].Price;
                    Console.Clear();
                }
            }

            void ShopSell()
            {
                float sellPrice = 0;

                while (true)
                {
                    Console.WriteLine("판매하기");
                    Console.WriteLine("");
                    Console.WriteLine("[보유골드]:" + Gold);
                    Console.WriteLine("");
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].IsBuy == true)
                        {
                            sellPrice = (float)list[i].Price * 0.8f;
                            Console.WriteLine($"{i + 1} {list[i].Name} | {list[i].Equipment} | {list[i].Type} +{list[i].ItemValue} | {list[i].Info} | = {sellPrice}");
                        }
                    }
                    Console.WriteLine("");
                    Console.WriteLine("0. 나가기");
                    Console.Write(">>");
                    int shopChoice = int.Parse(Console.ReadLine());
                    if (shopChoice == 0)
                    {
                        Shop();
                        break;
                    }
                    list[shopChoice - 1].IsBuy = !list[shopChoice - 1].IsBuy;
                    if (list[shopChoice - 1].IsEquipment)
                    {
                        list[shopChoice - 1].IsEquipment = !list[shopChoice - 1].IsEquipment;
                    }
                    Gold += (int)(list[shopChoice - 1].Price * 0.85f);
                    Console.Clear();

                }
            }
        }

        class Item
        {
            public int num;
            private string name;
            private string equipment;
            private bool isEquipment;
            private string type;
            private int itemValue;
            private string info;
            private int price;
            private bool isBuy;

            public Item(int _num, string _itemName, string _equipment, bool _isEquipment, string _type, int _itemValue, string _info, int _price, bool _isBuy)
            {
                num = _num; //장비 번호
                name = _itemName; //장비이름
                isEquipment = _isEquipment; //장비 착용여부
                equipment = _equipment; //장비 장착 부위
                type = _type;  //아이템 능력(공격역,방어력)
                itemValue = _itemValue; // 아이템능력치
                info = _info;   // 소개
                price = _price; //가격
                isBuy = _isBuy; //구매 여부
            }
            public int Num
            {
                get { return num; }
                set { num = value; }
            }
            public string Name
            {
                get { return name; }
                set { name = value; }
            }
            public bool IsEquipment
            {
                get { return isEquipment; }
                set { isEquipment = value; }
            }
            public string Equipment
            {
                get { return equipment; }
                set { equipment = value; }
            }
            public string Type
            {
                get { return type; }
                set { type = value; }
            }
            public int ItemValue
            {
                get { return itemValue; }
                set { itemValue = value; }
            }
            public string Info
            {
                get { return info; }
                set { info = value; }
            }
            public int Price
            {
                get { return price; }
                set { price = value; }
            }
            public bool IsBuy
            {
                get { return isBuy; }
                set { isBuy = value; }
            }
        }
    }

}


