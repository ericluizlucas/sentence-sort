string sentence = "The lines are printed in reverse order.";
string edited = sentence;
string aux;
var dotExists = sentence.IndexOf('.');
if (dotExists >= 0)
{
    edited = sentence.Substring(0, sentence.Length - 1);
}
var array = edited.Split(" ");

for (int j = 0; j < array.Length; j++)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        array[i].ToLower();
        if (array[i].Length > array[i + 1].Length)
        {
            aux = array[i];
            array[i] = array[i + 1];
            array[i + 1] = aux;
        }
    }
}

string resp = " ";

string firstLetter = array[0].Substring(0, 1);
string str = array[0].Substring(1);
firstLetter = firstLetter.ToUpper();

array[0] = firstLetter + str;

for (int k = 0; k < array.Length; k++)
{
    if (k > 0) array[k] = array[k].ToLower();
    resp += array[k] + " ";
}
resp = resp.Substring(1, resp.Length - 2);
resp = resp + ".";

Console.WriteLine(resp);
