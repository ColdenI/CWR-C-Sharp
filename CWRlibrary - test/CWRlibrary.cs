using System;
using System.Collections.Generic;
using System.IO;

namespace CWR
{
    abstract class CWRbase
    {
        protected string Path { set; get; }

        protected void WriteFile(string text_for_write)
        {
            using (FileStream stream = new FileStream(this.Path, FileMode.Truncate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text_for_write);
                stream.Write(array, 0, array.Length);
            }
        }

        protected void WriteFileCreare(string text_for_write)
        {
            using (FileStream stream = new FileStream(this.Path, FileMode.OpenOrCreate))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text_for_write);
                stream.Write(array, 0, array.Length);
            }
        }

        protected void WriteFileAppend(string text_for_write)
        {
            using (FileStream stream = new FileStream(this.Path, FileMode.Append))
            {
                byte[] array = System.Text.Encoding.Default.GetBytes(text_for_write);
                stream.Write(array, 0, array.Length);
            }
        }

        protected string ReadFile()
        {
            try
            {
                using (FileStream stream = File.OpenRead(this.Path))
                {
                    byte[] array = new byte[stream.Length];
                    stream.Read(array, 0, array.Length);
                    return System.Text.Encoding.Default.GetString(array);
                }
            }
            catch (FileNotFoundException)
            {
                return "FileNotFoundException!";
            }
        }

        protected CWRbase(string Path)
        {
            this.Path = Path;
            WriteFileCreare("");
        }

    }

    class CWRFile : CWRbase
    {
        public CWRFile(string Path) : base(Path)
        {          
        }

        public string Read()
        {
            return ReadFile();
        }
        
        public void Write(string Text)
        {
            WriteFile(Text);
        }

        public void Append(string text)
        {
            WriteFileAppend(text);
        }
    }

    class CWRItem : CWRbase
    {
        public CWRItem(string Path) : base(Path)
        {
        }

        public string[] GetItems()
        {
            string[] i_item_1_a = ReadFile().Split("</");
            List<string> i_item_1_l = new List<string>();

            foreach (string i in i_item_1_a)
                i_item_1_l.Add(i.Split(">")[0]);

            i_item_1_l.RemoveAt(0);
            string[] i_item_2_a = new string[i_item_1_l.Count];

            for (int i = 0; i < i_item_1_l.Count; i++)
            {
                i_item_2_a[i] = i_item_1_l[i];
            }

            return i_item_2_a;
        }
  
        public bool ContainsItem(string Item)
        {
            foreach (string i in this.GetItems())
            {
                if (i == Item)
                    return true;
            }
            return false;
        }

        public void RemoveItem(string name)
        {
            if (this.ContainsItem(name)) {
                //Console.WriteLine(this.ReadFile().ToString().Normalize().Split("<" + name + ">")[0] + this.ReadFile().ToString().Normalize().Split("</" + name + ">")[1]);
                this.WriteFile(this.ReadFile().ToString().Normalize().Split("<" + name + ">")[0] + this.ReadFile().ToString().Normalize().Split("</" + name + ">")[1]);
            }
        }

        private void Create()
        {
            this.WriteFile("");
        }


        public string  GetItemString  (string Item)
        {
            return ReadFile().Split("<" + Item + ">")[1].Split("</" + Item + ">")[0];
        }
        public char    GetItemChar    (string Item)
        {
            return Convert.ToChar(this.GetItemString(Item));
        }
        public double  GetItemDouble  (string Item)
        {
            return Convert.ToDouble(this.GetItemString(Item));
        }
        public bool    GetItemBoolean (string Item)
        {
            return Convert.ToBoolean(this.GetItemString(Item));
        }
        public float   GetItemFloat   (string Item)
        {
            return Convert.ToSingle(this.GetItemString(Item));
        }
        public decimal GetItemDecimal (string Item)
        {
            return Convert.ToDecimal(this.GetItemString(Item));
        }
        public byte    GetItemByte    (string Item)
        {
            return Convert.ToByte(this.GetItemString(Item));
        }
        public sbyte   GetItemSByte   (string Item)
        {
            return Convert.ToSByte(this.GetItemString(Item));
        }
        public int     GetItemInt     (string Item)
        {
            return Convert.ToInt32(this.GetItemString(Item));
        }
        public short   GetItemShort   (string Item)
        {
            return Convert.ToInt16(this.GetItemString(Item));
        }
        public long    GetItemLong    (string Item)
        {
            return Convert.ToInt64(this.GetItemString(Item));
        }
        public uint    GetItemUInt    (string Item)
        {
            return Convert.ToUInt32(this.GetItemString(Item));
        }
        public ushort  GetItemUShort  (string Item)
        {
            return Convert.ToUInt16(this.GetItemString(Item));
        }
        public ulong   GetItemULong   (string Item)
        {
            return Convert.ToUInt64(this.GetItemString(Item));
        }


        public void AddItem(string Item, string  Value)
        {
            if (!this.ContainsItem(Item))
                this.WriteFile("<" + Item + ">" + Value + "</" + Item + ">\n" + ReadFile());
        }
        public void AddItem(string Item, char    Value)
        {
            this.AddItem(Item, Value.ToString());
        }
        public void AddItem(string Item, float   Value)
        {
            this.AddItem(Item, Value.ToString());
        }
        public void AddItem(string Item, double  Value)
        {
            this.AddItem(Item, Value.ToString());
        }
        public void AddItem(string Item, decimal Value)
        {
            this.AddItem(Item, Value.ToString());
        }
        public void AddItem(string Item, bool    Value)
        {
            this.AddItem(Item, Value.ToString());
        }
        public void AddItem(string Item, byte    Value)
        {
            this.AddItem(Item, Value.ToString());
        }
        public void AddItem(string Item, sbyte   Value)
        {
            this.AddItem(Item, Value.ToString());
        }
        public void AddItem(string Item, int     Value)
        {
            this.AddItem(Item, Value.ToString());
        }
        public void AddItem(string Item, short   Value)
        {
            this.AddItem(Item, Value.ToString());
        }
        public void AddItem(string Item, long    Value)
        {
            this.AddItem(Item, Value.ToString());
        }
        public void AddItem(string Item, uint    Value)
        {
            this.AddItem(Item, Value.ToString());
        }
        public void AddItem(string Item, ushort  Value)
        {
            this.AddItem(Item, Value.ToString());
        }
        public void AddItem(string Item, ulong   Value)
        {
            this.AddItem(Item, Value.ToString());
        }


        public void SetItem(string Item, string  Value)
        {
            if (this.ContainsItem(Item))
                this.WriteFile(this.ReadFile().Split("<" + Item + ">")[0] + "<" + Item + ">" + Value + "</" + Item + ">" + this.ReadFile().Split("</" + Item + ">")[1] + "");
        }
        public void SetItem(string Item, char    Value)
        {
            this.SetItem(Item, Value.ToString());
        }
        public void SetItem(string Item, float   Value)
        {
            this.SetItem(Item, Value.ToString());
        }
        public void SetItem(string Item, double  Value)
        {
            this.SetItem(Item, Value.ToString());
        }
        public void SetItem(string Item, decimal Value)
        {
            this.SetItem(Item, Value.ToString());
        }
        public void SetItem(string Item, bool    Value)
        {
            this.SetItem(Item, Value.ToString());
        }
        public void SetItem(string Item, byte    Value)
        {
            this.SetItem(Item, Value.ToString());
        }
        public void SetItem(string Item, sbyte   Value)
        {
            this.SetItem(Item, Value.ToString());
        }
        public void SetItem(string Item, int     Value)
        {
            this.SetItem(Item, Value.ToString());
        }
        public void SetItem(string Item, short   Value)
        {
            this.SetItem(Item, Value.ToString());
        }
        public void SetItem(string Item, long    Value)
        {
            this.SetItem(Item, Value.ToString());
        }
        public void SetItem(string Item, uint    Value)
        {
            this.SetItem(Item, Value.ToString());
        }
        public void SetItem(string Item, ushort  Value)
        {
            this.SetItem(Item, Value.ToString());
        }
        public void SetItem(string Item, ulong   Value)
        {
            this.SetItem(Item, Value.ToString());
        }


        public void SetOrAddItem(string Item, string  Value)
        {
            if (this.ContainsItem(Item))
                this.SetItem(Item, Value);
            else
                this.AddItem(Item, Value);
        }
        public void SetOrAddItem(string Item, char    Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }
        public void SetOrAddItem(string Item, float   Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }
        public void SetOrAddItem(string Item, double  Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }
        public void SetOrAddItem(string Item, decimal Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }
        public void SetOrAddItem(string Item, bool    Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }
        public void SetOrAddItem(string Item, byte    Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }
        public void SetOrAddItem(string Item, sbyte   Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }
        public void SetOrAddItem(string Item, int     Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }
        public void SetOrAddItem(string Item, short   Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }
        public void SetOrAddItem(string Item, long    Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }
        public void SetOrAddItem(string Item, uint    Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }
        public void SetOrAddItem(string Item, ushort  Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }
        public void SetOrAddItem(string Item, ulong   Value)
        {
            this.SetOrAddItem(Item, Value.ToString());
        }



    }
}
