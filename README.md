# CWR - C# (sharp)
CWR is a library for working with data from files. It contains 2 classes for normal work with files and for work with saving data (parameters, settings).

## CWR File
>For reading/writing files.

**When creating objects, pass the file path parameter.**

Method for reading the entire text from a file:

	string Read()

Method for writing text to a file:

	void Write(string Text)

Method for append text to file:

	void Append(string Text)

## CWR Item 
>To read and write an item. The item is a convenient way to write and retrieve data from a file (convenient for parameters).

**When creating objects, pass the file path parameter.**

Method for getting all existing items in the file:

	string[] GetItems()

Method for checking the presence of item in the file:

	ContainsItem(string Item)
	
Method for deleting an item from a file:

	RemoveItem(string name)
	
Method for adding an item to a file (and overloading it):

	void AddItem(string Item, string  Value)
	
	void AddItem(string Item, char    Value)
	
	void AddItem(string Item, float   Value)
	
	void AddItem(string Item, double  Value)
	
	void AddItem(string Item, decimal Value)
	
	void AddItem(string Item, bool    Value)
	
	void AddItem(string Item, byte    Value)
	
	void AddItem(string Item, sbyte   Value)
	
	void AddItem(string Item, int     Value)
	
	void AddItem(string Item, short   Value)
	
	void AddItem(string Item, long    Value)
	
	void AddItem(string Item, uint    Value)
	
	void AddItem(string Item, ushort  Value)
	
	void AddItem(string Item, ulong   Value)

Method for changing the value of item in a file (and overloading it):

	void SetItem(string Item, string  Value)
	
	void SetItem(string Item, char    Value)
	
	void SetItem(string Item, float   Value)
	
	void SetItem(string Item, double  Value)
	
	void SetItem(string Item, decimal Value)
	
	void SetItem(string Item, bool    Value)
	
	void SetItem(string Item, byte    Value)
	
	void SetItem(string Item, sbyte   Value)
	
	void SetItem(string Item, int     Value)
	
	void SetItem(string Item, short   Value)
	
	void SetItem(string Item, long    Value)
	
	void SetItem(string Item, uint    Value)
	
	void SetItem(string Item, ushort  Value)
	
	void SetItem(string Item, ulong   Value)

Method for changing the value or creating a new item in a file (and overloading it):

	void SetOrAddItem(string Item, string  Value)
	
	void SetOrAddItem(string Item, char    Value)
	
	void SetOrAddItem(string Item, float   Value)
	
	void SetOrAddItem(string Item, double  Value)
	
	void SetOrAddItem(string Item, decimal Value)
	
	void SetOrAddItem(string Item, bool    Value)
	
	void SetOrAddItem(string Item, byte    Value)
	
	void SetOrAddItem(string Item, sbyte   Value)
	
	void SetOrAddItem(string Item, int     Value)
	
	void SetOrAddItem(string Item, short   Value)
	
	void SetOrAddItem(string Item, long    Value)
	
	void SetOrAddItem(string Item, uint    Value)
	
	void SetOrAddItem(string Item, ushort  Value)
	
	void SetOrAddItem(string Item, ulong   Value)
	
Method of getting item from file (and its variants):

	string  GetItemString  (string Item)
	
	char    GetItemChar    (string Item)
	
	double  GetItemDouble  (string Item)
	
	bool    GetItemBoolean (string Item)
	
	float   GetItemFloat   (string Item)
	
	decimal GetItemDecimal (string Item)
	
	byte    GetItemByte    (string Item)
	
	sbyte   GetItemSByte   (string Item)
	
	int     GetItemInt     (string Item)
	
	short   GetItemShort   (string Item)
	
	long    GetItemLong    (string Item)
	
	uint    GetItemUInt    (string Item)
	
	ushort  GetItemUShort  (string Item)
	
	ulong   GetItemULong   (string Item)
