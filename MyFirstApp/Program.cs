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
LastName = "ichika";
Console.WriteLine($"LastName: {LastName}");

string Name = "Bob";
Console.WriteLine($"Name: {Name}");

// messageってインスタンスなの？これは変数じゃないの？
// 型推論ができるときのみ使用可能→初期化しないなら使えない
//varはどうして使うの？
// あとから型を決めたい時。
// 初期化するなら型がわかりきっているからvarで省略してかけたらラク
var message = "Hello, Ichika";


// ---------------------------------

// ボブと3と34.4を格納
// 正しいデータ型を選択
// 出力：Hello, Bob! You have 3 messages in your inbox. The temperature is 34.4 celsius.

string bob = "Bob";
int count = 3;
double temperature = 34.4;

// 後ろにスペースいれると見やすいよ
Console.Write($"Hello, {bob}! ");
Console.Write($"You have {count} messages in your inbox. ");
Console.Write($"The temperature is {temperature} celsius.");

// =========文字エスケープ シーケンス============

Console.WriteLine("Hello\nWorld!");
// 間にタブのスペースが入る
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World\"");

Console.WriteLine("c:\\source\\repos");


Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
// WriteLine()は出力の前に改行をいれる
Console.WriteLine("Invoice: 1022\t\tComplete!");
// 1行空行を作成したいから先頭に\n
// コロンのあとにスペースが欲しいから\tをいれる
Console.Write("\nOutput Directory:\t");


// =========逐語的文字列リテラル============

// @ を使用すると、内側の文字列でエスケープされなくなる
Console.WriteLine(@"    c:\source\repos    
        (this is where your code goes)");