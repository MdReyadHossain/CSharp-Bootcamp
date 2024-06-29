string name = "Reyad Hossain";
string[] names = name.Split(',', ' '); // returs an array of string by split ["Reyad", "Hossain"]
string femaleName = name.Substring(0, 4); // Reya, name.Substring(8): ssain
Console.WriteLine($"First Name is {names[0]} and Last name is {names[1]}\n");
Console.WriteLine("femaleName = {0}\n", femaleName);

int ascii = 'R';
Console.WriteLine("Ascii value of R is {0}\n", ascii);

bool isStartWith = name.StartsWith('R');
Console.WriteLine($"Is {names[0]} start with R? {isStartWith}\n");

uint bin = 0b_0000_1111_0000_1111_0000_1111_0000_1010;
uint bin1sComplement = ~bin << 4;
Console.WriteLine($"{Convert.ToString(bin, toBase: 2)}\n{Convert.ToString(bin1sComplement, toBase: 2)}\n");

uint bin1 = 0b_1010_0111;
uint bin2 = 0b_0110_0101;
uint andOp = bin1 & bin2;
uint orOp = bin1 | bin2;
uint xorOp = bin1 ^ bin2;

Console.WriteLine(  $"And = {Convert.ToString(andOp, toBase: 2)}" +
                    $"\nOr = {Convert.ToString(orOp, toBase: 2)}" +
                    $"\nXor = {Convert.ToString(xorOp, toBase: 2)}\n");

Console.WriteLine($"3rd letter of name: {name[2]}\n"); // can not assign a value to the index of this name