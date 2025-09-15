# Spare Parts Inventory Assistant
This is a simple C# console application that acts as a chat assistant for an industrial spare parts inventory.  
It asks the user which spare part they need and responds if it is available in stock.

Available parts in stock:
- hydraulic pump
- PLC module
- servo motor

How it works:
- The assistant asks: **"Which part do you need?"**
- If the user enters a part name **exactly as written above (it is case-sensitive)**, the assistant replies it is available and exits.
- If the name does not match, it replies that the part is not in the inventory.
- Special queries:
  - `Do you actually have any parts?`
  - `Is there anything in stock at all?`
    (these will show the number of parts and their names)
