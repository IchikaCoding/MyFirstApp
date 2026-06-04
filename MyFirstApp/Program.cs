// 改行あり
// Consoleはクラス、WriteLine()はクラスのメソッド？
// ""の中身はLiteral文字列

Console.WriteLine("This is the second line.");

// 改行なし
Console.Write("Hello");
Console.Write("Ichika");
Console.Write("｡°(°¯᷄◠¯᷅°)°｡");


// 演習

Console.WriteLine("b");
Console.WriteLine(123);
// floatリテラルを作成するためにF追加
Console.WriteLine(0.25f); // 0.25
// doubleLiteral
Console.WriteLine(3.141592); // 3.141592
// decimal 型
Console.WriteLine(3.141592m); // 3.141592

// boolLiteral
Console.WriteLine(true); // True
Console.WriteLine(false); // Flase



// Output: 123
Console.WriteLine("123");
// Output: 123
Console.WriteLine(123);

// Output: true
Console.WriteLine("true");
// Output: True
Console.WriteLine(true);

// 値を代入しているから型推論が働くのでvarでOK
var firstName = "ichika";

// 変数名にデータ型をいれると良くないらしいけどこれはどうなの？
string stringName = "name";



char userOption;

int gameScore;
// decimalっぽさある？
decimal particlesPerMillion;
// これってboolっぽさある？
bool processedCustomer;


// =============2026/06/04=================

// 値の代入はset操作というらしい
//string LastName = "ichika";

string LastName;
//LastName = "ichika";
Console.WriteLine($"LastName: {LastName}");

string Name = "Bob";
Console.WriteLine($"Name: {Name}");

// messageってインスタンスなの？これは変数じゃないの？
// 型推論ができるときのみ使用可能→初期化しないなら使えない
// varはどうして使うの？
// あとから型を決めたい時。
// 初期化するなら型がわかりきっているからvarで省略してかけたらラク
var message = "Hello, Ichika";


