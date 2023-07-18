using System.ComponentModel.DataAnnotations;


GetLenght("Deneme");
static int GetLenght(string word)
{
    int length = 0;
            
  if (word != null && word != string.Empty)
    {
        length = word.Length;
    }
    return length;
}