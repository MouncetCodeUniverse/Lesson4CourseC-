/*
الدرس 3:
التحويل بين الصيغ
في هذا الدرس سنتعلم كيفية التحويل بين الصيغ, وسنركز على التحويل من نص إلى رقم صحيح ومن نص إلى رقم عشري.
*/

// برنامج حساب العمر
System.Console.WriteLine("قم بإدخال سنة ميلادك:");
string input = Console.ReadLine();
// الطريقة الأولى:
//int year = Convert.ToInt32(input);
 // الطريقة الثانية:
//int year = int.Parse(input);
bool res = int.TryParse(input,out int year);
//System.Console.WriteLine(   res);
//System.Console.WriteLine(   year);
int result = DateTime.Today.Year - year;
Console.WriteLine($"عمرك هو {result} سنة.");

/*
يمكن تطبيق نفس الموضوع على الأرقام العشرية.
مثال:
double r = Convert.ToSingle(Console.ReadLine());
float r2 = float.Parse("1.12");
bool result1 = float.TryParse("1.12",out float f);
*/
