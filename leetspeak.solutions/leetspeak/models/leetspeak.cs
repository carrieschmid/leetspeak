namespace LeetSpeak
{

public class LeetSpeakTranslator
{
  public string Main(string translator)
  {
      char[] array = translator.ToCharArray();
      for(int index = 0; index < array.Length; index++)
      {

         if(array [index] == 'e')
         {
          array[index] ='3';
         }
         if(array[index] =='o')
         {
          array[index] ='0';
         }
         if(array[index] == 'I')
         {
          array[index] ='1';
         }
         if(array[index] == 't')
         {
          array[index] ='7';
         }
         if(array[index] == 's')
         {
          array[index] ='z';
         }
      }    
      string result = string.Join("", array);
          return result;
      
  }  
 }
}