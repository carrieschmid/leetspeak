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
         else if(array[index] =='o')
         {
          array[index] ='0';
         }
        //  if(i == "I")
        //  {
        //   i ="1";
        //  }
        //  if(i == "t")
        //  {
        //   i ="7";
        //  }
        //  if(i == "s")
        //  {
        //   i ="z";
        //  }
      }    
      string result = string.Join("", array);
          return result;
      
  }  
 }
}